﻿namespace WinApk_Entity
{
    partial class LoginPanel
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.SingUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(61, 169);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "button1";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(12, 66);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(175, 23);
            this.Email_TB.TabIndex = 1;
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(12, 116);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(175, 23);
            this.Password_TB.TabIndex = 1;
            // 
            // SingUpBtn
            // 
            this.SingUpBtn.Location = new System.Drawing.Point(61, 212);
            this.SingUpBtn.Name = "SingUpBtn";
            this.SingUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SingUpBtn.TabIndex = 0;
            this.SingUpBtn.Text = "button1";
            this.SingUpBtn.UseVisualStyleBackColor = true;
            this.SingUpBtn.Click += new System.EventHandler(this.SingUpBtn_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 301);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Email_TB);
            this.Controls.Add(this.SingUpBtn);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginPanel";
            this.Text = "LoginPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginBtn;
        private TextBox Email_TB;
        private TextBox Password_TB;
        private Button SingUpBtn;
    }
}