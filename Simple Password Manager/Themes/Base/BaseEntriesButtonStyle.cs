using System.Drawing;

namespace SimplePM.Themes
{
    public abstract class BaseEntriesButtonStyle
    {
        public abstract Color BaseColor { get; }
        public abstract Color EnterColor { get; }
        public abstract Color ForeColor { get; }
        public abstract Font NameFont { get; }
        public abstract Font UrlFont { get; }
    }
}
