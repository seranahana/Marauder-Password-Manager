using SimplePM.Themes;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimplePM.Forms.Elements
{
    public partial class ThemedLabel : Label
    {
        private Theme currentTheme = new Cattleya();
        private LabelType type;

        [Description("Label type")]
        public LabelType Type
        {
            get 
            { 
                return type;
            }
            set 
            { 
                type = value;
                ApplyTheme();
            }
        }

        public Theme CurrentTheme
        {
            set
            {
                currentTheme = value;
                ApplyTheme();
            }
        }

        public ThemedLabel()
        {
            InitializeComponent();
            currentTheme = SettingsProcessor.GetCurrentTheme();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            switch (type)
            {
                case LabelType.Standart:
                    base.BackColor = currentTheme.StandartLabelStyle.BackColor;
                    base.ForeColor = currentTheme.StandartLabelStyle.ForeColor;
                    base.Font = currentTheme.StandartLabelStyle.Font;
                    break;
                case LabelType.Large:
                    base.BackColor = currentTheme.LargeLabelStyle.BackColor;
                    base.ForeColor = currentTheme.LargeLabelStyle.ForeColor;
                    base.Font = currentTheme.LargeLabelStyle.Font;
                    break;
                case LabelType.Small:
                    base.BackColor = currentTheme.SmallLabelStyle.BackColor;
                    base.ForeColor = currentTheme.SmallLabelStyle.ForeColor;
                    base.Font = currentTheme.SmallLabelStyle.Font;
                    break;
                case LabelType.Header:
                    base.BackColor = currentTheme.HeaderLabelStyle.BackColor;
                    base.ForeColor = currentTheme.HeaderLabelStyle.ForeColor;
                    base.Font = currentTheme.HeaderLabelStyle.Font;
                    break;
            }
        }
    }
}