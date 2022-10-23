using System.Drawing;

namespace SimplePM.Themes
{
    public abstract class BaseCustomComboBoxStyle
    {
        public abstract Color BackColor { get; }
        public abstract Color BorderColor { get; }
        public abstract Color ForeColor { get; }
        public abstract Color IconColor { get; }
        public abstract Color ListBackColor { get; }
        public abstract Color ListForeColor { get; }
        public abstract Font Font { get; }
    }
}
