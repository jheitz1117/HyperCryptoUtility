using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Hyper.Cryptography;
using Hyper.Extensibility.IO;
using Hyper.IO;

namespace HyperCryptoUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            cboPlainTextStringTransformType.Items.Clear();
            cboCipherTextStringTransformType.Items.Clear();

            // List of supported transforms
            var stringTransformTypes = new[]
            {
                new StringTransformComboBoxItem("Default Encoding", StringTransform.FromEncoding(Encoding.Default)),
                new StringTransformComboBoxItem("Base64", StringTransform.GetBase64Transform()),
                new StringTransformComboBoxItem("Hex", StringTransform.GetHexTransform())
            };

            // Each combo box gets its own copy of the transform list
            cboPlainTextStringTransformType.DataSource = new List<StringTransformComboBoxItem>(stringTransformTypes);
            cboCipherTextStringTransformType.DataSource = new List<StringTransformComboBoxItem>(stringTransformTypes);

            // Make sure we always select our first item
            cboPlainTextStringTransformType.SelectedIndex = 0;
            cboCipherTextStringTransformType.SelectedIndex = 0;
        }

        #region Events

        private void frmMain_Shown(object sender, EventArgs e)
        {
            btnGenerateKey.PerformClick();
            btnGenerateIV.PerformClick();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            txtEncryptionKey.Text = "";

            // Only generate a key if we have an actual algorithm selected
            if (!optAlgorithmNone.Checked)
                txtEncryptionKey.Text = CreateEncryptionService2().GenerateKeyString();
        }

        private void btnGenerateIV_Click(object sender, EventArgs e)
        {
            txtInitializationVector.Text = "";

            // Only generate an IV if we have an actual algorithm selected
            if (!optAlgorithmNone.Checked)
                txtInitializationVector.Text = CreateEncryptionService2().GenerateIvString();
        }

        private void EncryptDecrypt_Click(object sender, EventArgs e)
        {
            var key = txtEncryptionKey.Text.Trim();
            var iv = txtInitializationVector.Text.Trim();
            
            try
            {
                var encryptionService = CreateEncryptionService2();

                Func<byte[], string, string, byte[]> fileTransformDelegate = null;
                Func<string, string, string, string> stringTransformDelegate = null;

                string saveDialogTitle;
                TextBox srcStringTextBox;
                TextBox dstStringTextBox;
                TextBox srcPathTextBox;
                TextBox dstPathTextBox;

                if (sender == cmdEncrypt)
                {
                    fileTransformDelegate = encryptionService.Encrypt;
                    stringTransformDelegate = encryptionService.EncryptString;
                    srcStringTextBox = txtPlainText;
                    dstStringTextBox = txtCipherText;

                    saveDialogTitle = "Save Encrypted File";
                    srcPathTextBox = txtPlainFilePath;
                    dstPathTextBox = txtCipherFilePath;
                }
                else if (sender == cmdDecrypt)
                {
                    fileTransformDelegate = encryptionService.Decrypt;
                    stringTransformDelegate = encryptionService.DecryptString;
                    srcStringTextBox = txtCipherText;
                    dstStringTextBox = txtPlainText;

                    saveDialogTitle = "Save Decrypted File";
                    srcPathTextBox = txtCipherFilePath;
                    dstPathTextBox = txtPlainFilePath;
                }
                else
                    throw new InvalidOperationException("Unable to determine whether to encrypt or decrypt.");

                if (tabEncryptionMode.SelectedTab == tpgEncryptionModeText)
                {
                    dstStringTextBox.Text = "";
                    dstStringTextBox.Text = stringTransformDelegate(srcStringTextBox.Text, key, iv);
                }
                else if (tabEncryptionMode.SelectedTab == tpgEncryptionModeFile)
                {
                    bool canTransformFile = false;
                    var dstFilePath = dstPathTextBox.Text.Trim();
                    if (string.IsNullOrWhiteSpace(dstFilePath))
                    {
                        var targetDirectory = Path.GetDirectoryName(srcPathTextBox.Text);
                        var initialDirectory = Environment.CurrentDirectory;
                        if (!string.IsNullOrWhiteSpace(targetDirectory) && Directory.Exists(targetDirectory))
                            initialDirectory = targetDirectory;

                        var dlgSaveAs = new SaveFileDialog
                        {
                            Filter = "All Files|*.*",
                            InitialDirectory = initialDirectory,
                            OverwritePrompt = true,
                            RestoreDirectory = true,
                            SupportMultiDottedExtensions = true,
                            Title = saveDialogTitle
                        };

                        if (dlgSaveAs.ShowDialog(this) == DialogResult.OK)
                        {
                            dstPathTextBox.Text = dlgSaveAs.FileName;
                            canTransformFile = true;
                        }
                    }
                    else if (File.Exists(dstFilePath))
                    {
                        canTransformFile = (
                            MessageBox.Show(
                                string.Format("{0} already exists.\r\n Do you want to replace it?", Path.GetFileName(dstFilePath)),
                                "Confirm Save As",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2
                            ) == DialogResult.Yes
                        );
                    }

                    if (canTransformFile)
                    {
                        var destinationDirectory = Path.GetDirectoryName(dstPathTextBox.Text) ?? "";
                        if (!Directory.Exists(destinationDirectory))
                            Directory.CreateDirectory(destinationDirectory);

                        using (var dstWriter = new FileStream(dstPathTextBox.Text, FileMode.Create))
                        {
                            var dstBytes = fileTransformDelegate(File.ReadAllBytes(srcPathTextBox.Text), key, iv);
                            dstWriter.Write(dstBytes, 0, dstBytes.Length);
                            dstWriter.Flush();
                            dstWriter.Close();
                        }    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tpgEncryptionModeTextFile_Resize(object sender, EventArgs e)
        {
            grpPlainText.Width = (tpgEncryptionModeText.Width - tpgEncryptionModeText.Padding.Left - tpgEncryptionModeText.Padding.Right) / 2;
            grpPlainFile.Width = (tpgEncryptionModeFile.Width - tpgEncryptionModeFile.Padding.Left - tpgEncryptionModeFile.Padding.Right) / 2;
        }

        private void cmdBrowsePlainCipherFilePath_Click(object sender, EventArgs e)
        {
            string openDialogTitle;
            TextBox txtFilePath;

            if (sender == cmdBrowsePlainFilePath)
            {
                openDialogTitle = "Encrypt File";
                txtFilePath = txtPlainFilePath;
            }
            else if (sender == cmdBrowseCipherFilePath)
            {
                openDialogTitle = "Decrypt File";
                txtFilePath = txtCipherFilePath;
            }
            else
                throw new InvalidOperationException("Unable to determine whether to encrypt or decrypt.");

            var dlgOpen = new OpenFileDialog
            {
                Filter = "All Files|*.*",
                Multiselect = false,
                RestoreDirectory = true,
                Title = openDialogTitle
            };

            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
                txtFilePath.Text = dlgOpen.FileName;
        }

        #endregion Events

        #region Private Methods

        private SymmetricEncryptionService CreateEncryptionService2()
        {
            return new SymmetricEncryptionService(
                new SymmetricEncryptionConfiguration
                {
                    AlgorithmType = GetAlgorithmType(),
                    CipherMode = GetCipherMode(),
                    PaddingMode = GetPaddingMode(),
                    PlainTextTransform = cboPlainTextStringTransformType.SelectedValue as IStringTransform,
                    CipherTextTransform = cboCipherTextStringTransformType.SelectedValue as IStringTransform,
                    IvTransform = chkIvIsHex.Checked ? StringTransform.GetHexTransform() : StringTransform.FromEncoding(Encoding.Default),
                    KeyTransform = chkKeyIsHex.Checked ? StringTransform.GetHexTransform() : StringTransform.FromEncoding(Encoding.Default)
                }
            );
        }

        private SymmetricAlgorithmType GetAlgorithmType()
        {
            var algorithm = SymmetricAlgorithmType.None;

            if (optAlgorithmTripleDES.Checked)
                algorithm = SymmetricAlgorithmType.TripleDes;
            else if (optAlgorithmDES.Checked)
                algorithm = SymmetricAlgorithmType.Des;
            else if (optAlgorithmRC2.Checked)
                algorithm = SymmetricAlgorithmType.Rc2;
            else if (optAlgorithmRijndael.Checked)
                algorithm = SymmetricAlgorithmType.Rijndael;
            else if (optAlgorithmAES.Checked)
                algorithm = SymmetricAlgorithmType.Aes;

            return algorithm;
        }

        private CipherMode GetCipherMode()
        {
            var cipherMode = CipherMode.CBC;

            if (optCipherModeCBC.Checked)
                cipherMode = CipherMode.CBC;
            else if (optCipherModeCFB.Checked)
                cipherMode = CipherMode.CFB;
            else if (optCipherModeCTS.Checked)
                cipherMode = CipherMode.CTS;
            else if (optCipherModeECB.Checked)
                cipherMode = CipherMode.ECB;
            else if (optCipherModeOFB.Checked)
                cipherMode = CipherMode.OFB;

            return cipherMode;
        }

        private PaddingMode GetPaddingMode()
        {
            var paddingMode = PaddingMode.None;

            if (optPaddingModeANSIX923.Checked)
                paddingMode = PaddingMode.ANSIX923;
            else if (optPaddingModeISO10126.Checked)
                paddingMode = PaddingMode.ISO10126;
            else if (optPaddingModePKCS7.Checked)
                paddingMode = PaddingMode.PKCS7;
            else if (optPaddingModeZeros.Checked)
                paddingMode = PaddingMode.Zeros;

            return paddingMode;
        }

        #endregion Private Methods
    }
}
