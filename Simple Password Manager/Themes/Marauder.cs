using System.Drawing;
using System.Windows.Forms;

namespace SimplePM.Themes
{
    public sealed class Marauder : Theme
    {
        private static readonly Color mainThemeColor = Color.White;
        private static readonly Color mainBackColor = Color.Black;
        private static readonly Color mainTextColor = Color.White;
        private const string fontFamilyName = "Verdana";

        public override string Name { get; } = "Marauder";
        public override BaseCustomButtonStyle CustomButtonStyle { get; } = new ThemeCustomButtonStyle();
        public override BaseImageButtonStyle ImageButtonStyle { get; } = new ThemeImageButtonStyle();
        public override BaseCustomTextBoxStyle CustomTextBoxStyle { get; } = new ThemeCustomTextBoxStyle();
        public override BaseMarauderFormStyle MarauderFormStyle { get; } = new ThemeMarauderFormStyle();
        public override BaseLabelStyle StandartLabelStyle { get; } = new ThemeStandartLabelStyle();
        public override BaseLabelStyle SmallLabelStyle { get; } = new ThemeSmallLabelStyle();
        public override BaseLabelStyle LargeLabelStyle { get; } = new ThemeLargeLabelStyle();
        public override BaseLabelStyle HeaderLabelStyle { get; } = new ThemeHeaderLabelStyle();
        public override BaseCustomCheckBoxStyle CustomCheckBoxStyle { get; } = new ThemeCustomCheckBoxStyle();
        public override BaseCustomComboBoxStyle CustomComboBoxStyle { get; } = new ThemeCustomComboBoxStyle();
        public override BaseEntriesButtonStyle EntriesButtonStyle { get; } = new ThemeEntriesButtonStyle();
        public override BasePanelStyle PanelStyle { get; } = new ThemePanelStyle();

        private sealed class ThemeImageButtonStyle : BaseImageButtonStyle
        {
            public override Color BackColor { get; } = Color.Transparent;
            public override int BorderSize { get; } = 0;
            public override FlatStyle FlatStyle { get; } = FlatStyle.Flat;
            public override Color MouseDownBackColor { get; } = Color.FromArgb(200, mainBackColor);
            public override Color MouseOverBackColor { get; } = mainBackColor;
        }

        private sealed class ThemeCustomButtonStyle : BaseCustomButtonStyle
        {
            public override Color BackColor { get; } = mainBackColor;
            public override Font Font { get; } = new(fontFamilyName, 13F, FontStyle.Regular, GraphicsUnit.Point);
            public override Color ForeColor { get; } = mainTextColor;
            public override Color EnterColor { get; } = mainThemeColor;
            public override Color PressColor { get; } = Color.FromArgb(200, mainThemeColor);
        }

        private sealed class ThemeCustomTextBoxStyle : BaseCustomTextBoxStyle
        {
            public override Color BackColor { get; } = mainBackColor;
            public override Color BorderColor { get; } = mainThemeColor;
            public override Color BorderFocusColor { get; } = Color.LightGray;
            public override Font Font { get; } = new Font(fontFamilyName, 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            public override Color ForeColor { get; } = mainTextColor;
        }

        private sealed class ThemeMarauderFormStyle : BaseMarauderFormStyle
        {
            private const string fontFamilyName = "Segoe UI";

            public override Color BackColor { get; } = mainBackColor;
            public override Color BorderColor { get; } = mainThemeColor;
            public override int ControlBoxButtonsWidth { get; } = 24;
            public override Color HeaderColor { get; } = mainBackColor;
            public override int HeaderHeight { get; } = 20;
            public override Color HeaderTextColor { get; } = mainTextColor;
            public override Font HeaderTextFont { get; } = new Font(fontFamilyName, 9F, FontStyle.Bold, GraphicsUnit.Point);
        }

        private sealed class ThemeStandartLabelStyle : BaseLabelStyle
        {
            public override Color BackColor { get; set; } = Color.Transparent;
            public override Color ForeColor { get; set; } = mainTextColor;
            public override Font Font { get; set; } = new Font(fontFamilyName, 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        }
        private sealed class ThemeSmallLabelStyle : BaseLabelStyle
        {
            public override Color BackColor { get; set; } = Color.Transparent;
            public override Color ForeColor { get; set; } = Color.Red;
            public override Font Font { get; set; } = new Font(fontFamilyName, 7F, FontStyle.Regular, GraphicsUnit.Point);
        }
        private sealed class ThemeLargeLabelStyle : BaseLabelStyle
        {
            public override Color BackColor { get; set; } = Color.Transparent;
            public override Color ForeColor { get; set; } = mainTextColor;
            public override Font Font { get; set; } = new Font(fontFamilyName, 16F, FontStyle.Regular, GraphicsUnit.Point);
        }
        private sealed class ThemeHeaderLabelStyle : BaseLabelStyle
        {
            public override Color BackColor { get; set; } = Color.Transparent;
            public override Color ForeColor { get; set; } = mainTextColor;
            public override Font Font { get; set; } = new Font(fontFamilyName, 12F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private sealed class ThemeCustomCheckBoxStyle : BaseCustomCheckBoxStyle
        {
            public override Color BackColor { get; } = mainBackColor;
            public override Color BorderColor { get; } = mainThemeColor;
            public override Color IconColor { get; } = mainThemeColor;
        }

        private sealed class ThemeCustomComboBoxStyle : BaseCustomComboBoxStyle
        {
            public override Color BackColor { get; } = mainBackColor;
            public override Color BorderColor { get; } = mainThemeColor;
            public override Color ForeColor { get; } = mainTextColor;
            public override Color IconColor { get; } = mainThemeColor;
            public override Color ListBackColor { get; } = mainBackColor;
            public override Color ListForeColor { get; } = mainTextColor;
            public override Font Font { get; } = new Font(fontFamilyName, 10.5F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private sealed class ThemeEntriesButtonStyle : BaseEntriesButtonStyle
        {
            public override Color BaseColor { get; } = mainBackColor;
            public override Color EnterColor { get; } = Color.FromArgb(70, 90, 90, 90);
            public override Color ForeColor { get; } = Color.FromArgb(210, mainTextColor);
            public override Font NameFont { get; } = new Font(fontFamilyName, 11F, FontStyle.Regular, GraphicsUnit.Point);
            public override Font UrlFont { get; } = new Font(fontFamilyName, 8F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private sealed class ThemePanelStyle : BasePanelStyle
        {
            public override Color PrimaryBackColor { get; } = mainBackColor;
            public override Color SecondaryBackColor { get; } = mainBackColor;
            public override Color BorderColor { get; } = mainThemeColor;
        }
    }
}
