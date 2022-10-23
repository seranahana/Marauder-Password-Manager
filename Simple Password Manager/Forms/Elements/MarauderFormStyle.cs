using SimplePM.Themes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePM.Forms.Elements
{
    public partial class MarauderFormStyle : Component
    {
        private fStyle formStyle = fStyle.Telegram;
        private Theme currentTheme = new Cattleya(); // Current application theme

        #region --Properties--

        public Theme CurrentTheme
        {
            set 
            { 
                currentTheme = value;
                ApplyTheme();
            }
        }

        public Form Form { get; set; }

        public fStyle FormStyle
        {
            get => formStyle;
            set
            {
                formStyle = value;
                ApplyStyle();
            }
        }

        [Description("Указывает, может ли пользователь изменять размер окна")]
        public bool AllowUserResize { get; set; }
        [Description("Ширина кнопок меню окна")]
        public int ControlBoxButtonsWidth { get; set; } = 24;
        [Description("Высота шапки (заголовка)")]
        public int HeaderHeight { get; set; } = 20;

        [Description("Шрифт текста шапки (заголовка)")]
        public Font HeaderTextFont { get; set; } = new Font("Segoe UI", 9F, FontStyle.Bold);

        [Description("Горизонтальное выравнивание текста шапки (заголовка)")]
        public StringAlignment HeaderHorizontalAlignment { get; set; } = StringAlignment.Center;
        [Description("Вертикальное выравнивание текста шапки (заголовка)")]
        public StringAlignment HeaderVerticalAlignment { get; set; } = StringAlignment.Center;
        [Description("Включает или выключает отображение кнопки 'Развернуть'")]
        public bool ShowMaximizeButton { get; set; } = true;
        [Description("Включает или выключает отображение кнопки 'Свернуть'")]
        public bool ShowMinimizeButton { get; set; } = true;

        #endregion

        #region --Fields--

        private Color backColor = Color.Black; // Background color (defined by theme)
        private Color headerColor = Color.Black; // Header color (defined by theme)
        private Color headerTextColor = Color.White; // Header text color (defined by theme)
        private Color borderColor = Color.White; // Border color (defined by theme)

        private Size IconSize = new(14, 14);
        private Rectangle rectIcon = new(); // Form icon rectangle

        private StringFormat stringFormat = new();

        private bool MousePressed = false;
        private Point clickPosition; // Starting cursor position in a moment of click
        private Point moveStartPosition; // Starting form position in a moment of click
        private bool CanDragForm = false; // Can form be dragged?

        private MouseButtons LastClickedMouseButton; // Which mouse button has been pressed last 

        private Size ControlBoxIconSize = new(8, 8); // Menu icons size

        private Rectangle rectBtnClose = new();
        private Rectangle rectBtnMax = new();
        private Rectangle rectBtnMin = new();

        private bool btnCloseHovered = false;
        private bool btnMaximizeHovered = false;
        private bool btnMinimizeHovered = false;

        private Pen penBtnClose = new(Color.White, 1.55F);
        private Pen penBtnMaximize = new(Color.DarkGray, 1.55F);
        private Pen penBtnMinimize = new(Color.Gray, 1.55F);

        private Rectangle rectHeader = new();
        private Rectangle rectBorder = new();

        private int resizeBorderSize = 4;
        private int resizeAngleBorderOffset = 15;
        private bool isResizing = false; // Is in resize mode?

        private BorderHoverPositionEnum borderHoverPosition = BorderHoverPositionEnum.None;

        private int resizeStartRight = 0;
        private int resizeStartBottom = 0;

        private bool FormNeedReposition = false;

        private bool Activated = false;

        #endregion

        public MarauderFormStyle()
        {
            InitializeComponent();
            currentTheme = SettingsProcessor.GetCurrentTheme();
            ApplyTheme();
        }

        public MarauderFormStyle(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            currentTheme = SettingsProcessor.GetCurrentTheme();
            ApplyTheme();
        }

        public void ApplyStyle()
        {
            if (Form != null)
            {
                Form.HandleCreated += Form_HandleCreated;
                if (Form.IsHandleCreated)
                {
                    SetStyle();
                    Form.Refresh();
                }
            }
        }

        public void SetStyle()
        {
            Form.FormBorderStyle = FormBorderStyle.None;
            FormWindowState formWindowStateTEMP = Form.WindowState;
            Form.WindowState = FormWindowState.Normal;
            OffsetControls(-HeaderHeight);
            Form.Height -= HeaderHeight;

            Form.BackColor = backColor;

            OffsetControls(HeaderHeight);

            Form.Height += HeaderHeight;
            Form.Refresh();

            Form.WindowState = formWindowStateTEMP;

            stringFormat.Alignment = HeaderHorizontalAlignment;
            stringFormat.LineAlignment = HeaderVerticalAlignment;
            Size minimumSize = new(100, 50);
            if (Form.MinimumSize.Width < minimumSize.Width || Form.MinimumSize.Height < minimumSize.Height)
            {
                Form.MinimumSize = minimumSize;
            }
            SetDoubleBuffered(Form);

            Form.Activated += Form_Activated;
            Form.Deactivate += Form_Deactivate;
            Form.Paint += Form_Paint;
            Form.MouseDown += Form_MouseDown;
            Form.MouseUp += Form_MouseUp;
            Form.MouseMove += Form_MouseMove;
            Form.MouseLeave += Form_MouseLeave;
            Form.SizeChanged += Form_SizeChanged;
            Form.DoubleClick += Form_DoubleClick;
            Form.Click += Form_Click;
        }

        private void OffsetControls(int offsett)
        {
            foreach (Control ctrl in Form.Controls)
            {
                ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y + offsett);
                ctrl.Refresh();
            }
        }

        private void ApplyTheme()
        {
            backColor = currentTheme.MarauderFormStyle.BackColor;
            borderColor = currentTheme.MarauderFormStyle.BorderColor;
            ControlBoxButtonsWidth = currentTheme.MarauderFormStyle.ControlBoxButtonsWidth;
            headerColor = currentTheme.MarauderFormStyle.HeaderColor;
            HeaderHeight = currentTheme.MarauderFormStyle.HeaderHeight;
            headerTextColor = currentTheme.MarauderFormStyle.HeaderTextColor;
            HeaderTextFont = currentTheme.MarauderFormStyle.HeaderTextFont;
        }

        #region --Form Events--

        private void Form_HandleCreated(object sender, EventArgs e)
        {
            SetStyle();
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }

        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Form.Refresh();
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            Activated = true;
            Form.Refresh();
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            Activated = false;
            Form.Refresh();
        }

        private void Form_MouseLeave(object sender, EventArgs e)
        {
            btnCloseHovered = false;
            btnMaximizeHovered = false;
            btnMinimizeHovered = false;
            Form.Invalidate();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {

            // Dragging
            if (CanDragForm && e.Button == MouseButtons.Left)
            {
                if (Form.WindowState == FormWindowState.Maximized)
                {
                    float maxWidth = Form.Width;
                    float cursosOnMaxPosition = e.X;
                    float coeff = cursosOnMaxPosition / (maxWidth / 100f) / 100f;

                    // Change WindowState if is Maximized
                    Form.WindowState = FormWindowState.Normal;

                    int XFormOffset = (int)(Form.Width * coeff);

                    Form.Location = new Point(Cursor.Position.X - XFormOffset, Cursor.Position.Y - HeaderHeight / 2);
                    moveStartPosition = Form.Location;
                    clickPosition = Cursor.Position;
                }
                else
                {
                    // Moving
                    Size frmOffset = new(Point.Subtract(Cursor.Position, new Size(clickPosition)));
                    Form.Location = Point.Add(moveStartPosition, frmOffset);
                }
            }
            // Hovering
            else
            {
                // Close Button Hovering
                if (rectBtnClose.Contains(e.Location))
                {
                    if (btnCloseHovered == false)
                    {
                        btnCloseHovered = true;
                    }
                }
                else
                {
                    if (btnCloseHovered == true)
                    {
                        btnCloseHovered = false;
                        Form.Invalidate();
                    }
                }

                // Maximize Button Hovering
                if (rectBtnMax.Contains(e.Location))
                {
                    if (btnMaximizeHovered == false)
                    {
                        btnMaximizeHovered = true;
                    }
                }
                else
                {
                    if (btnMaximizeHovered)
                    {
                        btnMaximizeHovered = false;
                        Form.Invalidate();
                    }
                }

                // Minimize Button Hovering
                if (rectBtnMin.Contains(e.Location))
                {
                    if (btnMinimizeHovered == false)
                    {
                        btnMinimizeHovered = true;
                    }
                }
                else
                {
                    if (btnMinimizeHovered)
                    {
                        btnMinimizeHovered = false;
                        Form.Invalidate();
                    }
                }
            }

            // On hover on border for resize
            if (AllowUserResize && isResizing == false && Form.WindowState == FormWindowState.Normal)
            {
                if (rectBorder.Top + resizeBorderSize >= e.Location.Y)
                {
                    // Left Top Corner
                    if (e.Location.X <= resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        borderHoverPosition = BorderHoverPositionEnum.TopLeft;
                    }
                    // Right Top Corner
                    else if (e.Location.X >= rectBorder.Width - resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        borderHoverPosition = BorderHoverPositionEnum.TopRight;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeNS;
                        borderHoverPosition = BorderHoverPositionEnum.Top;
                    }
                }
                else if (rectBorder.Bottom - resizeBorderSize <= e.Location.Y)
                {
                    // Left Bottom Corner
                    if (e.Location.X <= resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        borderHoverPosition = BorderHoverPositionEnum.BottomLeft;
                    }
                    // Right Bottom Corner
                    else if (e.Location.X >= rectBorder.Width - resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        borderHoverPosition = BorderHoverPositionEnum.BottomRight;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeNS;
                        borderHoverPosition = BorderHoverPositionEnum.Bottom;
                    }
                }
                else if (rectBorder.Left + resizeBorderSize >= e.Location.X)
                {
                    // Left Top Corner
                    if (e.Location.Y <= resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        borderHoverPosition = BorderHoverPositionEnum.TopLeft;
                    }
                    // Left Bottom Corner
                    else if (e.Location.Y >= rectBorder.Height - resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        borderHoverPosition = BorderHoverPositionEnum.BottomLeft;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeWE;
                        borderHoverPosition = BorderHoverPositionEnum.Left;
                    }
                }
                else if (rectBorder.Right - resizeBorderSize <= e.Location.X)
                {
                    // Right Top Corner
                    if (e.Location.Y <= resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        borderHoverPosition = BorderHoverPositionEnum.TopRight;
                    }
                    // Right Bottom Corner
                    else if (e.Location.Y >= rectBorder.Height - resizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        borderHoverPosition = BorderHoverPositionEnum.BottomRight;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeWE;
                        borderHoverPosition = BorderHoverPositionEnum.Right;
                    }
                }
                else if (Form.Cursor != Cursors.Default)
                {
                    Form.Cursor = Cursors.Default;
                    borderHoverPosition = BorderHoverPositionEnum.None;
                }
            }
            // Resize
            else if (AllowUserResize && isResizing && Form.WindowState == FormWindowState.Normal)
            {
                // Resize
                switch (borderHoverPosition)
                {
                    // Sides
                    case BorderHoverPositionEnum.Left:
                        Form.Location = new Point(Cursor.Position.X, Form.Location.Y);
                        Form.Width = Form.Width - (Form.Right - resizeStartRight);
                        break;

                    case BorderHoverPositionEnum.Top:
                        Form.Location = new Point(Form.Location.X, Cursor.Position.Y);
                        Form.Height = Form.Height - (Form.Bottom - resizeStartBottom);
                        break;

                    case BorderHoverPositionEnum.Right:
                        Form.Width = Cursor.Position.X - Form.Left;
                        break;

                    case BorderHoverPositionEnum.Bottom:
                        Form.Height = Cursor.Position.Y - Form.Top;
                        break;


                    // Angles
                    case BorderHoverPositionEnum.TopLeft:
                        Form.Location = new Point(Form.Location.X, Cursor.Position.Y);
                        Form.Height = Form.Height - (Form.Bottom - resizeStartBottom);

                        Form.Location = new Point(Cursor.Position.X, Form.Location.Y);
                        Form.Width = Form.Width - (Form.Right - resizeStartRight);
                        break;

                    case BorderHoverPositionEnum.TopRight:
                        Form.Location = new Point(Form.Location.X, Cursor.Position.Y);
                        Form.Height = Form.Height - (Form.Bottom - resizeStartBottom);

                        Form.Width = Cursor.Position.X - Form.Left;
                        break;

                    case BorderHoverPositionEnum.BottomLeft:
                        Form.Height = Cursor.Position.Y - Form.Top;

                        Form.Location = new Point(Cursor.Position.X, Form.Location.Y);
                        Form.Width = Form.Width - (Form.Right - resizeStartRight);
                        break;

                    case BorderHoverPositionEnum.BottomRight:
                        Form.Height = Cursor.Position.Y - Form.Top;
                        Form.Width = Cursor.Position.X - Form.Left;
                        break;


                }
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (Form.IsHandleCreated == false) return;

            MousePressed = false;
            CanDragForm = false;
            isResizing = false;

            if (AllowUserResize && borderHoverPosition != BorderHoverPositionEnum.None)
                return;

            // Dragging form to the top of the scrern will maximize it
            if (Cursor.Position.Y == Screen.FromHandle(Form.Handle).WorkingArea.Y
                && Form.WindowState == FormWindowState.Normal)
            {
                Form.WindowState = FormWindowState.Maximized;
                FormNeedReposition = true;
            }

            // Y restriction
            if (Form.Location.Y < Screen.FromHandle(Form.Handle).WorkingArea.Y)
            {
                Form.Location = new Point(Form.Location.X, Screen.FromHandle(Form.Handle).WorkingArea.Y);
            }

            // Form menu buttons click
            if (e.Button == MouseButtons.Left && Form.ControlBox == true)
            {
                // Close Button Click
                if (rectBtnClose.Contains(e.Location))
                    Form.Close();

                // Max Button Click
                if (rectBtnMax.Contains(e.Location) && Form.MaximizeBox == true)
                {
                    if (AllowUserResize)
                    {
                        if (Form.WindowState == FormWindowState.Maximized)
                        {
                            Form.WindowState = FormWindowState.Normal;

                            if (FormNeedReposition)
                            {
                                FormNeedReposition = false;
                                Form.Location = moveStartPosition;
                            }
                        }
                        else if (Form.WindowState == FormWindowState.Normal)
                        {
                            Form.WindowState = FormWindowState.Maximized;
                        }
                    }
                }

                // Min Button Click
                if (rectBtnMin.Contains(e.Location) && Form.MinimizeBox == true)
                    Form.WindowState = FormWindowState.Minimized;
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed = true;

            if (AllowUserResize && borderHoverPosition != BorderHoverPositionEnum.None)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isResizing = true;
                    resizeStartRight = Form.Right;
                    resizeStartBottom = Form.Bottom;
                    return;
                }
            }

            if (e.Location.Y <= HeaderHeight
                && !rectBtnClose.Contains(e.Location)
                && !rectBtnMax.Contains(e.Location)
                && !rectBtnMin.Contains(e.Location))
            {
                CanDragForm = true;
                clickPosition = Cursor.Position;
                moveStartPosition = Form.Location;
            }

            LastClickedMouseButton = e.Button;
        }

        private void Form_DoubleClick(object sender, EventArgs e)
        {
            if (borderHoverPosition != BorderHoverPositionEnum.None || AllowUserResize == false)
                return;

            if (MousePressed && LastClickedMouseButton == MouseButtons.Left && rectHeader.Contains(Form.PointToClient(Cursor.Position)))
            {
                if (Form.WindowState == FormWindowState.Maximized)
                {
                    Form.WindowState = FormWindowState.Normal;
                }
                else if (Form.WindowState == FormWindowState.Normal)
                {
                    Form.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void Form_Click(object sender, EventArgs e)
        {
            Form.Focus();
        }

        #endregion

        #region --Drawing--

        private void DrawStyle(Graphics graph)
        {
            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (HeaderHeight == 0) return;

            // Header Structure
            rectHeader = new Rectangle(0, 0, Form.Width - 1, HeaderHeight);

            // Border Structure
            rectBorder = new Rectangle(0, 0, Form.Width - 1, Form.Height - 1);

            // Icon Structure
            rectIcon = new Rectangle(
                rectHeader.Height / 2 - IconSize.Width / 2,
                rectHeader.Height / 2 - IconSize.Height / 2,
                IconSize.Width, IconSize.Height
                );

            // Title Structure
            Rectangle rectTitleText = new(Form.ShowIcon ? rectIcon.Right + 5 : rectIcon.Left, rectHeader.Y, rectHeader.Width, rectHeader.Height);

            // Close Button Structure
            rectBtnClose = new Rectangle(rectHeader.Width - ControlBoxButtonsWidth, rectHeader.Y, ControlBoxButtonsWidth, rectHeader.Height);
            // Crosshair Structure
            Rectangle rectCrosshair = new(
                rectBtnClose.X + rectBtnClose.Width / 2 - ControlBoxIconSize.Width / 2,
                rectBtnClose.Height / 2 - ControlBoxIconSize.Height / 2,
                ControlBoxIconSize.Width, ControlBoxIconSize.Height);

            // Maximize Button Structure
            rectBtnMax = new Rectangle(rectBtnClose.X - ControlBoxButtonsWidth, rectHeader.Y, ControlBoxButtonsWidth, rectHeader.Height);
            // Maximize Icon Structure
            Rectangle rectMaxButtonIcon = new(
                rectBtnMax.X + rectBtnMax.Width / 2 - ControlBoxIconSize.Width / 2,
                rectBtnMax.Height / 2 - ControlBoxIconSize.Height / 2,
                ControlBoxIconSize.Width, ControlBoxIconSize.Height);
            // Second Maximize Icon Structure [in Maximized state]
            Rectangle rectMaxButtonIconSecond = rectMaxButtonIcon;

            if (Form.WindowState == FormWindowState.Maximized)
            {
                //Inflate - изменяет размер и одновременно положение (В данном случае -1 по ширине и +2 по X, -1 по высоте и +2 по Y)

                rectMaxButtonIconSecond.Inflate(-1, -1);
                rectMaxButtonIconSecond.Offset(1, -1);

                rectMaxButtonIcon.Inflate(-1, -1);
                rectMaxButtonIcon.Offset(-1, 1);
            }

            // Minimize Button Structure
            if (ShowMaximizeButton)
            {
                rectBtnMin = new Rectangle(rectBtnMax.X - ControlBoxButtonsWidth, rectHeader.Y, ControlBoxButtonsWidth, rectHeader.Height);
            }
            else
            {
                rectBtnMin = rectBtnMax;
            }

            Point point1BtnMin = new(
                    rectBtnMin.X + rectBtnMin.Width / 2 - ControlBoxIconSize.Width / 2,
                    rectBtnMin.Height / 2 + ControlBoxIconSize.Height / 2
                    );
            Point point2BtnMin = new(
                rectBtnMin.X + rectBtnMin.Width / 2 + ControlBoxIconSize.Width / 2,
                rectBtnMin.Height / 2 + ControlBoxIconSize.Height / 2
                );
            Brush headerBrush = new SolidBrush(headerColor);

            // Header
            graph.DrawRectangle(new Pen(headerBrush), rectHeader);
            graph.FillRectangle(headerBrush, rectHeader);

            // Border
            if (Activated)
            {
                Pen borderPen = new(borderColor, 1)
                {
                    Alignment = PenAlignment.Inset
                };
                graph.DrawRectangle(borderPen, rectBorder);
            }
            else
            {
                Pen borderPen = new(backColor)
                {
                    Alignment = PenAlignment.Inset
                };
                graph.DrawRectangle(borderPen, rectBorder);
            }
            // Title
            graph.DrawString(Form.Text, HeaderTextFont, new SolidBrush(headerTextColor), rectTitleText, stringFormat);

            // Icon
            if (Form.ShowIcon)
            {
                graph.DrawImage(Form.Icon.ToBitmap(), rectIcon);
            }

            if (Form.ControlBox == true)
            {
                penBtnClose.Color = penBtnMaximize.Color = penBtnMinimize.Color = Color.White;
                if (Form.MaximizeBox == false)
                    penBtnMaximize.Color = Color.LightGray;
                if (Form.MinimizeBox == false)
                    penBtnMinimize.Color = Color.LightGray;

                // Close button
                graph.DrawRectangle(new Pen(btnCloseHovered ? FlatColors.Red2 : Color.Transparent), rectBtnClose);
                graph.FillRectangle(new SolidBrush(btnCloseHovered ? FlatColors.Red2 : Color.Transparent), rectBtnClose);
                DrawCrosshair(graph, rectCrosshair, penBtnClose);

                // Maximize button
                if (ShowMaximizeButton)
                {
                    graph.DrawRectangle(new Pen(btnMaximizeHovered && Form.MaximizeBox ? Color.FromArgb(100, Color.Gray) : Color.Transparent), rectBtnMax);
                    graph.FillRectangle(new SolidBrush(btnMaximizeHovered && Form.MaximizeBox ? Color.FromArgb(100, Color.Gray) : Color.Transparent), rectBtnMax);

                    // Draw icon
                    if (Form.WindowState == FormWindowState.Maximized)
                    {
                        graph.DrawRectangle(penBtnMaximize, rectMaxButtonIconSecond);
                        //graph.FillRectangle(new SolidBrush(HeaderColor), rectMaxButtonIcon);
                        graph.FillRectangle(headerBrush, rectMaxButtonIcon);
                    }
                    graph.DrawRectangle(penBtnMaximize, rectMaxButtonIcon);
                }

                // Minimize button
                if (ShowMinimizeButton)
                {
                    graph.DrawRectangle(new Pen(btnMinimizeHovered && Form.MinimizeBox ? Color.FromArgb(100, Color.Gray) : Color.Transparent), rectBtnMin);
                    graph.FillRectangle(new SolidBrush(btnMinimizeHovered && Form.MinimizeBox ? Color.FromArgb(100, Color.Gray) : Color.Transparent), rectBtnMin);
                    graph.DrawLine(penBtnMinimize, point1BtnMin, point2BtnMin);
                }
            }
        }

        private void DrawCrosshair(Graphics graph, Rectangle rect, Pen pen)
        {
            graph.DrawLine(
                pen,
                rect.X,
                rect.Y,
                rect.X + rect.Width,
                rect.Y + rect.Height);

            graph.DrawLine(
                pen,
                rect.X + rect.Width,
                rect.Y,
                rect.X,
                rect.Y + rect.Height);
        }

        #endregion

        public static void SetDoubleBuffered(Control c)
        {
            if (SystemInformation.TerminalServerSession)
            {
                return;
            }
            System.Reflection.PropertyInfo pDoubleBuffered = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            pDoubleBuffered.SetValue(c, true, null);
        }
    }
}