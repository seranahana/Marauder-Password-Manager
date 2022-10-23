using SimplePM.Themes;
using System.Collections.Generic;

namespace SimplePM.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.startupCheckBox = new SimplePM.Forms.Elements.CustomCheckBox();
            this.themedLabel1 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themedLabel2 = new SimplePM.Forms.Elements.ThemedLabel();
            this.themesComboBox = new SimplePM.Forms.Elements.CustomComboBox();
            this.confirmButton = new SimplePM.Forms.Elements.CustomButton();
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
            // startupCheckBox
            // 
            this.startupCheckBox.BackColor = System.Drawing.Color.Black;
            this.startupCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startupCheckBox.BorderSize = 1;
            this.startupCheckBox.Checked = false;
            this.startupCheckBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startupCheckBox.Location = new System.Drawing.Point(234, 148);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Padding = new System.Windows.Forms.Padding(1);
            this.startupCheckBox.Size = new System.Drawing.Size(20, 20);
            this.startupCheckBox.TabIndex = 0;
            // 
            // themedLabel1
            // 
            this.themedLabel1.AutoSize = true;
            this.themedLabel1.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel1.ForeColor = System.Drawing.Color.White;
            this.themedLabel1.Location = new System.Drawing.Point(40, 150);
            this.themedLabel1.Name = "themedLabel1";
            this.themedLabel1.Size = new System.Drawing.Size(188, 18);
            this.themedLabel1.TabIndex = 1;
            this.themedLabel1.Text = "Auto startup with OS:";
            this.themedLabel1.Type = SimplePM.LabelType.Header;
            // 
            // themedLabel2
            // 
            this.themedLabel2.AutoSize = true;
            this.themedLabel2.BackColor = System.Drawing.Color.Transparent;
            this.themedLabel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.themedLabel2.ForeColor = System.Drawing.Color.White;
            this.themedLabel2.Location = new System.Drawing.Point(40, 100);
            this.themedLabel2.Name = "themedLabel2";
            this.themedLabel2.Size = new System.Drawing.Size(123, 18);
            this.themedLabel2.TabIndex = 2;
            this.themedLabel2.Text = "Visual theme:";
            this.themedLabel2.Type = SimplePM.LabelType.Header;
            // 
            // themesComboBox
            // 
            this.themesComboBox.BackColor = System.Drawing.Color.Black;
            this.themesComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.themesComboBox.BorderSize = 1;
            this.themesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.themesComboBox.ForeColor = System.Drawing.Color.White;
            this.themesComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.themesComboBox.ListBackColor = System.Drawing.Color.Black;
            this.themesComboBox.ListForeColor = System.Drawing.Color.White;
            this.themesComboBox.Location = new System.Drawing.Point(169, 88);
            this.themesComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.themesComboBox.Name = "themesComboBox";
            this.themesComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.themesComboBox.Size = new System.Drawing.Size(215, 30);
            this.themesComboBox.TabIndex = 3;
            this.themesComboBox.Texts = "";
            this.themesComboBox.OnSelectedIndexChanged += new System.EventHandler(this.themesComboBox_OnSelectedIndexChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Alignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.confirmButton.Location = new System.Drawing.Point(152, 210);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 31);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 289);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.themesComboBox);
            this.Controls.Add(this.themedLabel2);
            this.Controls.Add(this.themedLabel1);
            this.Controls.Add(this.startupCheckBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(100, 50);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ApplyTheme(Theme theme)
        {
            marauderFormStyle1.CurrentTheme = theme;
            startupCheckBox.CurrentTheme = theme;
            themedLabel1.CurrentTheme = theme;
            themedLabel2.CurrentTheme = theme;
            themesComboBox.CurrentTheme = theme;
            confirmButton.CurrentTheme = theme;
        }

        private void FillThemesComboBox(List<string> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                string value = data[i];
                themesComboBox.Items.Add(value);
                if (value == SettingsProcessor.GetCurrentTheme().Name)
                {
                    themesComboBox.SelectedIndex = i;
                }
            }
        }

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomCheckBox startupCheckBox;
        private Elements.ThemedLabel themedLabel2;
        private Elements.ThemedLabel themedLabel1;
        private Elements.CustomComboBox themesComboBox;
        private Elements.CustomButton confirmButton;
    }
}