using System.Drawing;

namespace SimplePM.Themes
{
    public abstract class BaseCustomTextBoxStyle
    {
        public abstract Color BackColor { get; }
        public abstract Color BorderColor { get; }
        public abstract Color BorderFocusColor { get; }
        public abstract Font Font { get; }
        public abstract Color ForeColor { get; }
    }
}
