namespace WinApk_Entity
{
    partial class SingUpPanel
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
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.ConfirmPW_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(12, 53);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(181, 23);
            this.Email_TB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(12, 98);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(181, 23);
            this.Password_TB.TabIndex = 0;
            // 
            // ConfirmPW_TB
            // 
            this.ConfirmPW_TB.Location = new System.Drawing.Point(12, 139);
            this.ConfirmPW_TB.Name = "ConfirmPW_TB";
            this.ConfirmPW_TB.Size = new System.Drawing.Size(181, 23);
            this.ConfirmPW_TB.TabIndex = 0;
            // 
            // SingUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfirmPW_TB);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Email_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SingUpPanel";
            this.Text = "SingUpPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Email_TB;
        private Button button1;
        private TextBox Password_TB;
        private TextBox ConfirmPW_TB;
    }
}