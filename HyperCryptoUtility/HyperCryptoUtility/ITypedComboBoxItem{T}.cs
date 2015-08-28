namespace HyperCryptoUtility
{
    public interface ITypedComboBoxItem<T>
    {
        string DisplayText { get; set; }
        T Value { get; set; }
    }
}
