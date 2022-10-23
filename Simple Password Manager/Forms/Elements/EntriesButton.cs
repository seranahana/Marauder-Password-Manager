using SimplePM.Themes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePM.Forms.Elements
{
    public class EntriesButton : Control
    {
        private string nameText;
        private string urlText;
        private Theme currentTheme = new Cattleya();
        private StringFormat nameStringFormat = new();
        private StringFormat urlStringFormat = new();

        #region --Properties--

        public string NameText
        {
            get { return nameText;}
            set { nameText = value; }
        }

        public string UrlText
        {
            get { return urlText; }
            set { urlText = value; }
        }

        public StringAlignment NameStringAlignment
        {
            get { return nameStringFormat.Alignment; }
            set 
            { 
                nameStringFormat.Alignment = value;
            }
        }

        public StringAlignment NameStringLineAlignment
        {
            get { return nameStringFormat.LineAlignment; }
            set 
            { 
                nameStringFormat.LineAlignment = value;
            }
        }

        public StringAlignment UrlStringAlignment
        {
            get { return urlStringFormat.Alignment; }
            set 
            { 
                urlStringFormat.Alignment = value;
            }
        }

        public StringAlignment UrlStringLineAlignment
        {
            get { return urlStringFormat.LineAlignment; }
            set
            {
                urlStringFormat.LineAlignment = value;
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


        internal bool MouseEntered = false;
        internal bool MousePressed = false;

        #endregion

        #region --Fields--

        private Font nameFont;
        private Font urlFont;
        private Color baseColor;
        private Color enterColor;

        #endregion

        public EntriesButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            currentTheme = SettingsProcessor.GetCurrentTheme();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            baseColor = currentTheme.EntriesButtonStyle.BaseColor;
            BackColor = currentTheme.EntriesButtonStyle.BaseColor;
            enterColor = currentTheme.EntriesButtonStyle.EnterColor;
            ForeColor = currentTheme.EntriesButtonStyle.ForeColor;
            nameFont = currentTheme.EntriesButtonStyle.NameFont;
            urlFont = currentTheme.EntriesButtonStyle.UrlFont;
            Invalidate();
        }

        #region --Event Handlers--

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rectan = new(0, 0, Width - 1, Height - 1);
            Rectangle textRectan = new(5, 5, Width - 1, Height - 11);
            graph.DrawRectangle(new Pen(BackColor), rectan);
            graph.FillRectangle(new SolidBrush(BackColor), rectan);
            graph.DrawString(nameText, nameFont, new SolidBrush(ForeColor), textRectan, nameStringFormat);
            graph.DrawString(urlText, urlFont, new SolidBrush(ForeColor), textRectan, urlStringFormat);
            if (MouseEntered)
            {
                // reserved for future features
            }
            if (MousePressed)
            {
                // reserved for future features
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            BackColor = enterColor;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            BackColor = baseColor;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
            BackColor = baseColor;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
            BackColor = enterColor;
            Invalidate();
        }

        #endregion
    }
}
