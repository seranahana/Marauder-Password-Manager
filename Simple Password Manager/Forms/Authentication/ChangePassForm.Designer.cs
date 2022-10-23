
using SimplePM.Themes;

namespace SimplePM.Forms
{
    partial class ChangePassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassForm));
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.currentPassTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.newPassTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.confirmPassTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.confirmButton = new SimplePM.Forms.Elements.CustomButton();
            this.themedLabel1 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel2 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel3 = new SimplePM.Forms.Elements.ThemedLabel();
            this.passwordEmptyLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.incorrectCurrentPassLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.invalidNewPasswordLabel = new SimplePM.Forms.Elements.ThemedLabel();
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
            // currentPassTextBox
            // 
            this.currentPassTextBox.BackColor = System.Drawing.Color.Black;
            this.currentPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.currentPassTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.currentPassTextBox.BorderSize = 2;
            this.currentPassTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentPassTextBox.ForeColor = System.Drawing.Color.White;
            this.currentPassTextBox.Location = new System.Drawing.Point(73, 79);
            this.currentPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentPassTextBox.Multiline = false;
            this.currentPassTextBox.Name = "currentPassTextBox";
            this.currentPassTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.currentPassTextBox.PasswordChar = true;
            this.currentPassTextBox.ReadOnly = false;
            this.currentPassTextBox.Size = new System.Drawing.Size(292, 33);
            this.currentPassTextBox.TabIndex = 0;
            this.currentPassTextBox.Texts = "";
            this.currentPassTextBox.UnderlinedStyle = true;
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.BackColor = System.Drawing.Color.Black;
            this.newPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.newPassTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.newPassTextBox.BorderSize = 2;
            this.newPassTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPassTextBox.ForeColor = System.Drawing.Color.White;
            this.newPassTextBox.Location = new System.Drawing.Point(73, 169);
            this.newPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newPassTextBox.Multiline = false;
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.newPassTextBox.PasswordChar = true;
            this.newPassTextBox.ReadOnly = false;
            this.newPassTextBox.Size = new System.Drawing.Size(292, 33);
            this.newPassTextBox.TabIndex = 1;
            this.newPassTextBox.Texts = "";
            this.newPassTextBox.UnderlinedStyle = true;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.BackColor = System.Drawing.Color.Black;
            this.confirmPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.confirmPassTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.confirmPassTextBox.BorderSize = 2;
            this.confirmPassTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPassTextBox.ForeColor = System.Drawing.Color.White;
            this.confirmPassTextBox.Location = new System.Drawing.Point(73, 269);
            this.confirmPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmPassTextBox.Multiline = false;
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.confirmPassTextBox.PasswordChar = true;
            this.confirmPassTextBox.ReadOnly = false;
            this.confirmPassTextBox.Size = new System.Drawing.Size(292, 33);
            this.confirmPassTextBox.TabIndex = 4;
            this.confirmPassTextBox.Texts = "";
            this.confirmPassTextBox.UnderlinedStyle = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Location = new System.Drawing.Point(152, 330);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 31);
            this.confirmButton.TabIndex = 10;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel1.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(73, 59);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(181, 17);
            this.themedLabel1.TabIndex = 12;
            this.themedLabel1.Text = "Enter current password:";
            this.themedLabel1.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel2.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(73, 149);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(158, 17);
            this.themedLabel2.TabIndex = 13;
            this.themedLabel2.Text = "Enter new password:";
            this.themedLabel2.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel3
            // 
            this.themedLabel3.AutoSize = true;
            this.themedLabel3.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel3.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel3.ForeColor = System.Drawing.Color.White;
            this.themedLabel3.Location = new System.Drawing.Point(73, 249);
            this.themedLabel3.Name = "themedLabel3";
            this.themedLabel3.Size = new System.Drawing.Size(175, 17);
            this.themedLabel3.TabIndex = 14;
            this.themedLabel3.Text = "Confirm new password:";
            this.themedLabel3.Type = SimplePM.LabelType.Standart;
            // 
            // passwordEmptyLabel
            // 
            this.passwordEmptyLabel.AutoSize = true;
            this.passwordEmptyLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordEmptyLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordEmptyLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordEmptyLabel.Location = new System.Drawing.Point(153, 115);
            this.passwordEmptyLabel.Name = "passwordEmptyLabel";
            this.passwordEmptyLabel.Size = new System.Drawing.Size(129, 12);
            this.passwordEmptyLabel.TabIndex = 15;
            this.passwordEmptyLabel.Text = "Field cannot be empty";
            this.passwordEmptyLabel.Type = SimplePM.LabelType.Small;
            this.passwordEmptyLabel.Visible = false;
            // 
            // incorrectCurrentPassLabel
            // 
            this.incorrectCurrentPassLabel.AutoSize = true;
            this.incorrectCurrentPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectCurrentPassLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incorrectCurrentPassLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectCurrentPassLabel.Location = new System.Drawing.Point(163, 115);
            this.incorrectCurrentPassLabel.Name = "incorrectCurrentPassLabel";
            this.incorrectCurrentPassLabel.Size = new System.Drawing.Size(108, 12);
            this.incorrectCurrentPassLabel.TabIndex = 16;
            this.incorrectCurrentPassLabel.Text = "Incorrect password";
            this.incorrectCurrentPassLabel.Type = SimplePM.LabelType.Small;
            this.incorrectCurrentPassLabel.Visible = false;
            // 
            // invalidNewPasswordLabel
            // 
            this.invalidNewPasswordLabel.AutoSize = true;
            this.invalidNewPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.invalidNewPasswordLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invalidNewPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidNewPasswordLabel.Location = new System.Drawing.Point(78, 205);
            this.invalidNewPasswordLabel.Name = "invalidNewPasswordLabel";
            this.invalidNewPasswordLabel.Size = new System.Drawing.Size(279, 36);
            this.invalidNewPasswordLabel.TabIndex = 17;
            this.invalidNewPasswordLabel.Text = "Password cannot have less than 8 characters\nand should contain at least one upper" +
    "case letter,\none number and one special symbol";
            this.invalidNewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.invalidNewPasswordLabel.Type = SimplePM.LabelType.Small;
            this.invalidNewPasswordLabel.Visible = false;
            // 
            // passwordsNotMatchLabel
            // 
            this.passwordsNotMatchLabel.AutoSize = true;
            this.passwordsNotMatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordsNotMatchLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordsNotMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordsNotMatchLabel.Location = new System.Drawing.Point(147, 303);
            this.passwordsNotMatchLabel.Name = "passwordsNotMatchLabel";
            this.passwordsNotMatchLabel.Size = new System.Drawing.Size(140, 12);
            this.passwordsNotMatchLabel.TabIndex = 18;
            this.passwordsNotMatchLabel.Text = "Passwords do not match";
            this.passwordsNotMatchLabel.Type = SimplePM.LabelType.Small;
            this.passwordsNotMatchLabel.Visible = false;
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 409);
            this.Controls.Add(this.passwordsNotMatchLabel);
            this.Controls.Add(this.invalidNewPasswordLabel);
            this.Controls.Add(this.incorrectCurrentPassLabel);
            this.Controls.Add(this.passwordEmptyLabel);
            this.Controls.Add(this.themedLabel3);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.currentPassTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            currentPassTextBox.CurrentTheme = theme;
            newPassTextBox.CurrentTheme = theme;
            confirmPassTextBox.CurrentTheme = theme;
            confirmButton.CurrentTheme = theme;
            themedLabel1.CurrentTheme = theme;
            themedLabel2.CurrentTheme = theme;
            themedLabel3.CurrentTheme = theme;
            incorrectCurrentPassLabel.CurrentTheme = theme;
            passwordEmptyLabel.CurrentTheme = theme;
            passwordsNotMatchLabel.CurrentTheme = theme;
            invalidNewPasswordLabel.CurrentTheme = theme;
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomTextBox currentPassTextBox;
        private Elements.CustomTextBox newPassTextBox;
        private Elements.CustomTextBox confirmPassTextBox;
        private SimplePM.Forms.Elements.CustomButton confirmButton;
        private Elements.ThemedLabel themedLabel2;
        private Elements.ThemedLabel themedLabel1;
        private Elements.ThemedLabel incorrectCurrentPassLabel;
        private Elements.ThemedLabel passwordEmptyLabel;
        private Elements.ThemedLabel themedLabel3;
        private Elements.ThemedLabel passwordsNotMatchLabel;
        private Elements.ThemedLabel invalidNewPasswordLabel;
    }
}