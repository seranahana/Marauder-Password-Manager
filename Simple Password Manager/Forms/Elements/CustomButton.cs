using SimplePM.Themes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePM.Forms.Elements
{
    public class CustomButton : Control
    {
        private StringFormat stringFormat = new StringFormat();
        private Theme currentTheme = new Cattleya();

        #region --Properties--

        public StringAlignment Alignment 
        {
            get => stringFormat.Alignment;
            set { stringFormat.Alignment = value; }
        }
        public StringAlignment LineAlignment
        {
            get => stringFormat.LineAlignment;
            set { stringFormat.LineAlignment = value; }
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

        private Color enterColor;
        private Color pressColor;
        private SizeF textSize;

        #endregion

        public CustomButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(100, 20);
            currentTheme = SettingsProcessor.GetCurrentTheme();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            Font = currentTheme.CustomButtonStyle.Font;
            BackColor = currentTheme.CustomButtonStyle.BackColor;
            ForeColor = currentTheme.CustomButtonStyle.ForeColor;
            enterColor = currentTheme.CustomButtonStyle.EnterColor;
            pressColor = currentTheme.CustomButtonStyle.PressColor;
            Invalidate();
        }

        #region --Event Handlers--

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            textSize = graph.MeasureString(Text, Font);
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.Clear(Parent.BackColor);
            Rectangle rectan = new(0, 0, Width - 1, Height - 1);
            graph.DrawRectangle(new Pen(BackColor), rectan);
            graph.FillRectangle(new SolidBrush(BackColor), rectan);
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rectan, stringFormat);
            if (MouseEntered)
            {
                Color fillColor = Color.FromArgb(200, enterColor);
                switch (stringFormat.Alignment)
                {
                    case (StringAlignment)0:
                        graph.DrawString(Text, Font, new SolidBrush(Color.White), rectan, stringFormat);
                        Rectangle rectang0 = new(1, Height - 3, (int)textSize.Width - 2, 2);
                        graph.DrawRectangle(new Pen(enterColor), rectang0);
                        graph.FillRectangle(new SolidBrush(fillColor), rectang0);
                        break;
                    case (StringAlignment)1:
                        graph.DrawString(Text, Font, new SolidBrush(Color.White), rectan, stringFormat);
                        Rectangle rectang1 = new((Width - (int)textSize.Width) / 2, Height - 3, (int)textSize.Width, 2);
                        graph.DrawRectangle(new Pen(enterColor), rectang1);
                        graph.FillRectangle(new SolidBrush(fillColor), rectang1);
                        break;
                    case (StringAlignment)2:
                        break;
                }
            }
            if (MousePressed)
            {
                Color fillColor = Color.FromArgb(250, pressColor);
                switch (stringFormat.Alignment)
                {
                    case (StringAlignment)0:
                        graph.DrawString(Text, Font, new SolidBrush(Color.FromArgb(150, Color.Black)), rectan, stringFormat);
                        Rectangle rectang0 = new(1, Height - 3, (int)textSize.Width - 2, 2);
                        graph.DrawRectangle(new Pen(pressColor), rectang0);
                        graph.FillRectangle(new SolidBrush(fillColor), rectang0);
                        break;
                    case (StringAlignment)1:
                        graph.DrawString(Text, Font, new SolidBrush(Color.FromArgb(150, Color.Black)), rectan, stringFormat);
                        Rectangle rectang1 = new((Width - (int)textSize.Width) / 2, Height - 3, (int)textSize.Width, 2);
                        graph.DrawRectangle(new Pen(pressColor), rectang1);
                        graph.FillRectangle(new SolidBrush(fillColor), rectang1);
                        break;
                    case (StringAlignment)2:
                        break;
                }
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
            Invalidate();
        }

        #endregion
    }
}
