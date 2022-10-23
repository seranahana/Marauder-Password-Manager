using SimplePM.Themes;

namespace SimplePM.Forms
{
    partial class IdentityConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentityConfirmationForm));
            this.confirmButton = new SimplePM.Forms.Elements.CustomButton();
            this.loginTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.passwordTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.confirmIdentityLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.loginLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.passwordLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.loginEmptyLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.loginNotFoundLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.invalidPasswordLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.passwordEmptyLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Location = new System.Drawing.Point(152, 310);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 31);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.Black;
            this.loginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.loginTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.loginTextBox.BorderSize = 2;
            this.loginTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox.ForeColor = System.Drawing.Color.White;
            this.loginTextBox.Location = new System.Drawing.Point(71, 158);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginTextBox.Multiline = false;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.loginTextBox.PasswordChar = false;
            this.loginTextBox.ReadOnly = false;
            this.loginTextBox.Size = new System.Drawing.Size(292, 33);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.Texts = "";
            this.loginTextBox.UnderlinedStyle = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Black;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(71, 232);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(292, 33);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
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
            this.marauderFormStyle1.ShowMaximizeButton = true;
            this.marauderFormStyle1.ShowMinimizeButton = true;
            // 
            // confirmIdentityLabel
            // 
            this.confirmIdentityLabel.AutoSize = true;
            this.confirmIdentityLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmIdentityLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmIdentityLabel.ForeColor = System.Drawing.Color.White;
            this.confirmIdentityLabel.Location = new System.Drawing.Point(49, 80);
            this.confirmIdentityLabel.Name = "confirmIdentityLabel";
            this.confirmIdentityLabel.Size = new System.Drawing.Size(337, 18);
            this.confirmIdentityLabel.TabIndex = 23;
            this.confirmIdentityLabel.Text = "Please, confirm your identity to proceed";
            this.confirmIdentityLabel.Type = SimplePM.LabelType.Header;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(71, 138);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(163, 17);
            this.loginLabel.TabIndex = 24;
            this.loginLabel.Text = "Enter your username:";
            this.loginLabel.Type = SimplePM.LabelType.Standart;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(71, 212);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(125, 17);
            this.passwordLabel.TabIndex = 25;
            this.passwordLabel.Text = "Enter password:";
            this.passwordLabel.Type = SimplePM.LabelType.Standart;
            // 
            // loginEmptyLabel
            // 
            this.loginEmptyLabel.AutoSize = true;
            this.loginEmptyLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginEmptyLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginEmptyLabel.ForeColor = System.Drawing.Color.Red;
            this.loginEmptyLabel.Location = new System.Drawing.Point(153, 194);
            this.loginEmptyLabel.Name = "loginEmptyLabel";
            this.loginEmptyLabel.Size = new System.Drawing.Size(129, 12);
            this.loginEmptyLabel.TabIndex = 26;
            this.loginEmptyLabel.Text = "Field cannot be empty";
            this.loginEmptyLabel.Type = SimplePM.LabelType.Small;
            this.loginEmptyLabel.Visible = false;
            // 
            // loginNotFoundLabel
            // 
            this.loginNotFoundLabel.AutoSize = true;
            this.loginNotFoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginNotFoundLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginNotFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.loginNotFoundLabel.Location = new System.Drawing.Point(95, 194);
            this.loginNotFoundLabel.Name = "loginNotFoundLabel";
            this.loginNotFoundLabel.Size = new System.Drawing.Size(245, 12);
            this.loginNotFoundLabel.TabIndex = 27;
            this.loginNotFoundLabel.Text = "Account with such username does not exist";
            this.loginNotFoundLabel.Type = SimplePM.LabelType.Small;
            this.loginNotFoundLabel.Visible = false;
            // 
            // invalidPasswordLabel
            // 
            this.invalidPasswordLabel.AutoSize = true;
            this.invalidPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidPasswordLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalidPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidPasswordLabel.Location = new System.Drawing.Point(168, 268);
            this.invalidPasswordLabel.Name = "invalidPasswordLabel";
            this.invalidPasswordLabel.Size = new System.Drawing.Size(98, 12);
            this.invalidPasswordLabel.TabIndex = 28;
            this.invalidPasswordLabel.Text = "Invalid password";
            this.invalidPasswordLabel.Type = SimplePM.LabelType.Small;
            this.invalidPasswordLabel.Visible = false;
            // 
            // passwordEmptyLabel
            // 
            this.passwordEmptyLabel.AutoSize = true;
            this.passwordEmptyLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordEmptyLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordEmptyLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordEmptyLabel.Location = new System.Drawing.Point(153, 268);
            this.passwordEmptyLabel.Name = "passwordEmptyLabel";
            this.passwordEmptyLabel.Size = new System.Drawing.Size(129, 12);
            this.passwordEmptyLabel.TabIndex = 29;
            this.passwordEmptyLabel.Text = "Field cannot be empty";
            this.passwordEmptyLabel.Type = SimplePM.LabelType.Small;
            this.passwordEmptyLabel.Visible = false;
            // 
            // IdentityConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 389);
            this.Controls.Add(this.passwordEmptyLabel);
            this.Controls.Add(this.invalidPasswordLabel);
            this.Controls.Add(this.loginNotFoundLabel);
            this.Controls.Add(this.loginEmptyLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.confirmIdentityLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "IdentityConfirmationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            confirmButton.CurrentTheme = theme;
            loginTextBox.CurrentTheme = theme;
            passwordTextBox.CurrentTheme = theme;
            passwordEmptyLabel.CurrentTheme = theme;
            invalidPasswordLabel.CurrentTheme = theme;
            loginNotFoundLabel.CurrentTheme = theme;
            loginEmptyLabel.CurrentTheme = theme;
            passwordLabel.CurrentTheme = theme;
            loginLabel.CurrentTheme = theme;
            confirmIdentityLabel.CurrentTheme = theme;
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomButton confirmButton;
        private Elements.CustomTextBox loginTextBox;
        private Elements.CustomTextBox passwordTextBox;
        private Elements.ThemedLabel passwordEmptyLabel;
        private Elements.ThemedLabel invalidPasswordLabel;
        private Elements.ThemedLabel loginNotFoundLabel;
        private Elements.ThemedLabel loginEmptyLabel;
        private Elements.ThemedLabel passwordLabel;
        private Elements.ThemedLabel loginLabel;
        private Elements.ThemedLabel confirmIdentityLabel;
    }
}