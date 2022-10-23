
using SimplePM.Themes;

namespace SimplePM.Forms
{
    partial class ChangeMasterPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeMasterPassForm));
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.currentMasterPassTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.newMasterPassTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.confirmMasterPassTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.confirmButton = new SimplePM.Forms.Elements.CustomButton();
            this.themedLabel1 = new SimplePM.Forms.Elements.ThemedLabel();
            this.passwordEmptyLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.incorrectCurrentPassLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.newPasswordInvalidLengthLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.passwordsNotMatchLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel2 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel3 = new SimplePM.Forms.Elements.ThemedLabel();
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
            // currentMasterPassTextBox
            // 
            this.currentMasterPassTextBox.BackColor = System.Drawing.Color.Black;
            this.currentMasterPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.currentMasterPassTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.currentMasterPassTextBox.BorderSize = 2;
            this.currentMasterPassTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentMasterPassTextBox.ForeColor = System.Drawing.Color.White;
            this.currentMasterPassTextBox.Location = new System.Drawing.Point(73, 79);
            this.currentMasterPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentMasterPassTextBox.Multiline = false;
            this.currentMasterPassTextBox.Name = "currentMasterPassTextBox";
            this.currentMasterPassTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.currentMasterPassTextBox.PasswordChar = true;
            this.currentMasterPassTextBox.ReadOnly = false;
            this.currentMasterPassTextBox.Size = new System.Drawing.Size(292, 33);
            this.currentMasterPassTextBox.TabIndex = 0;
            this.currentMasterPassTextBox.Texts = "";
            this.currentMasterPassTextBox.UnderlinedStyle = true;
            // 
            // newMasterPassTextBox
            // 
            this.newMasterPassTextBox.BackColor = System.Drawing.Color.Black;
            this.newMasterPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.newMasterPassTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.newMasterPassTextBox.BorderSize = 2;
            this.newMasterPassTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newMasterPassTextBox.ForeColor = System.Drawing.Color.White;
            this.newMasterPassTextBox.Location = new System.Drawing.Point(73, 169);
            this.newMasterPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newMasterPassTextBox.Multiline = false;
            this.newMasterPassTextBox.Name = "newMasterPassTextBox";
            this.newMasterPassTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.newMasterPassTextBox.PasswordChar = true;
            this.newMasterPassTextBox.ReadOnly = false;
            this.newMasterPassTextBox.Size = new System.Drawing.Size(292, 33);
            this.newMasterPassTextBox.TabIndex = 1;
            this.newMasterPassTextBox.Texts = "";
            this.newMasterPassTextBox.UnderlinedStyle = true;
            // 
            // confirmMasterPassTextBox
            // 
            this.confirmMasterPassTextBox.BackColor = System.Drawing.Color.Black;
            this.confirmMasterPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.confirmMasterPassTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.confirmMasterPassTextBox.BorderSize = 2;
            this.confirmMasterPassTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmMasterPassTextBox.ForeColor = System.Drawing.Color.White;
            this.confirmMasterPassTextBox.Location = new System.Drawing.Point(73, 259);
            this.confirmMasterPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmMasterPassTextBox.Multiline = false;
            this.confirmMasterPassTextBox.Name = "confirmMasterPassTextBox";
            this.confirmMasterPassTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.confirmMasterPassTextBox.PasswordChar = true;
            this.confirmMasterPassTextBox.ReadOnly = false;
            this.confirmMasterPassTextBox.Size = new System.Drawing.Size(292, 33);
            this.confirmMasterPassTextBox.TabIndex = 4;
            this.confirmMasterPassTextBox.Texts = "";
            this.confirmMasterPassTextBox.UnderlinedStyle = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Location = new System.Drawing.Point(152, 320);
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
            this.themedLabel1.Size = new System.Drawing.Size(235, 17);
            this.themedLabel1.TabIndex = 12;
            this.themedLabel1.Text = "Enter current master password:";
            this.themedLabel1.Type = SimplePM.LabelType.Standart;
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
            this.passwordEmptyLabel.TabIndex = 13;
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
            this.incorrectCurrentPassLabel.Location = new System.Drawing.Point(142, 115);
            this.incorrectCurrentPassLabel.Name = "incorrectCurrentPassLabel";
            this.incorrectCurrentPassLabel.Size = new System.Drawing.Size(151, 12);
            this.incorrectCurrentPassLabel.TabIndex = 14;
            this.incorrectCurrentPassLabel.Text = "Incorrect master password";
            this.incorrectCurrentPassLabel.Type = SimplePM.LabelType.Small;
            this.incorrectCurrentPassLabel.Visible = false;
            // 
            // newPasswordInvalidLengthLabel
            // 
            this.newPasswordInvalidLengthLabel.AutoSize = true;
            this.newPasswordInvalidLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordInvalidLengthLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPasswordInvalidLengthLabel.ForeColor = System.Drawing.Color.Red;
            this.newPasswordInvalidLengthLabel.Location = new System.Drawing.Point(97, 205);
            this.newPasswordInvalidLengthLabel.Name = "newPasswordInvalidLengthLabel";
            this.newPasswordInvalidLengthLabel.Size = new System.Drawing.Size(254, 12);
            this.newPasswordInvalidLengthLabel.TabIndex = 15;
            this.newPasswordInvalidLengthLabel.Text = "Password cannot have less than 8 characters";
            this.newPasswordInvalidLengthLabel.Type = SimplePM.LabelType.Small;
            this.newPasswordInvalidLengthLabel.Visible = false;
            // 
            // passwordsNotMatchLabel
            // 
            this.passwordsNotMatchLabel.AutoSize = true;
            this.passwordsNotMatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordsNotMatchLabel.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordsNotMatchLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordsNotMatchLabel.Location = new System.Drawing.Point(147, 295);
            this.passwordsNotMatchLabel.Name = "passwordsNotMatchLabel";
            this.passwordsNotMatchLabel.Size = new System.Drawing.Size(140, 12);
            this.passwordsNotMatchLabel.TabIndex = 16;
            this.passwordsNotMatchLabel.Text = "Passwords do not match";
            this.passwordsNotMatchLabel.Type = SimplePM.LabelType.Small;
            this.passwordsNotMatchLabel.Visible = false;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel2.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(75, 149);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(212, 17);
            this.themedLabel2.TabIndex = 17;
            this.themedLabel2.Text = "Enter new master password:";
            this.themedLabel2.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel3
            // 
            this.themedLabel3.AutoSize = true;
            this.themedLabel3.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel3.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel3.ForeColor = System.Drawing.Color.White;
            this.themedLabel3.Location = new System.Drawing.Point(73, 239);
            this.themedLabel3.Name = "themedLabel3";
            this.themedLabel3.Size = new System.Drawing.Size(229, 17);
            this.themedLabel3.TabIndex = 18;
            this.themedLabel3.Text = "Confirm new master password:";
            this.themedLabel3.Type = SimplePM.LabelType.Standart;
            // 
            // ChangeMasterPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 399);
            this.Controls.Add(this.themedLabel3);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.passwordsNotMatchLabel);
            this.Controls.Add(this.newPasswordInvalidLengthLabel);
            this.Controls.Add(this.incorrectCurrentPassLabel);
            this.Controls.Add(this.passwordEmptyLabel);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.confirmMasterPassTextBox);
            this.Controls.Add(this.newMasterPassTextBox);
            this.Controls.Add(this.currentMasterPassTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "ChangeMasterPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            currentMasterPassTextBox.CurrentTheme = theme;
            newMasterPassTextBox.CurrentTheme = theme;
            confirmMasterPassTextBox.CurrentTheme = theme;
            confirmButton.CurrentTheme = theme;
            themedLabel1.CurrentTheme = theme;
            themedLabel2.CurrentTheme = theme;
            themedLabel3.CurrentTheme = theme;
            passwordEmptyLabel.CurrentTheme = theme;
            passwordsNotMatchLabel.CurrentTheme = theme;
            newPasswordInvalidLengthLabel.CurrentTheme = theme;
            incorrectCurrentPassLabel.CurrentTheme = theme;
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomTextBox currentMasterPassTextBox;
        private Elements.CustomTextBox newMasterPassTextBox;
        private Elements.CustomTextBox confirmMasterPassTextBox;
        private SimplePM.Forms.Elements.CustomButton confirmButton;
        private Elements.ThemedLabel passwordEmptyLabel;
        private Elements.ThemedLabel themedLabel1;
        private Elements.ThemedLabel newPasswordInvalidLengthLabel;
        private Elements.ThemedLabel incorrectCurrentPassLabel;
        private Elements.ThemedLabel themedLabel3;
        private Elements.ThemedLabel themedLabel2;
        private Elements.ThemedLabel passwordsNotMatchLabel;
    }
}