namespace SimplePM.Themes
{
    public abstract class Theme
    {
        public abstract string Name { get; }
        public abstract BaseCustomButtonStyle CustomButtonStyle { get; }
        public abstract BaseImageButtonStyle ImageButtonStyle { get; }
        public abstract BaseCustomTextBoxStyle CustomTextBoxStyle { get; }
        public abstract BaseMarauderFormStyle MarauderFormStyle { get; }
        public abstract BaseLabelStyle StandartLabelStyle { get; }
        public abstract BaseLabelStyle SmallLabelStyle { get; }
        public abstract BaseLabelStyle LargeLabelStyle { get; }
        public abstract BaseLabelStyle HeaderLabelStyle { get; }
        public abstract BaseCustomCheckBoxStyle CustomCheckBoxStyle { get; }
        public abstract BaseCustomComboBoxStyle CustomComboBoxStyle { get; }
        public abstract BaseEntriesButtonStyle EntriesButtonStyle { get; }
        public abstract BasePanelStyle PanelStyle { get; }
    }
}
