using System.Drawing;

namespace SimplePM.Themes
{
    public abstract class BaseLabelStyle
    {
        public abstract Color BackColor { get; set; }
        public abstract Color ForeColor { get; set; }
        public abstract Font Font { get; set; }
    }
}
