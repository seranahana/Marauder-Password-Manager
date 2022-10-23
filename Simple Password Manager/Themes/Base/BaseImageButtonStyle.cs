using System.Drawing;
using System.Windows.Forms;

namespace SimplePM.Themes
{
    public abstract class BaseImageButtonStyle
    {
        public abstract Color BackColor { get; }
        public abstract int BorderSize { get; }
        public abstract FlatStyle FlatStyle { get; }
        public abstract Color MouseDownBackColor { get; }
        public abstract Color MouseOverBackColor { get; }
    }
}
