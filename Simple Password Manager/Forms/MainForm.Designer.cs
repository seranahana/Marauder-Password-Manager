using SimplePM.Forms.Elements;
using SimplePM.Library.Models;
using SimplePM.Themes;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SimplePM.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.marauderFormStyle1 = new SimplePM.Forms.Elements.MarauderFormStyle(this.components);
            this.addEntryButton = new SimplePM.Forms.Elements.CustomButton();
            this.entriesPanel = new System.Windows.Forms.Panel();
            this.signedManageAccountPanel = new System.Windows.Forms.Panel();
            this.deleteAccountButton = new SimplePM.Forms.Elements.CustomButton();
            this.signOutButton = new SimplePM.Forms.Elements.CustomButton();
            this.changeMasterPasswordButton = new SimplePM.Forms.Elements.CustomButton();
            this.changePasswordButton = new SimplePM.Forms.Elements.CustomButton();
            this.unsignedManageAccountPanel = new System.Windows.Forms.Panel();
            this.signUpButton = new SimplePM.Forms.Elements.CustomButton();
            this.signInButton = new SimplePM.Forms.Elements.CustomButton();
            this.entryInfoPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.loginLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.passVisibilityButton = new System.Windows.Forms.Button();
            this.entryTitlePanel = new System.Windows.Forms.Panel();
            this.entryNameLabel = new SimplePM.Forms.Elements.ThemedLabel();
            this.deleteEntryButton = new System.Windows.Forms.Button();
            this.editEntryButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.loginTextBox = new SimplePM.Forms.Elements.CustomTextBox();
            this.generatePassButton = new SimplePM.Forms.Elements.CustomButton();
            this.minimizeButton = new SimplePM.Forms.Elements.CustomButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.accountButton = new SimplePM.Forms.Elements.CustomButton();
            this.settingsButton = new SimplePM.Forms.Elements.CustomButton();
            this.signedManageAccountPanel.SuspendLayout();
            this.unsignedManageAccountPanel.SuspendLayout();
            this.entryInfoPanel.SuspendLayout();
            this.entryTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // marauderFormStyle1
            // 
            this.marauderFormStyle1.AllowUserResize = true;
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
            // addEntryButton
            // 
            this.addEntryButton.Alignment = System.Drawing.StringAlignment.Near;
            this.addEntryButton.BackColor = System.Drawing.Color.Black;
            this.addEntryButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEntryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addEntryButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.addEntryButton.Location = new System.Drawing.Point(16, 61);
            this.addEntryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(226, 58);
            this.addEntryButton.TabIndex = 4;
            this.addEntryButton.Text = "Add new entry";
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click);
            // 
            // entriesPanel
            // 
            this.entriesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.entriesPanel.AutoScroll = true;
            this.entriesPanel.Location = new System.Drawing.Point(250, 61);
            this.entriesPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entriesPanel.Name = "entriesPanel";
            this.entriesPanel.Size = new System.Drawing.Size(316, 502);
            this.entriesPanel.TabIndex = 5;
            this.entriesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.entriesPanel_Paint);
            // 
            // signedManageAccountPanel
            // 
            this.signedManageAccountPanel.Controls.Add(this.deleteAccountButton);
            this.signedManageAccountPanel.Controls.Add(this.signOutButton);
            this.signedManageAccountPanel.Controls.Add(this.changeMasterPasswordButton);
            this.signedManageAccountPanel.Controls.Add(this.changePasswordButton);
            this.signedManageAccountPanel.Location = new System.Drawing.Point(242, 192);
            this.signedManageAccountPanel.Name = "signedManageAccountPanel";
            this.signedManageAccountPanel.Size = new System.Drawing.Size(297, 262);
            this.signedManageAccountPanel.TabIndex = 2;
            this.signedManageAccountPanel.Visible = false;
            this.signedManageAccountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signedManageAccountPanel_Paint);
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.Alignment = System.Drawing.StringAlignment.Center;
            this.deleteAccountButton.BackColor = System.Drawing.Color.Black;
            this.deleteAccountButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteAccountButton.ForeColor = System.Drawing.Color.Red;
            this.deleteAccountButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.deleteAccountButton.Location = new System.Drawing.Point(3, 198);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(291, 58);
            this.deleteAccountButton.TabIndex = 8;
            this.deleteAccountButton.Text = "Delete Account";
            this.deleteAccountButton.Click += new System.EventHandler(this.deleteAccountButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Alignment = System.Drawing.StringAlignment.Center;
            this.signOutButton.BackColor = System.Drawing.Color.Black;
            this.signOutButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signOutButton.ForeColor = System.Drawing.Color.Red;
            this.signOutButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.signOutButton.Location = new System.Drawing.Point(3, 134);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(291, 58);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // changeMasterPasswordButton
            // 
            this.changeMasterPasswordButton.Alignment = System.Drawing.StringAlignment.Center;
            this.changeMasterPasswordButton.BackColor = System.Drawing.Color.Black;
            this.changeMasterPasswordButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeMasterPasswordButton.ForeColor = System.Drawing.Color.White;
            this.changeMasterPasswordButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.changeMasterPasswordButton.Location = new System.Drawing.Point(3, 70);
            this.changeMasterPasswordButton.Name = "changeMasterPasswordButton";
            this.changeMasterPasswordButton.Size = new System.Drawing.Size(291, 58);
            this.changeMasterPasswordButton.TabIndex = 6;
            this.changeMasterPasswordButton.Text = "Change master password";
            this.changeMasterPasswordButton.Click += new System.EventHandler(this.changeMasterPasswordButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Alignment = System.Drawing.StringAlignment.Center;
            this.changePasswordButton.BackColor = System.Drawing.Color.Black;
            this.changePasswordButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.changePasswordButton.Location = new System.Drawing.Point(3, 6);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(291, 58);
            this.changePasswordButton.TabIndex = 5;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // unsignedManageAccountPanel
            // 
            this.unsignedManageAccountPanel.Controls.Add(this.signUpButton);
            this.unsignedManageAccountPanel.Controls.Add(this.signInButton);
            this.unsignedManageAccountPanel.Location = new System.Drawing.Point(242, 192);
            this.unsignedManageAccountPanel.Name = "unsignedManageAccountPanel";
            this.unsignedManageAccountPanel.Size = new System.Drawing.Size(297, 134);
            this.unsignedManageAccountPanel.TabIndex = 0;
            this.unsignedManageAccountPanel.Visible = false;
            this.unsignedManageAccountPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.unsignedManageAccountPanel_Paint);
            // 
            // signUpButton
            // 
            this.signUpButton.Alignment = System.Drawing.StringAlignment.Center;
            this.signUpButton.BackColor = System.Drawing.Color.Black;
            this.signUpButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.signUpButton.Location = new System.Drawing.Point(3, 70);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(291, 58);
            this.signUpButton.TabIndex = 3;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.Alignment = System.Drawing.StringAlignment.Center;
            this.signInButton.BackColor = System.Drawing.Color.Black;
            this.signInButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.signInButton.Location = new System.Drawing.Point(3, 6);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(291, 58);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Sign In";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // entryInfoPanel
            // 
            this.entryInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryInfoPanel.Controls.Add(this.passwordLabel);
            this.entryInfoPanel.Controls.Add(this.loginLabel);
            this.entryInfoPanel.Controls.Add(this.passVisibilityButton);
            this.entryInfoPanel.Controls.Add(this.entryTitlePanel);
            this.entryInfoPanel.Controls.Add(this.passwordTextBox);
            this.entryInfoPanel.Controls.Add(this.loginTextBox);
            this.entryInfoPanel.Location = new System.Drawing.Point(574, 61);
            this.entryInfoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entryInfoPanel.Name = "entryInfoPanel";
            this.entryInfoPanel.Size = new System.Drawing.Size(485, 502);
            this.entryInfoPanel.TabIndex = 6;
            this.entryInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.entryInfoPanel_Paint);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(30, 161);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 17);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Type = SimplePM.LabelType.Standart;
            this.passwordLabel.Visible = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Verdana", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(30, 115);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(46, 17);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Login";
            this.loginLabel.Type = SimplePM.LabelType.Standart;
            this.loginLabel.Visible = false;
            // 
            // passVisibilityButton
            // 
            this.passVisibilityButton.BackgroundImage = global::SimplePM.Properties.Resources.visible_icon;
            this.passVisibilityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.passVisibilityButton.Location = new System.Drawing.Point(408, 147);
            this.passVisibilityButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passVisibilityButton.Name = "passVisibilityButton";
            this.passVisibilityButton.Size = new System.Drawing.Size(35, 35);
            this.passVisibilityButton.TabIndex = 2;
            this.passVisibilityButton.UseVisualStyleBackColor = false;
            this.passVisibilityButton.Visible = false;
            this.passVisibilityButton.Click += new System.EventHandler(this.passVisibilityButton_Click);
            // 
            // entryTitlePanel
            // 
            this.entryTitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryTitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.entryTitlePanel.Controls.Add(this.entryNameLabel);
            this.entryTitlePanel.Controls.Add(this.deleteEntryButton);
            this.entryTitlePanel.Controls.Add(this.editEntryButton);
            this.entryTitlePanel.Location = new System.Drawing.Point(3, 3);
            this.entryTitlePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entryTitlePanel.Name = "entryTitlePanel";
            this.entryTitlePanel.Size = new System.Drawing.Size(479, 73);
            this.entryTitlePanel.TabIndex = 4;
            // 
            // entryNameLabel
            // 
            this.entryNameLabel.AutoSize = true;
            this.entryNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.entryNameLabel.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryNameLabel.ForeColor = System.Drawing.Color.White;
            this.entryNameLabel.Location = new System.Drawing.Point(5, 35);
            this.entryNameLabel.Name = "entryNameLabel";
            this.entryNameLabel.Size = new System.Drawing.Size(134, 26);
            this.entryNameLabel.TabIndex = 2;
            this.entryNameLabel.Text = "EntryName";
            this.entryNameLabel.Type = SimplePM.LabelType.Large;
            this.entryNameLabel.Visible = false;
            // 
            // deleteEntryButton
            // 
            this.deleteEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEntryButton.BackgroundImage = global::SimplePM.Properties.Resources.delete_icon;
            this.deleteEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteEntryButton.Location = new System.Drawing.Point(400, 15);
            this.deleteEntryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteEntryButton.Name = "deleteEntryButton";
            this.deleteEntryButton.Size = new System.Drawing.Size(47, 46);
            this.deleteEntryButton.TabIndex = 1;
            this.deleteEntryButton.UseVisualStyleBackColor = false;
            this.deleteEntryButton.Click += new System.EventHandler(this.deleteEntryButton_Click);
            // 
            // editEntryButton
            // 
            this.editEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editEntryButton.BackgroundImage = global::SimplePM.Properties.Resources.edit_icon;
            this.editEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editEntryButton.Location = new System.Drawing.Point(336, 15);
            this.editEntryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editEntryButton.Name = "editEntryButton";
            this.editEntryButton.Size = new System.Drawing.Size(47, 46);
            this.editEntryButton.TabIndex = 0;
            this.editEntryButton.UseVisualStyleBackColor = false;
            this.editEntryButton.Click += new System.EventHandler(this.editEntryButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Black;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(138, 145);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(264, 33);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = true;
            this.passwordTextBox.Visible = false;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.Black;
            this.loginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.loginTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.loginTextBox.BorderSize = 2;
            this.loginTextBox.Font = new System.Drawing.Font("Verdana", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginTextBox.ForeColor = System.Drawing.Color.White;
            this.loginTextBox.Location = new System.Drawing.Point(138, 99);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginTextBox.Multiline = false;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Padding = new System.Windows.Forms.Padding(8);
            this.loginTextBox.PasswordChar = false;
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(306, 33);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.Texts = "";
            this.loginTextBox.UnderlinedStyle = true;
            this.loginTextBox.Visible = false;
            // 
            // generatePassButton
            // 
            this.generatePassButton.Alignment = System.Drawing.StringAlignment.Near;
            this.generatePassButton.BackColor = System.Drawing.Color.Black;
            this.generatePassButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generatePassButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.generatePassButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.generatePassButton.Location = new System.Drawing.Point(16, 127);
            this.generatePassButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generatePassButton.Name = "generatePassButton";
            this.generatePassButton.Size = new System.Drawing.Size(226, 58);
            this.generatePassButton.TabIndex = 8;
            this.generatePassButton.Text = "Generate Password";
            this.generatePassButton.Click += new System.EventHandler(this.generatePassButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Alignment = System.Drawing.StringAlignment.Near;
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minimizeButton.BackColor = System.Drawing.Color.Black;
            this.minimizeButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minimizeButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.minimizeButton.Location = new System.Drawing.Point(16, 505);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(226, 58);
            this.minimizeButton.TabIndex = 9;
            this.minimizeButton.Text = "Minimize";
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Simple Password Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // accountButton
            // 
            this.accountButton.Alignment = System.Drawing.StringAlignment.Near;
            this.accountButton.BackColor = System.Drawing.Color.Black;
            this.accountButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accountButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.accountButton.Location = new System.Drawing.Point(16, 192);
            this.accountButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(226, 58);
            this.accountButton.TabIndex = 10;
            this.accountButton.Text = "Manage Account";
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Alignment = System.Drawing.StringAlignment.Near;
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsButton.BackColor = System.Drawing.Color.Black;
            this.settingsButton.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsButton.LineAlignment = System.Drawing.StringAlignment.Center;
            this.settingsButton.Location = new System.Drawing.Point(16, 440);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(226, 58);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 577);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.unsignedManageAccountPanel);
            this.Controls.Add(this.signedManageAccountPanel);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.generatePassButton);
            this.Controls.Add(this.entryInfoPanel);
            this.Controls.Add(this.entriesPanel);
            this.Controls.Add(this.addEntryButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(117, 58);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.signedManageAccountPanel.ResumeLayout(false);
            this.unsignedManageAccountPanel.ResumeLayout(false);
            this.entryInfoPanel.ResumeLayout(false);
            this.entryInfoPanel.PerformLayout();
            this.entryTitlePanel.ResumeLayout(false);
            this.entryTitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region --Private Methods--

        private void ApplyTheme(Theme theme)
        {
            // Image buttons
            this.passVisibilityButton.BackColor = theme.ImageButtonStyle.BackColor;
            this.passVisibilityButton.FlatAppearance.BorderSize = theme.ImageButtonStyle.BorderSize;
            this.passVisibilityButton.FlatAppearance.MouseDownBackColor = theme.ImageButtonStyle.MouseDownBackColor;
            this.passVisibilityButton.FlatAppearance.MouseOverBackColor = theme.ImageButtonStyle.MouseOverBackColor;
            this.passVisibilityButton.FlatStyle = theme.ImageButtonStyle.FlatStyle;

            this.deleteEntryButton.BackColor = theme.ImageButtonStyle.BackColor;
            this.deleteEntryButton.FlatAppearance.BorderSize = theme.ImageButtonStyle.BorderSize;
            this.deleteEntryButton.FlatAppearance.MouseDownBackColor = theme.ImageButtonStyle.MouseDownBackColor;
            this.deleteEntryButton.FlatAppearance.MouseOverBackColor = theme.ImageButtonStyle.MouseOverBackColor;
            this.deleteEntryButton.FlatStyle = theme.ImageButtonStyle.FlatStyle;

            this.editEntryButton.BackColor = theme.ImageButtonStyle.BackColor;
            this.editEntryButton.FlatAppearance.BorderSize = theme.ImageButtonStyle.BorderSize;
            this.editEntryButton.FlatAppearance.MouseDownBackColor = theme.ImageButtonStyle.MouseDownBackColor;
            this.editEntryButton.FlatAppearance.MouseOverBackColor = theme.ImageButtonStyle.MouseOverBackColor;
            this.editEntryButton.FlatStyle = theme.ImageButtonStyle.FlatStyle;

            // Panels

            this.entriesPanel.BackColor = theme.PanelStyle.PrimaryBackColor;
            this.entryInfoPanel.BackColor = theme.PanelStyle.PrimaryBackColor;
            this.entryTitlePanel.BackColor = theme.PanelStyle.SecondaryBackColor;
            this.unsignedManageAccountPanel.BackColor = theme.PanelStyle.PrimaryBackColor;
            this.signedManageAccountPanel.BackColor = theme.PanelStyle.PrimaryBackColor;

            // Custom elements
            marauderFormStyle1.CurrentTheme = theme;
            addEntryButton.CurrentTheme = theme;
            passwordTextBox.CurrentTheme = theme;
            loginTextBox.CurrentTheme = theme;
            generatePassButton.CurrentTheme = theme;
            minimizeButton.CurrentTheme = theme;
            settingsButton.CurrentTheme = theme;
            loginLabel.CurrentTheme = theme;
            passwordLabel.CurrentTheme = theme;
            entryNameLabel.CurrentTheme = theme;
            signInButton.CurrentTheme = theme;
            signUpButton.CurrentTheme = theme;
            deleteAccountButton.CurrentTheme = theme;
            deleteAccountButton.ForeColor = Color.Red;
            signOutButton.CurrentTheme = theme;
            signOutButton.ForeColor = Color.Red;
            changeMasterPasswordButton.CurrentTheme = theme;
            changePasswordButton.CurrentTheme = theme;
            UpdateEntriesPanel();
        }

        private void SetWindowHeader(string headerText)
        {
            this.Text = headerText;
        }

        private void UpdateEntriesPanel()
        {
            if (_entriesProcessor is not null)
            {
                entriesPanel.Controls.Clear();
                try
                {
                    List<Entry> entriesList = _entriesProcessor.RetrieveAll().ToList();
                    int y = 5;
                    foreach (Entry entry in entriesList)
                    {
                        EntriesButton button = new()
                        {
                            NameText = entry.Name,
                            UrlText = entry.URL,
                            NameStringAlignment = StringAlignment.Near,
                            NameStringLineAlignment = StringAlignment.Near,
                            UrlStringAlignment = StringAlignment.Near,
                            UrlStringLineAlignment = StringAlignment.Far,
                            Size = new Size(280, 60),
                            Location = new Point(5, y)
                        };
                        button.Click += (sender, e) => entryButton_Click(sender, e, entry.ID);
                        entriesPanel.Controls.Add(button);
                        y += 70;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"{ex.GetType()}: {ex.Message}. Application will be closed due to critical malfunction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SimplePM.Library.Diagnostics.Logger.CreateExceptionEntry(ex);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.GetType()}: {ex.Message}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SimplePM.Library.Diagnostics.Logger.CreateExceptionEntry(ex);
                }
            }
            HideEntryControls();
        }

        private void UpdateAccountManageButtonsPanelsVisibility()
        {
            if (Properties.Settings.Default.IsSignedIn)
            {
                if (signedManageAccountPanel.Visible)
                    signedManageAccountPanel.Visible = false;
                else
                    signedManageAccountPanel.Visible = true;
                return;
            }
            if (unsignedManageAccountPanel.Visible)
                unsignedManageAccountPanel.Visible = false;
            else
                unsignedManageAccountPanel.Visible = true;
        }

        private void HideEntryControls()
        {
            loginLabel.Visible = false;
            passwordLabel.Visible = false;
            entryNameLabel.Visible = false;
            passVisibilityButton.Visible = false;
            loginTextBox.Visible = false;
            passwordTextBox.Visible = false;
        }

        #endregion

        #region --Event Handlers--

        private void entryInfoPanel_Paint(object sender, PaintEventArgs e)
        {
            Theme currentTheme = SettingsProcessor.GetCurrentTheme();
            Rectangle rectBorder = new(0, 0, entryInfoPanel.Width - 1, entryInfoPanel.Height - 1);
            Pen borderPen = new(currentTheme.PanelStyle.BorderColor, 1)
            {
                Alignment = PenAlignment.Inset
            };
            e.Graphics.DrawRectangle(borderPen, rectBorder);
        }

        private void entriesPanel_Paint(object sender, PaintEventArgs e)
        {
            Theme currentTheme = SettingsProcessor.GetCurrentTheme();
            Rectangle rectBorder = new(0, 0, entriesPanel.Width - 1, entriesPanel.Height - 1);
            Pen borderPen = new(currentTheme.PanelStyle.BorderColor, 1)
            {
                Alignment = PenAlignment.Inset
            };
            e.Graphics.DrawRectangle(borderPen, rectBorder);
        }

        private void unsignedManageAccountPanel_Paint(object sender, PaintEventArgs e)
        {
            if (unsignedManageAccountPanel.Visible)
            {
                Theme currentTheme = SettingsProcessor.GetCurrentTheme();
                Rectangle rectBorder = new(0, 0, unsignedManageAccountPanel.Width - 1, unsignedManageAccountPanel.Height - 1);
                Pen borderPen = new(currentTheme.PanelStyle.BorderColor, 1)
                {
                    Alignment = PenAlignment.Inset
                };
                e.Graphics.DrawRectangle(borderPen, rectBorder);
            }
        }

        private void signedManageAccountPanel_Paint(object sender, PaintEventArgs e)
        {
            if (signedManageAccountPanel.Visible)
            {
                Theme currentTheme = SettingsProcessor.GetCurrentTheme();
                Rectangle rectBorder = new(0, 0, signedManageAccountPanel.Width - 1, signedManageAccountPanel.Height - 1);
                Pen borderPen = new(currentTheme.PanelStyle.BorderColor, 1)
                {
                    Alignment = PenAlignment.Inset
                };
                e.Graphics.DrawRectangle(borderPen, rectBorder);
            }
        }

        private async void mainForm_Load(object sender, System.EventArgs e)
        {
            await PerformSync();
            UpdateEntriesPanel();
        }

        #endregion

        private Elements.MarauderFormStyle marauderFormStyle1;
        private Elements.CustomButton addEntryButton;
        private System.Windows.Forms.Panel entriesPanel;
        private System.Windows.Forms.Panel entryInfoPanel;
        private Elements.CustomTextBox passwordTextBox;
        private Elements.CustomTextBox loginTextBox;
        private Elements.CustomButton generatePassButton;
        private System.Windows.Forms.Panel entryTitlePanel;
        private System.Windows.Forms.Button editEntryButton;
        private System.Windows.Forms.Button deleteEntryButton;
        private System.Windows.Forms.Button passVisibilityButton;
        private Elements.CustomButton minimizeButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Elements.CustomButton accountButton;
        private System.Windows.Forms.Panel unsignedManageAccountPanel;
        private System.Windows.Forms.Panel signedManageAccountPanel;
        private Elements.CustomButton settingsButton;
        private Elements.ThemedLabel loginLabel;
        private Elements.ThemedLabel passwordLabel;
        private Elements.ThemedLabel entryNameLabel;
        private Elements.CustomButton signInButton;
        private Elements.CustomButton signUpButton;
        private Elements.CustomButton deleteAccountButton;
        private Elements.CustomButton signOutButton;
        private Elements.CustomButton changeMasterPasswordButton;
        private Elements.CustomButton changePasswordButton;
    }
}

