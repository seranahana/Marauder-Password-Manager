using System.Drawing;

namespace SimplePM.Themes
{
    public abstract class BasePanelStyle
    {
        public abstract Color PrimaryBackColor { get; }
        public abstract Color SecondaryBackColor { get; }
        public abstract Color BorderColor { get; }
    }
}
