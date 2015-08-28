using Hyper.Extensibility.IO;

namespace HyperCryptoUtility
{
    public class StringTransformComboBoxItem : ITypedComboBoxItem<IStringTransform>
    {
        public string DisplayText { get; set; }
        public IStringTransform Value { get; set; }

        public StringTransformComboBoxItem(string displayText, IStringTransform value)
        {
            this.DisplayText = displayText;
            this.Value = value;
        }
    }
}
