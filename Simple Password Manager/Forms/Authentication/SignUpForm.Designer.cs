using SimplePM.Themes;

namespace SimplePM.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.confirmButton = new SimplePM.Forms.Elements.CustomButton();
            this.confirmPasswordTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.passwordTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.usernameTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.themedLabel1 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel2 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel3 = new SimplePM.Forms.Elements.ThemedLabel();
            this.illegalUsernameLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.usernameNotAvailableLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.invalidPasswordLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.passwordsNotMatchLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.SuspendLayout();
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
            this.marauderFormStyle1.ShowMinimizeButton = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Location = new System.Drawing.Point(150, 330);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 31);
            this.confirmButton.TabIndex = 20;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.confirmPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.confirmPasswordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.confirmPasswordTextBox.BorderSize = 2;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(71, 269);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmPasswordTextBox.Multiline = false;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.confirmPasswordTextBox.PasswordChar = true;
            this.confirmPasswordTextBox.ReadOnly = false;
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(292, 33);
            this.confirmPasswordTextBox.TabIndex = 15;
            this.confirmPasswordTextBox.Texts = "";
            this.confirmPasswordTextBox.UnderlinedStyle = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Black;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(71, 169);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(292, 33);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Black;
            this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTextBox.BorderSize = 2;
            this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(71, 79);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.Size = new System.Drawing.Size(292, 33);
            this.usernameTextBox.TabIndex = 11;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = true;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel1.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(71, 59);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(182, 17);
            this.themedLabel1.TabIndex = 22;
            this.themedLabel1.Text = "Enter desired username:";
            this.themedLabel1.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel2.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(71, 149);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(125, 17);
            this.themedLabel2.TabIndex = 23;
            this.themedLabel2.Text = "Enter password:";
            this.themedLabel2.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel3
            // 
            this.themedLabel3.AutoSize = true;
            this.themedLabel3.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel3.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel3.ForeColor = System.Drawing.Color.White;
            this.themedLabel3.Location = new System.Drawing.Point(71, 249);
            this.themedLabel3.Name = "themedLabel3";
            this.themedLabel3.Size = new System.Drawing.Size(142, 17);
            this.themedLabel3.TabIndex = 24;
            this.themedLabel3.Text = "Confirm password:";
            this.themedLabel3.Type = SimplePM.LabelType.Standart;
            // 
            // illegalUsernameLabel
            // 
            this.illegalUsernameLabel.AutoSize = true;
            this.illegalUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.illegalUsernameLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.illegalUsernameLabel.ForeColor = System.Drawing.Color.Red;
            this.illegalUsernameLabel.Location = new System.Drawing.Point(106, 115);
            this.illegalUsernameLabel.Name = "illegalUsernameLabel";
            this.illegalUsernameLabel.Size = new System.Drawing.Size(223, 24);
            this.illegalUsernameLabel.TabIndex = 25;
            this.illegalUsernameLabel.Text = "Username length is less than 3\nor username contains illegal characters";
            this.illegalUsernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.illegalUsernameLabel.Type = SimplePM.LabelType.Small;
            this.illegalUsernameLabel.Visible = false;
            // 
            // usernameNotAvailableLabel
            // 
            this.usernameNotAvailableLabel.AutoSize = true;
            this.usernameNotAvailableLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameNotAvailableLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameNotAvailableLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameNotAvailableLabel.Location = new System.Drawing.Point(118, 118);
            this.usernameNotAvailableLabel.Name = "usernameNotAvailableLabel";
            this.usernameNotAvailableLabel.Size = new System.Drawing.Size(198, 12);
            this.usernameNotAvailableLabel.TabIndex = 26;
            this.usernameNotAvailableLabel.Text = "This username is already occupied";
            this.usernameNotAvailableLabel.Type = SimplePM.LabelType.Small;
            this.usernameNotAvailableLabel.Visible = false;
            // 
            // invalidPasswordLabel
            // 
            this.invalidPasswordLabel.AutoSize = true;
            this.invalidPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidPasswordLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalidPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidPasswordLabel.Location = new System.Drawing.Point(78, 205);
            this.invalidPasswordLabel.Name = "invalidPasswordLabel";
            this.invalidPasswordLabel.Size = new System.Drawing.Size(279, 36);
            this.invalidPasswordLabel.TabIndex = 27;
            this.invalidPasswordLabel.Text = "Password cannot have less than 8 characters\nand should contain at least one upper" +
    "case letter,\none number and one special symbol";
            this.invalidPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invalidPasswordLabel.Type = SimplePM.LabelType.Small;
            this.invalidPasswordLabel.Visible = false;
            // 
            // passwordsNotMatchLabel
            // 
            this.passwordsNotMatchLabel.AutoSize = true;
            this.passwordsNotMatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordsNotMatchLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordsNotMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordsNotMatchLabel.Location = new System.Drawing.Point(147, 305);
            this.passwordsNotMatchLabel.Name = "passwordsNotMatchLabel";
            this.passwordsNotMatchLabel.Size = new System.Drawing.Size(140, 12);
            this.passwordsNotMatchLabel.TabIndex = 28;
            this.passwordsNotMatchLabel.Text = "Passwords do not match";
            this.passwordsNotMatchLabel.Type = SimplePM.LabelType.Small;
            this.passwordsNotMatchLabel.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 409);
            this.Controls.Add(this.passwordsNotMatchLabel);
            this.Controls.Add(this.invalidPasswordLabel);
            this.Controls.Add(this.usernameNotAvailableLabel);
            this.Controls.Add(this.illegalUsernameLabel);
            this.Controls.Add(this.themedLabel3);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(100, 50);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            confirmButton.CurrentTheme = theme;
            confirmPasswordTextBox.CurrentTheme = theme;
            passwordTextBox.CurrentTheme = theme;
            usernameTextBox.CurrentTheme = theme;
            themedLabel1.CurrentTheme = theme;
            themedLabel2.CurrentTheme = theme;
            themedLabel3.CurrentTheme = theme;
            usernameNotAvailableLabel.CurrentTheme = theme;
            illegalUsernameLabel.CurrentTheme = theme;
            passwordsNotMatchLabel.CurrentTheme = theme;
            invalidPasswordLabel.CurrentTheme = theme;
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomButton confirmButton;
        private Elements.CustomTextBox confirmPasswordTextBox;
        private Elements.CustomTextBox passwordTextBox;
        private Elements.CustomTextBox usernameTextBox;
        private Elements.ThemedLabel usernameNotAvailableLabel;
        private Elements.ThemedLabel illegalUsernameLabel;
        private Elements.ThemedLabel themedLabel3;
        private Elements.ThemedLabel themedLabel2;
        private Elements.ThemedLabel themedLabel1;
        private Elements.ThemedLabel passwordsNotMatchLabel;
        private Elements.ThemedLabel invalidPasswordLabel;
    }
}