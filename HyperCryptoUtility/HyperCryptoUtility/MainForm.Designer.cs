namespace HyperCryptoUtility
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPaddingMode = new System.Windows.Forms.Panel();
            this.optPaddingModeNone = new System.Windows.Forms.RadioButton();
            this.optPaddingModeZeros = new System.Windows.Forms.RadioButton();
            this.optPaddingModeISO10126 = new System.Windows.Forms.RadioButton();
            this.optPaddingModePKCS7 = new System.Windows.Forms.RadioButton();
            this.optPaddingModeANSIX923 = new System.Windows.Forms.RadioButton();
            this.lblCipherMode = new System.Windows.Forms.Label();
            this.pnlCipherMode = new System.Windows.Forms.Panel();
            this.optCipherModeOFB = new System.Windows.Forms.RadioButton();
            this.optCipherModeECB = new System.Windows.Forms.RadioButton();
            this.optCipherModeCTS = new System.Windows.Forms.RadioButton();
            this.optCipherModeCBC = new System.Windows.Forms.RadioButton();
            this.optCipherModeCFB = new System.Windows.Forms.RadioButton();
            this.pnlAlgorithm = new System.Windows.Forms.Panel();
            this.optAlgorithmAES = new System.Windows.Forms.RadioButton();
            this.optAlgorithmNone = new System.Windows.Forms.RadioButton();
            this.optAlgorithmRijndael = new System.Windows.Forms.RadioButton();
            this.optAlgorithmDES = new System.Windows.Forms.RadioButton();
            this.optAlgorithmRC2 = new System.Windows.Forms.RadioButton();
            this.optAlgorithmTripleDES = new System.Windows.Forms.RadioButton();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.cmdEncrypt = new System.Windows.Forms.Button();
            this.tabEncryptionMode = new System.Windows.Forms.TabControl();
            this.tpgEncryptionModeText = new System.Windows.Forms.TabPage();
            this.grpCipherText = new System.Windows.Forms.GroupBox();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.tplCipherTextTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblCipherTextFormat = new System.Windows.Forms.Label();
            this.cboCipherTextStringTransformType = new System.Windows.Forms.ComboBox();
            this.grpPlainText = new System.Windows.Forms.GroupBox();
            this.tplPlainTextTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlainTextFormat = new System.Windows.Forms.Label();
            this.cboPlainTextStringTransformType = new System.Windows.Forms.ComboBox();
            this.tpgEncryptionModeFile = new System.Windows.Forms.TabPage();
            this.grpCipherFile = new System.Windows.Forms.GroupBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtCipherFilePath = new System.Windows.Forms.TextBox();
            this.cmdBrowseCipherFilePath = new System.Windows.Forms.Button();
            this.grpPlainFile = new System.Windows.Forms.GroupBox();
            this.pnlPlainFileTop = new System.Windows.Forms.Panel();
            this.txtPlainFilePath = new System.Windows.Forms.TextBox();
            this.cmdBrowsePlainFilePath = new System.Windows.Forms.Button();
            this.grpEncryptionSettings = new System.Windows.Forms.GroupBox();
            this.tlpEncryptionSettings = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerateIV = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.lblPaddingMode = new System.Windows.Forms.Label();
            this.lblUseHex = new System.Windows.Forms.Label();
            this.chkKeyIsHex = new System.Windows.Forms.CheckBox();
            this.txtEncryptionKey = new System.Windows.Forms.TextBox();
            this.lblEncryptionKey = new System.Windows.Forms.Label();
            this.txtInitializationVector = new System.Windows.Forms.TextBox();
            this.lblInitializationVector = new System.Windows.Forms.Label();
            this.chkIvIsHex = new System.Windows.Forms.CheckBox();
            this.cmdDecrypt = new System.Windows.Forms.Button();
            this.pnlPaddingMode.SuspendLayout();
            this.pnlCipherMode.SuspendLayout();
            this.pnlAlgorithm.SuspendLayout();
            this.tabEncryptionMode.SuspendLayout();
            this.tpgEncryptionModeText.SuspendLayout();
            this.grpCipherText.SuspendLayout();
            this.tplCipherTextTop.SuspendLayout();
            this.grpPlainText.SuspendLayout();
            this.tplPlainTextTop.SuspendLayout();
            this.tpgEncryptionModeFile.SuspendLayout();
            this.grpCipherFile.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.grpPlainFile.SuspendLayout();
            this.pnlPlainFileTop.SuspendLayout();
            this.grpEncryptionSettings.SuspendLayout();
            this.tlpEncryptionSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaddingMode
            // 
            this.pnlPaddingMode.Controls.Add(this.optPaddingModeNone);
            this.pnlPaddingMode.Controls.Add(this.optPaddingModeZeros);
            this.pnlPaddingMode.Controls.Add(this.optPaddingModeISO10126);
            this.pnlPaddingMode.Controls.Add(this.optPaddingModePKCS7);
            this.pnlPaddingMode.Controls.Add(this.optPaddingModeANSIX923);
            this.pnlPaddingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaddingMode.Location = new System.Drawing.Point(613, 34);
            this.pnlPaddingMode.Name = "pnlPaddingMode";
            this.tlpEncryptionSettings.SetRowSpan(this.pnlPaddingMode, 4);
            this.pnlPaddingMode.Size = new System.Drawing.Size(80, 108);
            this.pnlPaddingMode.TabIndex = 12;
            // 
            // optPaddingModeNone
            // 
            this.optPaddingModeNone.Location = new System.Drawing.Point(3, 70);
            this.optPaddingModeNone.Name = "optPaddingModeNone";
            this.optPaddingModeNone.Size = new System.Drawing.Size(73, 17);
            this.optPaddingModeNone.TabIndex = 4;
            this.optPaddingModeNone.Text = "None";
            this.optPaddingModeNone.UseVisualStyleBackColor = true;
            // 
            // optPaddingModeZeros
            // 
            this.optPaddingModeZeros.Location = new System.Drawing.Point(3, 19);
            this.optPaddingModeZeros.Name = "optPaddingModeZeros";
            this.optPaddingModeZeros.Size = new System.Drawing.Size(73, 17);
            this.optPaddingModeZeros.TabIndex = 1;
            this.optPaddingModeZeros.Text = "Zeros";
            this.optPaddingModeZeros.UseVisualStyleBackColor = true;
            // 
            // optPaddingModeISO10126
            // 
            this.optPaddingModeISO10126.Location = new System.Drawing.Point(3, 53);
            this.optPaddingModeISO10126.Name = "optPaddingModeISO10126";
            this.optPaddingModeISO10126.Size = new System.Drawing.Size(73, 17);
            this.optPaddingModeISO10126.TabIndex = 3;
            this.optPaddingModeISO10126.Text = "ISO10126";
            this.optPaddingModeISO10126.UseVisualStyleBackColor = true;
            // 
            // optPaddingModePKCS7
            // 
            this.optPaddingModePKCS7.Checked = true;
            this.optPaddingModePKCS7.Location = new System.Drawing.Point(3, 2);
            this.optPaddingModePKCS7.Name = "optPaddingModePKCS7";
            this.optPaddingModePKCS7.Size = new System.Drawing.Size(73, 17);
            this.optPaddingModePKCS7.TabIndex = 0;
            this.optPaddingModePKCS7.TabStop = true;
            this.optPaddingModePKCS7.Text = "PKCS7";
            this.optPaddingModePKCS7.UseVisualStyleBackColor = true;
            // 
            // optPaddingModeANSIX923
            // 
            this.optPaddingModeANSIX923.Location = new System.Drawing.Point(3, 36);
            this.optPaddingModeANSIX923.Name = "optPaddingModeANSIX923";
            this.optPaddingModeANSIX923.Size = new System.Drawing.Size(76, 17);
            this.optPaddingModeANSIX923.TabIndex = 2;
            this.optPaddingModeANSIX923.Text = "ANSIX923";
            this.optPaddingModeANSIX923.UseVisualStyleBackColor = true;
            // 
            // lblCipherMode
            // 
            this.lblCipherMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCipherMode.AutoSize = true;
            this.lblCipherMode.Location = new System.Drawing.Point(527, 0);
            this.lblCipherMode.Name = "lblCipherMode";
            this.lblCipherMode.Size = new System.Drawing.Size(80, 31);
            this.lblCipherMode.TabIndex = 15;
            this.lblCipherMode.Text = "Cipher Mode";
            this.lblCipherMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnlCipherMode
            // 
            this.pnlCipherMode.Controls.Add(this.optCipherModeOFB);
            this.pnlCipherMode.Controls.Add(this.optCipherModeECB);
            this.pnlCipherMode.Controls.Add(this.optCipherModeCTS);
            this.pnlCipherMode.Controls.Add(this.optCipherModeCBC);
            this.pnlCipherMode.Controls.Add(this.optCipherModeCFB);
            this.pnlCipherMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCipherMode.Location = new System.Drawing.Point(527, 34);
            this.pnlCipherMode.Name = "pnlCipherMode";
            this.tlpEncryptionSettings.SetRowSpan(this.pnlCipherMode, 4);
            this.pnlCipherMode.Size = new System.Drawing.Size(80, 108);
            this.pnlCipherMode.TabIndex = 11;
            // 
            // optCipherModeOFB
            // 
            this.optCipherModeOFB.Location = new System.Drawing.Point(3, 36);
            this.optCipherModeOFB.Name = "optCipherModeOFB";
            this.optCipherModeOFB.Size = new System.Drawing.Size(73, 17);
            this.optCipherModeOFB.TabIndex = 2;
            this.optCipherModeOFB.Text = "OFB";
            this.optCipherModeOFB.UseVisualStyleBackColor = true;
            // 
            // optCipherModeECB
            // 
            this.optCipherModeECB.Location = new System.Drawing.Point(3, 19);
            this.optCipherModeECB.Name = "optCipherModeECB";
            this.optCipherModeECB.Size = new System.Drawing.Size(73, 17);
            this.optCipherModeECB.TabIndex = 1;
            this.optCipherModeECB.Text = "ECB";
            this.optCipherModeECB.UseVisualStyleBackColor = true;
            // 
            // optCipherModeCTS
            // 
            this.optCipherModeCTS.Location = new System.Drawing.Point(3, 70);
            this.optCipherModeCTS.Name = "optCipherModeCTS";
            this.optCipherModeCTS.Size = new System.Drawing.Size(73, 17);
            this.optCipherModeCTS.TabIndex = 4;
            this.optCipherModeCTS.Text = "CTS";
            this.optCipherModeCTS.UseVisualStyleBackColor = true;
            // 
            // optCipherModeCBC
            // 
            this.optCipherModeCBC.Checked = true;
            this.optCipherModeCBC.Location = new System.Drawing.Point(3, 2);
            this.optCipherModeCBC.Name = "optCipherModeCBC";
            this.optCipherModeCBC.Size = new System.Drawing.Size(76, 17);
            this.optCipherModeCBC.TabIndex = 0;
            this.optCipherModeCBC.TabStop = true;
            this.optCipherModeCBC.Text = "CBC";
            this.optCipherModeCBC.UseVisualStyleBackColor = true;
            // 
            // optCipherModeCFB
            // 
            this.optCipherModeCFB.Location = new System.Drawing.Point(3, 53);
            this.optCipherModeCFB.Name = "optCipherModeCFB";
            this.optCipherModeCFB.Size = new System.Drawing.Size(73, 17);
            this.optCipherModeCFB.TabIndex = 3;
            this.optCipherModeCFB.Text = "CFB";
            this.optCipherModeCFB.UseVisualStyleBackColor = true;
            // 
            // pnlAlgorithm
            // 
            this.pnlAlgorithm.Controls.Add(this.optAlgorithmAES);
            this.pnlAlgorithm.Controls.Add(this.optAlgorithmNone);
            this.pnlAlgorithm.Controls.Add(this.optAlgorithmRijndael);
            this.pnlAlgorithm.Controls.Add(this.optAlgorithmDES);
            this.pnlAlgorithm.Controls.Add(this.optAlgorithmRC2);
            this.pnlAlgorithm.Controls.Add(this.optAlgorithmTripleDES);
            this.pnlAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlgorithm.Location = new System.Drawing.Point(441, 34);
            this.pnlAlgorithm.Name = "pnlAlgorithm";
            this.tlpEncryptionSettings.SetRowSpan(this.pnlAlgorithm, 4);
            this.pnlAlgorithm.Size = new System.Drawing.Size(80, 108);
            this.pnlAlgorithm.TabIndex = 10;
            // 
            // optAlgorithmAES
            // 
            this.optAlgorithmAES.Location = new System.Drawing.Point(3, 19);
            this.optAlgorithmAES.Name = "optAlgorithmAES";
            this.optAlgorithmAES.Size = new System.Drawing.Size(73, 17);
            this.optAlgorithmAES.TabIndex = 1;
            this.optAlgorithmAES.Text = "AES";
            this.optAlgorithmAES.UseVisualStyleBackColor = true;
            // 
            // optAlgorithmNone
            // 
            this.optAlgorithmNone.Checked = true;
            this.optAlgorithmNone.Location = new System.Drawing.Point(3, 2);
            this.optAlgorithmNone.Name = "optAlgorithmNone";
            this.optAlgorithmNone.Size = new System.Drawing.Size(73, 17);
            this.optAlgorithmNone.TabIndex = 0;
            this.optAlgorithmNone.TabStop = true;
            this.optAlgorithmNone.Text = "None";
            this.optAlgorithmNone.UseVisualStyleBackColor = true;
            // 
            // optAlgorithmRijndael
            // 
            this.optAlgorithmRijndael.Location = new System.Drawing.Point(3, 53);
            this.optAlgorithmRijndael.Name = "optAlgorithmRijndael";
            this.optAlgorithmRijndael.Size = new System.Drawing.Size(73, 17);
            this.optAlgorithmRijndael.TabIndex = 3;
            this.optAlgorithmRijndael.Text = "Rijndael";
            this.optAlgorithmRijndael.UseVisualStyleBackColor = true;
            // 
            // optAlgorithmDES
            // 
            this.optAlgorithmDES.Location = new System.Drawing.Point(3, 87);
            this.optAlgorithmDES.Name = "optAlgorithmDES";
            this.optAlgorithmDES.Size = new System.Drawing.Size(73, 17);
            this.optAlgorithmDES.TabIndex = 5;
            this.optAlgorithmDES.Text = "DES";
            this.optAlgorithmDES.UseVisualStyleBackColor = true;
            // 
            // optAlgorithmRC2
            // 
            this.optAlgorithmRC2.Location = new System.Drawing.Point(3, 36);
            this.optAlgorithmRC2.Name = "optAlgorithmRC2";
            this.optAlgorithmRC2.Size = new System.Drawing.Size(73, 17);
            this.optAlgorithmRC2.TabIndex = 2;
            this.optAlgorithmRC2.Text = "RC2";
            this.optAlgorithmRC2.UseVisualStyleBackColor = true;
            // 
            // optAlgorithmTripleDES
            // 
            this.optAlgorithmTripleDES.Location = new System.Drawing.Point(3, 70);
            this.optAlgorithmTripleDES.Name = "optAlgorithmTripleDES";
            this.optAlgorithmTripleDES.Size = new System.Drawing.Size(76, 17);
            this.optAlgorithmTripleDES.TabIndex = 4;
            this.optAlgorithmTripleDES.Text = "Triple DES";
            this.optAlgorithmTripleDES.UseVisualStyleBackColor = true;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlainText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlainText.Location = new System.Drawing.Point(3, 42);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(352, 245);
            this.txtPlainText.TabIndex = 0;
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Location = new System.Drawing.Point(441, 0);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(80, 31);
            this.lblAlgorithm.TabIndex = 14;
            this.lblAlgorithm.Text = "Algorithm";
            this.lblAlgorithm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmdEncrypt
            // 
            this.cmdEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEncrypt.Location = new System.Drawing.Point(104, 90);
            this.cmdEncrypt.Name = "cmdEncrypt";
            this.cmdEncrypt.Size = new System.Drawing.Size(125, 25);
            this.cmdEncrypt.TabIndex = 14;
            this.cmdEncrypt.Text = "Encrypt";
            this.cmdEncrypt.UseVisualStyleBackColor = true;
            this.cmdEncrypt.Click += new System.EventHandler(this.EncryptDecrypt_Click);
            // 
            // tabEncryptionMode
            // 
            this.tabEncryptionMode.Controls.Add(this.tpgEncryptionModeText);
            this.tabEncryptionMode.Controls.Add(this.tpgEncryptionModeFile);
            this.tabEncryptionMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEncryptionMode.Location = new System.Drawing.Point(0, 164);
            this.tabEncryptionMode.Name = "tabEncryptionMode";
            this.tabEncryptionMode.SelectedIndex = 0;
            this.tabEncryptionMode.Size = new System.Drawing.Size(730, 322);
            this.tabEncryptionMode.TabIndex = 3;
            // 
            // tpgEncryptionModeText
            // 
            this.tpgEncryptionModeText.Controls.Add(this.grpCipherText);
            this.tpgEncryptionModeText.Controls.Add(this.grpPlainText);
            this.tpgEncryptionModeText.Location = new System.Drawing.Point(4, 22);
            this.tpgEncryptionModeText.Name = "tpgEncryptionModeText";
            this.tpgEncryptionModeText.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEncryptionModeText.Size = new System.Drawing.Size(722, 296);
            this.tpgEncryptionModeText.TabIndex = 0;
            this.tpgEncryptionModeText.Text = "Text";
            this.tpgEncryptionModeText.UseVisualStyleBackColor = true;
            this.tpgEncryptionModeText.Resize += new System.EventHandler(this.tpgEncryptionModeTextFile_Resize);
            // 
            // grpCipherText
            // 
            this.grpCipherText.Controls.Add(this.txtCipherText);
            this.grpCipherText.Controls.Add(this.tplCipherTextTop);
            this.grpCipherText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCipherText.Location = new System.Drawing.Point(361, 3);
            this.grpCipherText.Name = "grpCipherText";
            this.grpCipherText.Size = new System.Drawing.Size(358, 290);
            this.grpCipherText.TabIndex = 1;
            this.grpCipherText.TabStop = false;
            this.grpCipherText.Text = "Cipher Text";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCipherText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipherText.Location = new System.Drawing.Point(3, 42);
            this.txtCipherText.Multiline = true;
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(352, 245);
            this.txtCipherText.TabIndex = 0;
            // 
            // tplCipherTextTop
            // 
            this.tplCipherTextTop.ColumnCount = 2;
            this.tplCipherTextTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.92045F));
            this.tplCipherTextTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.07954F));
            this.tplCipherTextTop.Controls.Add(this.lblCipherTextFormat, 0, 0);
            this.tplCipherTextTop.Controls.Add(this.cboCipherTextStringTransformType, 1, 0);
            this.tplCipherTextTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tplCipherTextTop.Location = new System.Drawing.Point(3, 16);
            this.tplCipherTextTop.Name = "tplCipherTextTop";
            this.tplCipherTextTop.RowCount = 1;
            this.tplCipherTextTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplCipherTextTop.Size = new System.Drawing.Size(352, 26);
            this.tplCipherTextTop.TabIndex = 2;
            // 
            // lblCipherTextFormat
            // 
            this.lblCipherTextFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCipherTextFormat.AutoSize = true;
            this.lblCipherTextFormat.Location = new System.Drawing.Point(3, 0);
            this.lblCipherTextFormat.Name = "lblCipherTextFormat";
            this.lblCipherTextFormat.Size = new System.Drawing.Size(42, 26);
            this.lblCipherTextFormat.TabIndex = 0;
            this.lblCipherTextFormat.Text = "Format";
            this.lblCipherTextFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCipherTextStringTransformType
            // 
            this.cboCipherTextStringTransformType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCipherTextStringTransformType.DisplayMember = "DisplayText";
            this.cboCipherTextStringTransformType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCipherTextStringTransformType.FormattingEnabled = true;
            this.cboCipherTextStringTransformType.Location = new System.Drawing.Point(51, 3);
            this.cboCipherTextStringTransformType.Name = "cboCipherTextStringTransformType";
            this.cboCipherTextStringTransformType.Size = new System.Drawing.Size(298, 21);
            this.cboCipherTextStringTransformType.TabIndex = 1;
            this.cboCipherTextStringTransformType.ValueMember = "Value";
            // 
            // grpPlainText
            // 
            this.grpPlainText.Controls.Add(this.txtPlainText);
            this.grpPlainText.Controls.Add(this.tplPlainTextTop);
            this.grpPlainText.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPlainText.Location = new System.Drawing.Point(3, 3);
            this.grpPlainText.Name = "grpPlainText";
            this.grpPlainText.Size = new System.Drawing.Size(358, 290);
            this.grpPlainText.TabIndex = 0;
            this.grpPlainText.TabStop = false;
            this.grpPlainText.Text = "Plain Text";
            // 
            // tplPlainTextTop
            // 
            this.tplPlainTextTop.ColumnCount = 2;
            this.tplPlainTextTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.92045F));
            this.tplPlainTextTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.07954F));
            this.tplPlainTextTop.Controls.Add(this.lblPlainTextFormat, 0, 0);
            this.tplPlainTextTop.Controls.Add(this.cboPlainTextStringTransformType, 1, 0);
            this.tplPlainTextTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tplPlainTextTop.Location = new System.Drawing.Point(3, 16);
            this.tplPlainTextTop.Name = "tplPlainTextTop";
            this.tplPlainTextTop.RowCount = 1;
            this.tplPlainTextTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplPlainTextTop.Size = new System.Drawing.Size(352, 26);
            this.tplPlainTextTop.TabIndex = 1;
            // 
            // lblPlainTextFormat
            // 
            this.lblPlainTextFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlainTextFormat.AutoSize = true;
            this.lblPlainTextFormat.Location = new System.Drawing.Point(3, 0);
            this.lblPlainTextFormat.Name = "lblPlainTextFormat";
            this.lblPlainTextFormat.Size = new System.Drawing.Size(42, 26);
            this.lblPlainTextFormat.TabIndex = 0;
            this.lblPlainTextFormat.Text = "Format";
            this.lblPlainTextFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPlainTextStringTransformType
            // 
            this.cboPlainTextStringTransformType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPlainTextStringTransformType.DisplayMember = "DisplayText";
            this.cboPlainTextStringTransformType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlainTextStringTransformType.FormattingEnabled = true;
            this.cboPlainTextStringTransformType.Location = new System.Drawing.Point(51, 3);
            this.cboPlainTextStringTransformType.Name = "cboPlainTextStringTransformType";
            this.cboPlainTextStringTransformType.Size = new System.Drawing.Size(298, 21);
            this.cboPlainTextStringTransformType.TabIndex = 1;
            this.cboPlainTextStringTransformType.ValueMember = "Value";
            // 
            // tpgEncryptionModeFile
            // 
            this.tpgEncryptionModeFile.Controls.Add(this.grpCipherFile);
            this.tpgEncryptionModeFile.Controls.Add(this.grpPlainFile);
            this.tpgEncryptionModeFile.Location = new System.Drawing.Point(4, 22);
            this.tpgEncryptionModeFile.Name = "tpgEncryptionModeFile";
            this.tpgEncryptionModeFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEncryptionModeFile.Size = new System.Drawing.Size(722, 296);
            this.tpgEncryptionModeFile.TabIndex = 1;
            this.tpgEncryptionModeFile.Text = "File";
            this.tpgEncryptionModeFile.UseVisualStyleBackColor = true;
            this.tpgEncryptionModeFile.Resize += new System.EventHandler(this.tpgEncryptionModeTextFile_Resize);
            // 
            // grpCipherFile
            // 
            this.grpCipherFile.Controls.Add(this.Panel1);
            this.grpCipherFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCipherFile.Location = new System.Drawing.Point(361, 3);
            this.grpCipherFile.Name = "grpCipherFile";
            this.grpCipherFile.Size = new System.Drawing.Size(358, 290);
            this.grpCipherFile.TabIndex = 9;
            this.grpCipherFile.TabStop = false;
            this.grpCipherFile.Text = "Cipher File";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.txtCipherFilePath);
            this.Panel1.Controls.Add(this.cmdBrowseCipherFilePath);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(3, 16);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(352, 20);
            this.Panel1.TabIndex = 0;
            // 
            // txtCipherFilePath
            // 
            this.txtCipherFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCipherFilePath.Location = new System.Drawing.Point(0, 0);
            this.txtCipherFilePath.Name = "txtCipherFilePath";
            this.txtCipherFilePath.Size = new System.Drawing.Size(328, 20);
            this.txtCipherFilePath.TabIndex = 3;
            // 
            // cmdBrowseCipherFilePath
            // 
            this.cmdBrowseCipherFilePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdBrowseCipherFilePath.Location = new System.Drawing.Point(328, 0);
            this.cmdBrowseCipherFilePath.Name = "cmdBrowseCipherFilePath";
            this.cmdBrowseCipherFilePath.Size = new System.Drawing.Size(24, 20);
            this.cmdBrowseCipherFilePath.TabIndex = 5;
            this.cmdBrowseCipherFilePath.Text = "...";
            this.cmdBrowseCipherFilePath.UseVisualStyleBackColor = true;
            this.cmdBrowseCipherFilePath.Click += new System.EventHandler(this.cmdBrowsePlainCipherFilePath_Click);
            // 
            // grpPlainFile
            // 
            this.grpPlainFile.Controls.Add(this.pnlPlainFileTop);
            this.grpPlainFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPlainFile.Location = new System.Drawing.Point(3, 3);
            this.grpPlainFile.Name = "grpPlainFile";
            this.grpPlainFile.Size = new System.Drawing.Size(358, 290);
            this.grpPlainFile.TabIndex = 8;
            this.grpPlainFile.TabStop = false;
            this.grpPlainFile.Text = "Plain File";
            // 
            // pnlPlainFileTop
            // 
            this.pnlPlainFileTop.Controls.Add(this.txtPlainFilePath);
            this.pnlPlainFileTop.Controls.Add(this.cmdBrowsePlainFilePath);
            this.pnlPlainFileTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlainFileTop.Location = new System.Drawing.Point(3, 16);
            this.pnlPlainFileTop.Name = "pnlPlainFileTop";
            this.pnlPlainFileTop.Size = new System.Drawing.Size(352, 20);
            this.pnlPlainFileTop.TabIndex = 3;
            // 
            // txtPlainFilePath
            // 
            this.txtPlainFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlainFilePath.Location = new System.Drawing.Point(0, 0);
            this.txtPlainFilePath.Name = "txtPlainFilePath";
            this.txtPlainFilePath.Size = new System.Drawing.Size(328, 20);
            this.txtPlainFilePath.TabIndex = 0;
            // 
            // cmdBrowsePlainFilePath
            // 
            this.cmdBrowsePlainFilePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdBrowsePlainFilePath.Location = new System.Drawing.Point(328, 0);
            this.cmdBrowsePlainFilePath.Name = "cmdBrowsePlainFilePath";
            this.cmdBrowsePlainFilePath.Size = new System.Drawing.Size(24, 20);
            this.cmdBrowsePlainFilePath.TabIndex = 2;
            this.cmdBrowsePlainFilePath.Text = "...";
            this.cmdBrowsePlainFilePath.UseVisualStyleBackColor = true;
            this.cmdBrowsePlainFilePath.Click += new System.EventHandler(this.cmdBrowsePlainCipherFilePath_Click);
            // 
            // grpEncryptionSettings
            // 
            this.grpEncryptionSettings.Controls.Add(this.tlpEncryptionSettings);
            this.grpEncryptionSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEncryptionSettings.Location = new System.Drawing.Point(0, 0);
            this.grpEncryptionSettings.Name = "grpEncryptionSettings";
            this.grpEncryptionSettings.Size = new System.Drawing.Size(730, 164);
            this.grpEncryptionSettings.TabIndex = 2;
            this.grpEncryptionSettings.TabStop = false;
            this.grpEncryptionSettings.Text = "Encryption Settings";
            // 
            // tlpEncryptionSettings
            // 
            this.tlpEncryptionSettings.ColumnCount = 9;
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEncryptionSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncryptionSettings.Controls.Add(this.btnGenerateIV, 2, 0);
            this.tlpEncryptionSettings.Controls.Add(this.btnGenerateKey, 1, 0);
            this.tlpEncryptionSettings.Controls.Add(this.lblPaddingMode, 7, 0);
            this.tlpEncryptionSettings.Controls.Add(this.pnlPaddingMode, 7, 1);
            this.tlpEncryptionSettings.Controls.Add(this.lblCipherMode, 6, 0);
            this.tlpEncryptionSettings.Controls.Add(this.pnlCipherMode, 6, 1);
            this.tlpEncryptionSettings.Controls.Add(this.pnlAlgorithm, 5, 1);
            this.tlpEncryptionSettings.Controls.Add(this.lblAlgorithm, 5, 0);
            this.tlpEncryptionSettings.Controls.Add(this.lblUseHex, 3, 0);
            this.tlpEncryptionSettings.Controls.Add(this.chkKeyIsHex, 3, 1);
            this.tlpEncryptionSettings.Controls.Add(this.txtEncryptionKey, 1, 1);
            this.tlpEncryptionSettings.Controls.Add(this.lblEncryptionKey, 0, 1);
            this.tlpEncryptionSettings.Controls.Add(this.txtInitializationVector, 1, 2);
            this.tlpEncryptionSettings.Controls.Add(this.lblInitializationVector, 0, 2);
            this.tlpEncryptionSettings.Controls.Add(this.chkIvIsHex, 3, 2);
            this.tlpEncryptionSettings.Controls.Add(this.cmdDecrypt, 2, 3);
            this.tlpEncryptionSettings.Controls.Add(this.cmdEncrypt, 1, 3);
            this.tlpEncryptionSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEncryptionSettings.Location = new System.Drawing.Point(3, 16);
            this.tlpEncryptionSettings.Name = "tlpEncryptionSettings";
            this.tlpEncryptionSettings.RowCount = 5;
            this.tlpEncryptionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEncryptionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEncryptionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEncryptionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEncryptionSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEncryptionSettings.Size = new System.Drawing.Size(724, 145);
            this.tlpEncryptionSettings.TabIndex = 0;
            // 
            // btnGenerateIV
            // 
            this.btnGenerateIV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateIV.Location = new System.Drawing.Point(235, 3);
            this.btnGenerateIV.Name = "btnGenerateIV";
            this.btnGenerateIV.Size = new System.Drawing.Size(125, 25);
            this.btnGenerateIV.TabIndex = 1;
            this.btnGenerateIV.Text = "Generate IV";
            this.btnGenerateIV.UseVisualStyleBackColor = true;
            this.btnGenerateIV.Click += new System.EventHandler(this.btnGenerateIV_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerateKey.Location = new System.Drawing.Point(104, 3);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(125, 25);
            this.btnGenerateKey.TabIndex = 0;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // lblPaddingMode
            // 
            this.lblPaddingMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaddingMode.AutoSize = true;
            this.lblPaddingMode.Location = new System.Drawing.Point(613, 0);
            this.lblPaddingMode.Name = "lblPaddingMode";
            this.lblPaddingMode.Size = new System.Drawing.Size(80, 31);
            this.lblPaddingMode.TabIndex = 16;
            this.lblPaddingMode.Text = "Padding Mode";
            this.lblPaddingMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblUseHex
            // 
            this.lblUseHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUseHex.Location = new System.Drawing.Point(366, 0);
            this.lblUseHex.Name = "lblUseHex";
            this.lblUseHex.Size = new System.Drawing.Size(49, 31);
            this.lblUseHex.TabIndex = 12;
            this.lblUseHex.Text = "Use Hex Literals";
            this.lblUseHex.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // chkKeyIsHex
            // 
            this.chkKeyIsHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkKeyIsHex.AutoSize = true;
            this.chkKeyIsHex.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkKeyIsHex.Checked = true;
            this.chkKeyIsHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeyIsHex.Location = new System.Drawing.Point(366, 34);
            this.chkKeyIsHex.Name = "chkKeyIsHex";
            this.chkKeyIsHex.Size = new System.Drawing.Size(49, 22);
            this.chkKeyIsHex.TabIndex = 3;
            this.chkKeyIsHex.UseVisualStyleBackColor = true;
            // 
            // txtEncryptionKey
            // 
            this.tlpEncryptionSettings.SetColumnSpan(this.txtEncryptionKey, 2);
            this.txtEncryptionKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEncryptionKey.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptionKey.Location = new System.Drawing.Point(104, 34);
            this.txtEncryptionKey.Name = "txtEncryptionKey";
            this.txtEncryptionKey.Size = new System.Drawing.Size(256, 22);
            this.txtEncryptionKey.TabIndex = 2;
            // 
            // lblEncryptionKey
            // 
            this.lblEncryptionKey.AutoSize = true;
            this.lblEncryptionKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncryptionKey.Location = new System.Drawing.Point(3, 31);
            this.lblEncryptionKey.Name = "lblEncryptionKey";
            this.lblEncryptionKey.Size = new System.Drawing.Size(95, 28);
            this.lblEncryptionKey.TabIndex = 1;
            this.lblEncryptionKey.Text = "Encryption Key";
            this.lblEncryptionKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInitializationVector
            // 
            this.txtInitializationVector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEncryptionSettings.SetColumnSpan(this.txtInitializationVector, 2);
            this.txtInitializationVector.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitializationVector.Location = new System.Drawing.Point(104, 62);
            this.txtInitializationVector.Name = "txtInitializationVector";
            this.txtInitializationVector.Size = new System.Drawing.Size(256, 22);
            this.txtInitializationVector.TabIndex = 8;
            // 
            // lblInitializationVector
            // 
            this.lblInitializationVector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInitializationVector.AutoSize = true;
            this.lblInitializationVector.Location = new System.Drawing.Point(3, 59);
            this.lblInitializationVector.Name = "lblInitializationVector";
            this.lblInitializationVector.Size = new System.Drawing.Size(95, 28);
            this.lblInitializationVector.TabIndex = 7;
            this.lblInitializationVector.Text = "Initialization Vector";
            this.lblInitializationVector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkIvIsHex
            // 
            this.chkIvIsHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIvIsHex.AutoSize = true;
            this.chkIvIsHex.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIvIsHex.Checked = true;
            this.chkIvIsHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIvIsHex.Location = new System.Drawing.Point(366, 62);
            this.chkIvIsHex.Name = "chkIvIsHex";
            this.chkIvIsHex.Size = new System.Drawing.Size(49, 22);
            this.chkIvIsHex.TabIndex = 9;
            this.chkIvIsHex.UseVisualStyleBackColor = true;
            // 
            // cmdDecrypt
            // 
            this.cmdDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDecrypt.Location = new System.Drawing.Point(235, 90);
            this.cmdDecrypt.Name = "cmdDecrypt";
            this.cmdDecrypt.Size = new System.Drawing.Size(125, 25);
            this.cmdDecrypt.TabIndex = 15;
            this.cmdDecrypt.Text = "Decrypt";
            this.cmdDecrypt.UseVisualStyleBackColor = true;
            this.cmdDecrypt.Click += new System.EventHandler(this.EncryptDecrypt_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 486);
            this.Controls.Add(this.tabEncryptionMode);
            this.Controls.Add(this.grpEncryptionSettings);
            this.Name = "frmMain";
            this.Text = "Cryptography Utility";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.pnlPaddingMode.ResumeLayout(false);
            this.pnlCipherMode.ResumeLayout(false);
            this.pnlAlgorithm.ResumeLayout(false);
            this.tabEncryptionMode.ResumeLayout(false);
            this.tpgEncryptionModeText.ResumeLayout(false);
            this.grpCipherText.ResumeLayout(false);
            this.grpCipherText.PerformLayout();
            this.tplCipherTextTop.ResumeLayout(false);
            this.tplCipherTextTop.PerformLayout();
            this.grpPlainText.ResumeLayout(false);
            this.grpPlainText.PerformLayout();
            this.tplPlainTextTop.ResumeLayout(false);
            this.tplPlainTextTop.PerformLayout();
            this.tpgEncryptionModeFile.ResumeLayout(false);
            this.grpCipherFile.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.grpPlainFile.ResumeLayout(false);
            this.pnlPlainFileTop.ResumeLayout(false);
            this.pnlPlainFileTop.PerformLayout();
            this.grpEncryptionSettings.ResumeLayout(false);
            this.tlpEncryptionSettings.ResumeLayout(false);
            this.tlpEncryptionSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlPaddingMode;
        internal System.Windows.Forms.RadioButton optPaddingModeNone;
        internal System.Windows.Forms.RadioButton optPaddingModeZeros;
        internal System.Windows.Forms.RadioButton optPaddingModeISO10126;
        internal System.Windows.Forms.RadioButton optPaddingModePKCS7;
        internal System.Windows.Forms.RadioButton optPaddingModeANSIX923;
        internal System.Windows.Forms.TableLayoutPanel tlpEncryptionSettings;
        internal System.Windows.Forms.Button btnGenerateIV;
        internal System.Windows.Forms.Button btnGenerateKey;
        internal System.Windows.Forms.Button cmdDecrypt;
        internal System.Windows.Forms.Label lblPaddingMode;
        internal System.Windows.Forms.Label lblCipherMode;
        internal System.Windows.Forms.Panel pnlCipherMode;
        internal System.Windows.Forms.RadioButton optCipherModeOFB;
        internal System.Windows.Forms.RadioButton optCipherModeECB;
        internal System.Windows.Forms.RadioButton optCipherModeCTS;
        internal System.Windows.Forms.RadioButton optCipherModeCBC;
        internal System.Windows.Forms.RadioButton optCipherModeCFB;
        internal System.Windows.Forms.Panel pnlAlgorithm;
        internal System.Windows.Forms.RadioButton optAlgorithmNone;
        internal System.Windows.Forms.RadioButton optAlgorithmRijndael;
        internal System.Windows.Forms.RadioButton optAlgorithmDES;
        internal System.Windows.Forms.RadioButton optAlgorithmRC2;
        internal System.Windows.Forms.RadioButton optAlgorithmTripleDES;
        internal System.Windows.Forms.Label lblAlgorithm;
        internal System.Windows.Forms.Label lblUseHex;
        internal System.Windows.Forms.TextBox txtInitializationVector;
        internal System.Windows.Forms.CheckBox chkIvIsHex;
        internal System.Windows.Forms.CheckBox chkKeyIsHex;
        internal System.Windows.Forms.TextBox txtEncryptionKey;
        internal System.Windows.Forms.Label lblEncryptionKey;
        internal System.Windows.Forms.Label lblInitializationVector;
        internal System.Windows.Forms.Button cmdEncrypt;
        internal System.Windows.Forms.TextBox txtPlainText;
        internal System.Windows.Forms.TabControl tabEncryptionMode;
        internal System.Windows.Forms.TabPage tpgEncryptionModeText;
        internal System.Windows.Forms.GroupBox grpCipherText;
        internal System.Windows.Forms.TextBox txtCipherText;
        internal System.Windows.Forms.GroupBox grpPlainText;
        internal System.Windows.Forms.TabPage tpgEncryptionModeFile;
        internal System.Windows.Forms.GroupBox grpEncryptionSettings;
        internal System.Windows.Forms.GroupBox grpCipherFile;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox txtCipherFilePath;
        internal System.Windows.Forms.Button cmdBrowseCipherFilePath;
        internal System.Windows.Forms.GroupBox grpPlainFile;
        internal System.Windows.Forms.Panel pnlPlainFileTop;
        internal System.Windows.Forms.TextBox txtPlainFilePath;
        internal System.Windows.Forms.Button cmdBrowsePlainFilePath;
        internal System.Windows.Forms.RadioButton optAlgorithmAES;
        private System.Windows.Forms.TableLayoutPanel tplPlainTextTop;
        private System.Windows.Forms.Label lblPlainTextFormat;
        private System.Windows.Forms.ComboBox cboPlainTextStringTransformType;
        private System.Windows.Forms.TableLayoutPanel tplCipherTextTop;
        private System.Windows.Forms.Label lblCipherTextFormat;
        private System.Windows.Forms.ComboBox cboCipherTextStringTransformType;
    }
}

