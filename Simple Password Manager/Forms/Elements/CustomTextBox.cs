using SimplePM.Themes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePM.Forms.Elements
{
    [DefaultEvent("TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Theme currentTheme = new Cattleya();

        #region --Properties--

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                Invalidate();
            }
        }
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
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

        public string Texts
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        public bool ReadOnly
        {
            get { return textBox1.ReadOnly; }
            set { textBox1.ReadOnly = value; }
        }

        #endregion

        #region --Fields--

        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        #endregion

        //Default Event
        public new event EventHandler TextChanged;

        public CustomTextBox()
        {
            InitializeComponent();
            currentTheme = SettingsProcessor.GetCurrentTheme();
            if (DesignMode)
                UpdateControlHeight();
            ApplyTheme();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                Height = textBox1.Height + Padding.Top + Padding.Bottom;
            }
        }

        private void ApplyTheme()
        {
            base.BackColor = currentTheme.CustomTextBoxStyle.BackColor;
            textBox1.BackColor = currentTheme.CustomTextBoxStyle.BackColor;
            borderColor = currentTheme.CustomTextBoxStyle.BorderColor;
            borderFocusColor = currentTheme.CustomTextBoxStyle.BorderFocusColor;
            base.Font = currentTheme.CustomTextBoxStyle.Font;
            textBox1.Font = currentTheme.CustomTextBoxStyle.Font;
            base.ForeColor = currentTheme.CustomTextBoxStyle.ForeColor;
            textBox1.ForeColor = currentTheme.CustomTextBoxStyle.ForeColor;
        }

        #region --Event Handlers--

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            using Pen penBorder = new(borderColor, borderSize);
            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
            if (isFocused) penBorder.Color = borderFocusColor;//Set Border color in focus. Otherwise, normal border color
            if (underlinedStyle) //Line Style
                graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
            else //Normal Style
                graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
                UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //Change border color in focus mode
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
        }

        //TextBox events
        /// <summary>
        /// textbox events attached to user control events
        /// </summary>
        private void textBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        //TextBox-> TextChanged event
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextChanged != null)
                TextChanged.Invoke(sender, e);
        }

        #endregion
    }
}
