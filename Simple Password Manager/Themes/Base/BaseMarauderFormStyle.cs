using System.Drawing;

namespace SimplePM.Themes
{
    public abstract class BaseMarauderFormStyle
    {
        public abstract Color BackColor { get; }
        public abstract Color BorderColor { get; }
        public abstract int ControlBoxButtonsWidth { get; }
        public abstract Color HeaderColor { get; }
        public abstract int HeaderHeight { get; }
        public abstract Color HeaderTextColor { get; }
        public abstract Font HeaderTextFont { get; }

    }
}
