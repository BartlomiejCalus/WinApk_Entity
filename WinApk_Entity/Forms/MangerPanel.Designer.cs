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
            this.btnPanel = new System.Windows.Forms.Panel();
            this.UserEditBtn = new System.Windows.Forms.Button();
            this.UserDelBtn = new System.Windows.Forms.Button();
            this.UserAddBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.editRestaurantBtn = new System.Windows.Forms.Button();
            this.deleteRestaurantBtn = new System.Windows.Forms.Button();
            this.addRestaurantBtn = new System.Windows.Forms.Button();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.editRestaurantBtn);
            this.btnPanel.Controls.Add(this.deleteRestaurantBtn);
            this.btnPanel.Controls.Add(this.addRestaurantBtn);
            this.btnPanel.Controls.Add(this.UserEditBtn);
            this.btnPanel.Controls.Add(this.UserDelBtn);
            this.btnPanel.Controls.Add(this.UserAddBtn);
            this.btnPanel.Controls.Add(this.EditBtn);
            this.btnPanel.Controls.Add(this.DelBtn);
            this.btnPanel.Controls.Add(this.AddBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPanel.Location = new System.Drawing.Point(0, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(129, 416);
            this.btnPanel.TabIndex = 0;
            // 
            // UserEditBtn
            // 
            this.UserEditBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserEditBtn.Location = new System.Drawing.Point(0, 248);
            this.UserEditBtn.Name = "UserEditBtn";
            this.UserEditBtn.Size = new System.Drawing.Size(129, 56);
            this.UserEditBtn.TabIndex = 5;
            this.UserEditBtn.Text = "Edit User";
            this.UserEditBtn.UseVisualStyleBackColor = true;
            this.UserEditBtn.Visible = false;
            this.UserEditBtn.Click += new System.EventHandler(this.UserEditBtn_Click);
            // 
            // UserDelBtn
            // 
            this.UserDelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserDelBtn.Location = new System.Drawing.Point(0, 304);
            this.UserDelBtn.Name = "UserDelBtn";
            this.UserDelBtn.Size = new System.Drawing.Size(129, 56);
            this.UserDelBtn.TabIndex = 4;
            this.UserDelBtn.Text = "Delete User";
            this.UserDelBtn.UseVisualStyleBackColor = true;
            this.UserDelBtn.Visible = false;
            this.UserDelBtn.Click += new System.EventHandler(this.UserDelBtn_Click);
            // 
            // UserAddBtn
            // 
            this.UserAddBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserAddBtn.Location = new System.Drawing.Point(0, 360);
            this.UserAddBtn.Name = "UserAddBtn";
            this.UserAddBtn.Size = new System.Drawing.Size(129, 56);
            this.UserAddBtn.TabIndex = 3;
            this.UserAddBtn.Text = "Add User";
            this.UserAddBtn.UseVisualStyleBackColor = true;
            this.UserAddBtn.Visible = false;
            this.UserAddBtn.Click += new System.EventHandler(this.UserAddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditBtn.Location = new System.Drawing.Point(0, 84);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(129, 42);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit Dish";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelBtn.Location = new System.Drawing.Point(0, 42);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(129, 42);
            this.DelBtn.TabIndex = 1;
            this.DelBtn.Text = "Delete Dish";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddBtn.Location = new System.Drawing.Point(0, 0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(129, 42);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Dish";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(129, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(514, 416);
            this.canvasPanel.TabIndex = 1;
            // 
            // editRestaurantBtn
            // 
            this.editRestaurantBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editRestaurantBtn.Location = new System.Drawing.Point(0, 210);
            this.editRestaurantBtn.Name = "editRestaurantBtn";
            this.editRestaurantBtn.Size = new System.Drawing.Size(129, 42);
            this.editRestaurantBtn.TabIndex = 8;
            this.editRestaurantBtn.Text = "Edit Restaurant";
            this.editRestaurantBtn.UseVisualStyleBackColor = true;
            this.editRestaurantBtn.Click += new System.EventHandler(this.editRestaurantBtn_Click);
            // 
            // deleteRestaurantBtn
            // 
            this.deleteRestaurantBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteRestaurantBtn.Location = new System.Drawing.Point(0, 168);
            this.deleteRestaurantBtn.Name = "deleteRestaurantBtn";
            this.deleteRestaurantBtn.Size = new System.Drawing.Size(129, 42);
            this.deleteRestaurantBtn.TabIndex = 7;
            this.deleteRestaurantBtn.Text = "Delete Restaurant";
            this.deleteRestaurantBtn.UseVisualStyleBackColor = true;
            this.deleteRestaurantBtn.Click += new System.EventHandler(this.deleteRestaurantBtn_Click);
            // 
            // addRestaurantBtn
            // 
            this.addRestaurantBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addRestaurantBtn.Location = new System.Drawing.Point(0, 126);
            this.addRestaurantBtn.Name = "addRestaurantBtn";
            this.addRestaurantBtn.Size = new System.Drawing.Size(129, 42);
            this.addRestaurantBtn.TabIndex = 6;
            this.addRestaurantBtn.Text = "Add Restaurant";
            this.addRestaurantBtn.UseVisualStyleBackColor = true;
            this.addRestaurantBtn.Click += new System.EventHandler(this.addRestaurantBtn_Click);
            // 
            // MangerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 416);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.btnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MangerPanel";
            this.Text = "MangerPanel";
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel btnPanel;
        private Button EditBtn;
        private Button DelBtn;
        private Button AddBtn;
        private Button UserEditBtn;
        private Button UserDelBtn;
        private Button UserAddBtn;
        private Panel canvasPanel;
        private Button editRestaurantBtn;
        private Button deleteRestaurantBtn;
        private Button addRestaurantBtn;
    }
}