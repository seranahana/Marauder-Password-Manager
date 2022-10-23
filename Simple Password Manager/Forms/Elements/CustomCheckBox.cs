using SimplePM.Themes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePM.Forms.Elements
{
    [DefaultEvent("CheckedChanged")]
    public partial class CustomCheckBox : UserControl
    {
        private Color backColor = Color.Black;
        private Color borderColor = Color.White;
        private Color iconColor = Color.White;
        private Size size = new Size(30, 30);
        private bool isChecked = false;
        private int borderSize = 1;
        private Theme currentTheme = new Cattleya();

        #region --Свойства--
        [Description("Element background color")]
        public new Color BackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                backColor = value;
                base.BackColor = value;
                Invalidate();
            }
        }

        [Description("Border color")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Description("Icon color")]
        public Color IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
                Invalidate();
            }
        }


        [Description("Border width")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                Padding = new Padding(borderSize);

            }
        }

        public new Size Size
        {
            get
            {
                return size;
            }
            set
            {
                Size newSize = value;
                if (newSize.Width != size.Width)
                    newSize.Height = newSize.Width;
                if (newSize.Height != size.Height)
                    newSize.Width = newSize.Height;
                size = newSize;
                base.Size = newSize;
            }
        }

        public bool Checked
        {
            get 
            { 
                return isChecked;
            }
            set 
            { 
                isChecked = value;
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

        #endregion

        public event EventHandler CheckedChanged; // Default event


        public CustomCheckBox()
        {
            InitializeComponent();
            currentTheme = SettingsProcessor.GetCurrentTheme();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = currentTheme.CustomCheckBoxStyle.BackColor;
            BorderColor = currentTheme.CustomCheckBoxStyle.BorderColor;
            IconColor = currentTheme.CustomCheckBoxStyle.IconColor;
        }

        #region --Event Handlers--

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (isChecked)
                isChecked = false;
            else
                isChecked = true;
            Invalidate();
            OnCheckedChanged(EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int iconWidth = Width - borderSize - 10;
            int iconHeight = Height - borderSize - 10;
            int halfIconHeight = iconHeight / 2;
            Rectangle rectIcon = new Rectangle(borderSize + 4, borderSize + 4, iconWidth, iconHeight);
            Rectangle rectBorder = new Rectangle(0, 0, Width - 1, Height - 1);
            Graphics graph = e.Graphics;

            using GraphicsPath path = new();
            using Pen borderPen = new(borderColor, borderSize)
            {
                Alignment = PenAlignment.Inset
            };
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            if (isChecked)
            {
                using Pen iconPen = new(iconColor, 2);
                path.AddLine(rectIcon.X, rectIcon.Y + (iconHeight / 2) - (halfIconHeight / 3), rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Top);
                graph.DrawPath(iconPen, path);
            }
            else
            {
                using Pen iconPen = new(backColor, 2);
                path.AddLine(rectIcon.X, rectIcon.Y + (iconHeight / 2) - (halfIconHeight / 3), rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Top);
                graph.DrawPath(iconPen, path);
            }
            graph.DrawRectangle(borderPen, rectBorder);
        }

        protected virtual void OnCheckedChanged(EventArgs e)
        {
            EventHandler handler = CheckedChanged;
            if (handler is not null)
            {
                handler(this, e);
            }
        }

        #endregion
    }
}
