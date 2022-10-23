
using SimplePM.Themes;
using System.Collections;
using System.IO;

namespace SimplePM.Forms
{
    partial class PassGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassGeneratorForm));
            this.confirmButton = new SimplePM.Forms.Elements.CustomButton();
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.lengthComboBox = new SimplePM.Forms.Elements.CustomComboBox();
            this.generatedPassTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.themedLabel1 = new SimplePM.Forms.Elements.ThemedLabel();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.confirmButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Location = new System.Drawing.Point(204, 260);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 31);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Generate";
            this.confirmButton.Click += new System.EventHandler(this.customButton1_Click);
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
            // lengthComboBox
            // 
            this.lengthComboBox.BackColor = System.Drawing.Color.Black;
            this.lengthComboBox.BorderColor = System.Drawing.Color.White;
            this.lengthComboBox.BorderSize = 1;
            this.lengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.lengthComboBox.ForeColor = System.Drawing.Color.White;
            this.lengthComboBox.IconColor = System.Drawing.Color.White;
            this.lengthComboBox.ListBackColor = System.Drawing.Color.Black;
            this.lengthComboBox.ListForeColor = System.Drawing.Color.White;
            this.lengthComboBox.Location = new System.Drawing.Point(257, 92);
            this.lengthComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lengthComboBox.MinimumSize = new System.Drawing.Size(233, 35);
            this.lengthComboBox.Name = "lengthComboBox";
            this.lengthComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.lengthComboBox.Size = new System.Drawing.Size(233, 35);
            this.lengthComboBox.TabIndex = 1;
            this.lengthComboBox.Texts = "";
            // 
            // generatedPassTextBox
            // 
            this.generatedPassTextBox.BackColor = System.Drawing.Color.Black;
            this.generatedPassTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.generatedPassTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.generatedPassTextBox.BorderSize = 2;
            this.generatedPassTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generatedPassTextBox.ForeColor = System.Drawing.Color.White;
            this.generatedPassTextBox.Location = new System.Drawing.Point(50, 180);
            this.generatedPassTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generatedPassTextBox.Multiline = false;
            this.generatedPassTextBox.Name = "generatedPassTextBox";
            this.generatedPassTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.generatedPassTextBox.PasswordChar = false;
            this.generatedPassTextBox.ReadOnly = true;
            this.generatedPassTextBox.Size = new System.Drawing.Size(440, 33);
            this.generatedPassTextBox.TabIndex = 2;
            this.generatedPassTextBox.Texts = "";
            this.generatedPassTextBox.UnderlinedStyle = true;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(50, 101);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(191, 26);
            this.themedLabel1.TabIndex = 3;
            this.themedLabel1.Text = "Password length";
            this.themedLabel1.Type = SimplePM.LabelType.Large;
            // 
            // PassGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 339);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.generatedPassTextBox);
            this.Controls.Add(this.lengthComboBox);
            this.Controls.Add(this.confirmButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "PassGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            confirmButton.CurrentTheme = theme;
            generatedPassTextBox.CurrentTheme = theme;
            lengthComboBox.CurrentTheme = theme;
            themedLabel1.CurrentTheme = theme;
        }

        private void FillComboBox()
        {
            for (int i = 8; i < 128; i++)
            {
                lengthComboBox.Items.Add(i);
            }
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomButton confirmButton;
        private Elements.CustomTextBox generatedPassTextBox;
        private Elements.CustomComboBox lengthComboBox;
        private Elements.ThemedLabel themedLabel1;
    }
}