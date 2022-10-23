
using SimplePM.Themes;

namespace SimplePM.Forms
{
    partial class FirstStartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstStartupForm));
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.signInButton = new SimplePM.Forms.Elements.CustomButton();
            this.signUpButton = new SimplePM.Forms.Elements.CustomButton();
            this.greetingsLabel = new SimplePM.Forms.Elements.ThemedLabel();
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
            this.marauderFormStyle1.ShowMaximizeButton = true;
            this.marauderFormStyle1.ShowMinimizeButton = true;
            // 
            // signInButton
            // 
            this.signInButton.Alignment = System.Drawing.StringAlignment.Center;
            this.signInButton.BackColor = System.Drawing.Color.Black;
            this.signInButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signInButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.signInButton.Location = new System.Drawing.Point(177, 160);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(130, 31);
            this.signInButton.TabIndex = 12;
            this.signInButton.Text = "Sign In";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Alignment = System.Drawing.StringAlignment.Center;
            this.signUpButton.BackColor = System.Drawing.Color.Black;
            this.signUpButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signUpButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.signUpButton.Location = new System.Drawing.Point(177, 205);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(130, 31);
            this.signUpButton.TabIndex = 13;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingsLabel.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greetingsLabel.ForeColor = System.Drawing.Color.White;
            this.greetingsLabel.Location = new System.Drawing.Point(26, 110);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(432, 17);
            this.greetingsLabel.TabIndex = 14;
            this.greetingsLabel.Text = "Have existing account? Sign in or sign up to create new one";
            this.greetingsLabel.Type = SimplePM.LabelType.Standart;
            // 
            // FirstStartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 339);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.signInButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "FirstStartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            signInButton.CurrentTheme = theme;
            signInButton.CurrentTheme = theme;
            greetingsLabel.CurrentTheme = theme;
        }

        private void SetWindowHeader(string headerText)
        {
            this.Text = headerText;
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomButton signUpButton;
        private Elements.CustomButton signInButton;
        private Elements.ThemedLabel greetingsLabel;
    }
}