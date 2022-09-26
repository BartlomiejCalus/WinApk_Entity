namespace WinApk_Entity.Forms
{
    partial class MangerPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.UserEditBtn = new System.Windows.Forms.Button();
            this.UserDelBtn = new System.Windows.Forms.Button();
            this.UserAddBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserEditBtn);
            this.panel1.Controls.Add(this.UserDelBtn);
            this.panel1.Controls.Add(this.UserAddBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.DelBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 416);
            this.panel1.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBtn.Location = new System.Drawing.Point(0, 0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(129, 64);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Dish";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // DelBtn
            // 
            this.DelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelBtn.Location = new System.Drawing.Point(0, 64);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(129, 64);
            this.DelBtn.TabIndex = 1;
            this.DelBtn.Text = "Delete Dish";
            this.DelBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditBtn.Location = new System.Drawing.Point(0, 128);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(129, 64);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit Dish";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // UserEditBtn
            // 
            this.UserEditBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserEditBtn.Location = new System.Drawing.Point(0, 320);
            this.UserEditBtn.Name = "UserEditBtn";
            this.UserEditBtn.Size = new System.Drawing.Size(129, 64);
            this.UserEditBtn.TabIndex = 5;
            this.UserEditBtn.Text = "Edit User";
            this.UserEditBtn.UseVisualStyleBackColor = true;
            this.UserEditBtn.Visible = false;
            // 
            // UserDelBtn
            // 
            this.UserDelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserDelBtn.Location = new System.Drawing.Point(0, 256);
            this.UserDelBtn.Name = "UserDelBtn";
            this.UserDelBtn.Size = new System.Drawing.Size(129, 64);
            this.UserDelBtn.TabIndex = 4;
            this.UserDelBtn.Text = "Delete User";
            this.UserDelBtn.UseVisualStyleBackColor = true;
            this.UserDelBtn.Visible = false;
            // 
            // UserAddBtn
            // 
            this.UserAddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserAddBtn.Location = new System.Drawing.Point(0, 192);
            this.UserAddBtn.Name = "UserAddBtn";
            this.UserAddBtn.Size = new System.Drawing.Size(129, 64);
            this.UserAddBtn.TabIndex = 3;
            this.UserAddBtn.Text = "Add User";
            this.UserAddBtn.UseVisualStyleBackColor = true;
            this.UserAddBtn.Visible = false;
            // 
            // MangerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 416);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MangerPanel";
            this.Text = "MangerPanel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button EditBtn;
        private Button DelBtn;
        private Button AddBtn;
        private Button UserEditBtn;
        private Button UserDelBtn;
        private Button UserAddBtn;
    }
}