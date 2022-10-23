
using SimplePM.Themes;

namespace SimplePM.Forms
{
    partial class WorkWithEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkWithEntryForm));
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.addEntryButton = new SimplePM.Forms.Elements.CustomButton();
            this.nameTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.urlTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.usernameTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.passwordTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.themedLabel1 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel2 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel3 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel4 = new SimplePM.Forms.Elements.ThemedLabel();
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
            // addEntryButton
            // 
            this.addEntryButton.Alignment = System.Drawing.StringAlignment.Center;
            this.addEntryButton.BackColor = System.Drawing.Color.Black;
            this.addEntryButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEntryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addEntryButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.addEntryButton.Location = new System.Drawing.Point(252, 260);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(130, 31);
            this.addEntryButton.TabIndex = 4;
            this.addEntryButton.Text = "Add entry";
            this.addEntryButton.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.Black;
            this.nameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.nameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTextBox.BorderSize = 2;
            this.nameTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(15, 91);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.nameTextBox.PasswordChar = false;
            this.nameTextBox.ReadOnly = false;
            this.nameTextBox.Size = new System.Drawing.Size(280, 33);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.Texts = "";
            this.nameTextBox.UnderlinedStyle = true;
            // 
            // urlTextBox
            // 
            this.urlTextBox.BackColor = System.Drawing.Color.Black;
            this.urlTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.urlTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.urlTextBox.BorderSize = 2;
            this.urlTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urlTextBox.ForeColor = System.Drawing.Color.White;
            this.urlTextBox.Location = new System.Drawing.Point(15, 168);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.urlTextBox.Multiline = false;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.urlTextBox.PasswordChar = false;
            this.urlTextBox.ReadOnly = false;
            this.urlTextBox.Size = new System.Drawing.Size(280, 33);
            this.urlTextBox.TabIndex = 6;
            this.urlTextBox.Texts = "";
            this.urlTextBox.UnderlinedStyle = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.Black;
            this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.usernameTextBox.BorderSize = 2;
            this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(325, 91);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.ReadOnly = false;
            this.usernameTextBox.Size = new System.Drawing.Size(280, 33);
            this.usernameTextBox.TabIndex = 7;
            this.usernameTextBox.Texts = "";
            this.usernameTextBox.UnderlinedStyle = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Black;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(325, 168);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.ReadOnly = false;
            this.passwordTextBox.Size = new System.Drawing.Size(280, 33);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel1.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(15, 71);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(47, 17);
            this.themedLabel1.TabIndex = 13;
            this.themedLabel1.Text = "Name";
            this.themedLabel1.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel2.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(325, 71);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(46, 17);
            this.themedLabel2.TabIndex = 14;
            this.themedLabel2.Text = "Login";
            this.themedLabel2.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel3
            // 
            this.themedLabel3.AutoSize = true;
            this.themedLabel3.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel3.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel3.ForeColor = System.Drawing.Color.White;
            this.themedLabel3.Location = new System.Drawing.Point(15, 148);
            this.themedLabel3.Name = "themedLabel3";
            this.themedLabel3.Size = new System.Drawing.Size(193, 17);
            this.themedLabel3.TabIndex = 15;
            this.themedLabel3.Text = "URL (http://example.com)";
            this.themedLabel3.Type = SimplePM.LabelType.Standart;
            // 
            // themedLabel4
            // 
            this.themedLabel4.AutoSize = true;
            this.themedLabel4.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel4.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel4.ForeColor = System.Drawing.Color.White;
            this.themedLabel4.Location = new System.Drawing.Point(325, 148);
            this.themedLabel4.Name = "themedLabel4";
            this.themedLabel4.Size = new System.Drawing.Size(75, 17);
            this.themedLabel4.TabIndex = 16;
            this.themedLabel4.Text = "Password";
            this.themedLabel4.Type = SimplePM.LabelType.Standart;
            // 
            // WorkWithEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 339);
            this.Controls.Add(this.themedLabel4);
            this.Controls.Add(this.themedLabel3);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addEntryButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "WorkWithEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            addEntryButton.CurrentTheme = theme;
            passwordTextBox.CurrentTheme = theme;
            usernameTextBox.CurrentTheme = theme;
            urlTextBox.CurrentTheme = theme;
            nameTextBox.CurrentTheme = theme;
            themedLabel1.CurrentTheme = theme;
            themedLabel2.CurrentTheme = theme;
            themedLabel3.CurrentTheme = theme;
            themedLabel4.CurrentTheme = theme;
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomButton addEntryButton;
        private Elements.CustomTextBox passwordTextBox;
        private Elements.CustomTextBox usernameTextBox;
        private Elements.CustomTextBox urlTextBox;
        private Elements.CustomTextBox nameTextBox;
        private Elements.ThemedLabel themedLabel4;
        private Elements.ThemedLabel themedLabel3;
        private Elements.ThemedLabel themedLabel2;
        private Elements.ThemedLabel themedLabel1;
    }
}