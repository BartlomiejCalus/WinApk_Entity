namespace WinApk_Entity.Forms.User
{
    partial class EditUser
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
            this.users_CB = new System.Windows.Forms.ComboBox();
            this.mail_TB = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.firstName_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Role_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // users_CB
            // 
            this.users_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.users_CB.FormattingEnabled = true;
            this.users_CB.Location = new System.Drawing.Point(326, 80);
            this.users_CB.Name = "users_CB";
            this.users_CB.Size = new System.Drawing.Size(153, 23);
            this.users_CB.TabIndex = 6;
            this.users_CB.SelectedIndexChanged += new System.EventHandler(this.users_CB_SelectedIndexChanged);
            // 
            // mail_TB
            // 
            this.mail_TB.Location = new System.Drawing.Point(55, 150);
            this.mail_TB.Name = "mail_TB";
            this.mail_TB.Size = new System.Drawing.Size(160, 23);
            this.mail_TB.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(55, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 15);
            this.label.TabIndex = 2;
            this.label.Text = "Mail";
            // 
            // firstName_TB
            // 
            this.firstName_TB.Location = new System.Drawing.Point(55, 204);
            this.firstName_TB.Name = "firstName_TB";
            this.firstName_TB.Size = new System.Drawing.Size(160, 23);
            this.firstName_TB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // lastName_TB
            // 
            this.lastName_TB.Location = new System.Drawing.Point(55, 255);
            this.lastName_TB.Name = "lastName_TB";
            this.lastName_TB.Size = new System.Drawing.Size(160, 23);
            this.lastName_TB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // Role_CB
            // 
            this.Role_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Role_CB.FormattingEnabled = true;
            this.Role_CB.Items.AddRange(new object[] {
            "User",
            "Manager",
            "Admin"});
            this.Role_CB.Location = new System.Drawing.Point(232, 150);
            this.Role_CB.Name = "Role_CB";
            this.Role_CB.Size = new System.Drawing.Size(77, 23);
            this.Role_CB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Users";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(402, 353);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(81, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Update";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(315, 353);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 23);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.Role_CB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lastName_TB);
            this.Controls.Add(this.firstName_TB);
            this.Controls.Add(this.mail_TB);
            this.Controls.Add(this.users_CB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox users_CB;
        private TextBox mail_TB;
        private Label label;
        private TextBox firstName_TB;
        private Label label2;
        private TextBox lastName_TB;
        private Label label3;
        private ComboBox Role_CB;
        private Label label1;
        private Label label5;
        private Button editBtn;
        private Button deleteBtn;
    }
}