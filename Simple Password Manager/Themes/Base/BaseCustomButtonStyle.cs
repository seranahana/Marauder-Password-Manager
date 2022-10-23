using System.Drawing;

namespace SimplePM.Themes
{
    public abstract class BaseCustomButtonStyle
    {
        public abstract Color BackColor { get; }
        public abstract Font Font { get; }
        public abstract Color ForeColor { get; }
        public abstract Color EnterColor { get; }
        public abstract Color PressColor { get;  }
    }
}
