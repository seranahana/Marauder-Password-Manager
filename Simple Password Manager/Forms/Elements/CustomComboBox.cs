using SimplePM.Themes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePM.Forms.Elements
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public partial class CustomComboBox : UserControl
    {
        private Color backColor = Color.Black;
        private Color iconColor = Color.White;
        private Color listBackColor = Color.Black;
        private Color listForeColor = Color.White;
        private Color borderColor = Color.White;
        private Font comboBoxFont = new("Verdana", 11F);
        private int borderSize = 1;
        private Theme currentTheme = new Cattleya();

        #region --Properties--

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
                dropdownText.BackColor = backColor;
                comboBox.BackColor = backColor;
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
                buttonIcon.Invalidate(); // Redraw icon
            }
        }

        [Description("Dropdown list background color")]
        public Color ListBackColor
        {
            get
            {
                return listBackColor;
            }
            set
            {
                listBackColor = value;
                comboBox.BackColor = listBackColor;
            }
        }

        [Description("Dropdown list text color")]
        public Color ListForeColor
        {
            get
            {
                return listForeColor;
            }
            set
            {
                listForeColor = value;
                comboBox.ForeColor = listForeColor;
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
                base.BackColor = borderColor; // Border Color
            }
        }

        [Description("Font")]
        public override Font Font
        {
            get
            {
                return comboBoxFont;
            }
            set
            {
                comboBoxFont = value;
                dropdownText.Font = value;
                comboBox.Font = value;
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
                Padding = new Padding(borderSize); // Border Size
                AdjustComboBoxDimensions();
            }
        }

        [Description("Text color")]
        public override Color ForeColor 
        {
            get 
            { 
                return base.ForeColor; 
            } 
            set 
            { 
                base.ForeColor = value;
                dropdownText.ForeColor = value;
            } 
        }

        [Description("Combo box strings")]
        public string Texts
        {
            get
            {
                return dropdownText.Text;
            }
            set
            {
                dropdownText.Text = value;
            }
        }

        [Description("Dropdown list style")]
        public ComboBoxStyle DropDownStyle
        {
            get
            {
                return comboBox.DropDownStyle;
            }
            set
            {
                if (comboBox.DropDownStyle != ComboBoxStyle.Simple)
                {
                    comboBox.DropDownStyle = value;
                }
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

        #region --Fields--

        private ComboBox comboBox;
        private Label dropdownText;
        private Button buttonIcon;

        #endregion

        #region --Data--

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return comboBox.Items; }
        }
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return comboBox.DataSource; }
            set { comboBox.DataSource = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return comboBox.AutoCompleteCustomSource; }
            set { comboBox.AutoCompleteCustomSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return comboBox.AutoCompleteSource; }
            set { comboBox.AutoCompleteSource = value; }
        }

        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return comboBox.AutoCompleteMode; }
            set { comboBox.AutoCompleteMode = value; }
        }

        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return comboBox.SelectedItem; }
            set { comboBox.SelectedItem = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return comboBox.SelectedIndex; }
            set { comboBox.SelectedIndex = value; }
        }

        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return comboBox.DisplayMember; }
            set { comboBox.DisplayMember = value; }
        }

        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return comboBox.ValueMember; }
            set { comboBox.ValueMember = value; }
        }

        #endregion

        public event EventHandler OnSelectedIndexChanged; // Default Event

        public CustomComboBox()
        {
            comboBox = new ComboBox();
            dropdownText = new Label();
            buttonIcon = new Button();
            currentTheme = SettingsProcessor.GetCurrentTheme();
            SuspendLayout();

            comboBox.BackColor = listBackColor;
            comboBox.Font = comboBoxFont;
            comboBox.ForeColor = listForeColor;
            comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); // Default event
            comboBox.TextChanged += new EventHandler(ComboBox_TextChanged); // Refresh text

            // Icon
            buttonIcon.Dock = DockStyle.Right;
            buttonIcon.FlatStyle = FlatStyle.Flat;
            buttonIcon.FlatAppearance.BorderSize = 0;
            buttonIcon.BackColor = backColor;
            buttonIcon.Size = new Size(30, 30);
            buttonIcon.Cursor = Cursors.Hand;
            buttonIcon.Click += new EventHandler(Icon_Click); // Open dropdown list
            buttonIcon.Paint += new PaintEventHandler(Icon_Paint); // Draw icon

            // comboBox Items
            dropdownText.Dock = DockStyle.Fill;
            dropdownText.AutoSize = false;
            dropdownText.BackColor = backColor;
            dropdownText.TextAlign = ContentAlignment.MiddleLeft;
            dropdownText.Padding = new Padding(8, 0, 0, 0);
            dropdownText.Font = comboBoxFont;
            dropdownText.Click += new EventHandler(Surface_Click); // Select comboBox Item

            //User Control
            Controls.Add(dropdownText); // 3
            Controls.Add(buttonIcon); // 2
            Controls.Add(comboBox); // 1
            MinimumSize = new Size(200, 30);
            Size = new Size(400, 30);
            ForeColor = listForeColor;
            Padding = new Padding(borderSize); // Border Size
            base.BackColor = borderColor;
            ResumeLayout();
            AdjustComboBoxDimensions();
            ApplyTheme();
        }

        private void AdjustComboBoxDimensions()
        {
            comboBox.Width = Width - buttonIcon.Width - 1;
            comboBox.Location = new Point()
            {
                X = Width - Padding.Right - comboBox.Width - buttonIcon.Width + 1,
                Y = dropdownText.Bottom - comboBox.Height
            };
        }

        private void ApplyTheme()
        {
            BackColor = currentTheme.CustomComboBoxStyle.BackColor;
            BorderColor = currentTheme.CustomComboBoxStyle.BorderColor;
            ForeColor = currentTheme.CustomComboBoxStyle.ForeColor;
            IconColor = currentTheme.CustomComboBoxStyle.IconColor;
            ListBackColor = currentTheme.CustomComboBoxStyle.ListBackColor;
            ListForeColor = currentTheme.CustomComboBoxStyle.ListForeColor;
            Font = currentTheme.CustomComboBoxStyle.Font;
        }

        #region --Event Handlers--

        private void Surface_Click(object sender, EventArgs e)
        {
            comboBox.Select();
            if (comboBox.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                comboBox.DroppedDown = true; // Open dropdown list
            }
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((buttonIcon.Width - iconWidht) / 2, (buttonIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            using GraphicsPath path = new();
            using Pen pen = new(iconColor, 2);
            graph.SmoothingMode = SmoothingMode.AntiAlias;
            path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
            path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
            graph.DrawPath(pen, path);
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            comboBox.Select();
            comboBox.DroppedDown = true; // Open dropdown list
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            dropdownText.Text = comboBox.Text;
        }

        // Default Event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
            {
                OnSelectedIndexChanged.Invoke(sender, e);
            }
            dropdownText.Text = comboBox.Text;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        #endregion
    }
}
