using SimplePM.Themes;
using System;

namespace SimplePM.Forms
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.masterPasswordTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.visibilityButton = new System.Windows.Forms.Button();
            this.resetLabel = new System.Windows.Forms.Label();
            this.confirmButton = new SimplePM.Forms.Elements.CustomButton();
            this.masterPassLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.incorrectPasswordLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.invalidPasswordLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.SuspendLayout();
            // 
            // masterPasswordTextBox
            // 
            this.masterPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.masterPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.masterPasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.masterPasswordTextBox.BorderSize = 2;
            this.masterPasswordTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masterPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.masterPasswordTextBox.Location = new System.Drawing.Point(93, 138);
            this.masterPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.masterPasswordTextBox.Multiline = false;
            this.masterPasswordTextBox.Name = "masterPasswordTextBox";
            this.masterPasswordTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.masterPasswordTextBox.PasswordChar = true;
            this.masterPasswordTextBox.ReadOnly = false;
            this.masterPasswordTextBox.Size = new System.Drawing.Size(292, 33);
            this.masterPasswordTextBox.TabIndex = 0;
            this.masterPasswordTextBox.Texts = "";
            this.masterPasswordTextBox.UnderlinedStyle = true;
            // 
            // marauderFormStyle1
            // 
            this.marauderFormStyle1.AllowUserResize = false;
            this.marauderFormStyle1.ControlBoxButtonsWidth = 24;
            this.marauderFormStyle1.Form = this;
            this.marauderFormStyle1.FormStyle = SimplePM.fStyle.Telegram;
            this.marauderFormStyle1.HeaderHeight = 20;
            this.marauderFormStyle1.HeaderHorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.marauderFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.marauderFormStyle1.HeaderVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.marauderFormStyle1.ShowMaximizeButton = false;
            this.marauderFormStyle1.ShowMinimizeButton = false;
            // 
            // visibilityButton
            // 
            this.visibilityButton.BackColor = System.Drawing.Color.Transparent;
            this.visibilityButton.BackgroundImage = global::SimplePM.Properties.Resources.visible_icon;
            this.visibilityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.visibilityButton.FlatAppearance.BorderSize = 0;
            this.visibilityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.visibilityButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.visibilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visibilityButton.Location = new System.Drawing.Point(392, 140);
            this.visibilityButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.visibilityButton.Name = "visibilityButton";
            this.visibilityButton.Size = new System.Drawing.Size(35, 35);
            this.visibilityButton.TabIndex = 5;
            this.visibilityButton.UseVisualStyleBackColor = false;
            this.visibilityButton.Click += new System.EventHandler(this.visibilityButton_Click);
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.resetLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.resetLabel.Location = new System.Drawing.Point(123, 230);
            this.resetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(278, 13);
            this.resetLabel.TabIndex = 10;
            this.resetLabel.Text = "If you forgot your password, you can reset app";
            this.resetLabel.Click += new System.EventHandler(this.resetLabel_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Location = new System.Drawing.Point(197, 260);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 31);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Unlock";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // masterPassLabel
            // 
            this.masterPassLabel.AutoSize = true;
            this.masterPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.masterPassLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.masterPassLabel.ForeColor = System.Drawing.Color.White;
            this.masterPassLabel.Location = new System.Drawing.Point(160, 117);
            this.masterPassLabel.Name = "masterPassLabel";
            this.masterPassLabel.Size = new System.Drawing.Size(181, 18);
            this.masterPassLabel.TabIndex = 12;
            this.masterPassLabel.Text = "Set master password";
            this.masterPassLabel.Type = SimplePM.LabelType.Header;
            // 
            // incorrectPasswordLabel
            // 
            this.incorrectPasswordLabel.AutoSize = true;
            this.incorrectPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectPasswordLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incorrectPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectPasswordLabel.Location = new System.Drawing.Point(172, 174);
            this.incorrectPasswordLabel.Name = "incorrectPasswordLabel";
            this.incorrectPasswordLabel.Size = new System.Drawing.Size(151, 12);
            this.incorrectPasswordLabel.TabIndex = 13;
            this.incorrectPasswordLabel.Text = "Incorrect master password";
            this.incorrectPasswordLabel.Type = SimplePM.LabelType.Small;
            this.incorrectPasswordLabel.Visible = false;
            // 
            // invalidPasswordLabel
            // 
            this.invalidPasswordLabel.AutoSize = true;
            this.invalidPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidPasswordLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalidPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidPasswordLabel.Location = new System.Drawing.Point(112, 174);
            this.invalidPasswordLabel.Name = "invalidPasswordLabel";
            this.invalidPasswordLabel.Size = new System.Drawing.Size(254, 12);
            this.invalidPasswordLabel.TabIndex = 28;
            this.invalidPasswordLabel.Text = "Password cannot have less than 8 characters";
            this.invalidPasswordLabel.Type = SimplePM.LabelType.Small;
            this.invalidPasswordLabel.Visible = false;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 339);
            this.Controls.Add(this.incorrectPasswordLabel);
            this.Controls.Add(this.masterPassLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.resetLabel);
            this.Controls.Add(this.visibilityButton);
            this.Controls.Add(this.masterPasswordTextBox);
            this.Controls.Add(this.invalidPasswordLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MasterPassForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void SetLabels()
        {
            if (_login is not null || _password is not null)
            {
                masterPassLabel.Visible = true;
                masterPassLabel.Text = "Set master password";
                return;
            }
            if (Properties.Settings.Default.IsReset || Properties.Settings.Default.IsFirstRun)
            {
                masterPassLabel.Text = "Set master password";
                confirmButton.Text = "Confirm";
            }
            else
            {
                masterPassLabel.Text = "Enter master password";
            }
        }

        private void SetWindowHeader(string headerText)
        {
            this.Text = headerText;
        }

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            masterPasswordTextBox.CurrentTheme = theme;
            confirmButton.CurrentTheme = theme;
            masterPassLabel.CurrentTheme = theme;
            incorrectPasswordLabel.CurrentTheme = theme;
            invalidPasswordLabel.CurrentTheme = theme;

            visibilityButton.BackColor = theme.ImageButtonStyle.BackColor;
            visibilityButton.FlatStyle = theme.ImageButtonStyle.FlatStyle;
            visibilityButton.FlatAppearance.BorderSize = theme.ImageButtonStyle.BorderSize;
            visibilityButton.FlatAppearance.MouseDownBackColor = theme.ImageButtonStyle.MouseDownBackColor;
            visibilityButton.FlatAppearance.MouseOverBackColor = theme.ImageButtonStyle.MouseOverBackColor;
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomTextBox masterPasswordTextBox;
        private System.Windows.Forms.Button visibilityButton;
        private System.Windows.Forms.Label resetLabel;
        private Elements.CustomButton confirmButton;
        private Elements.ThemedLabel masterPassLabel;
        private Elements.ThemedLabel incorrectPasswordLabel;
        private Elements.ThemedLabel invalidPasswordLabel;
    }
}