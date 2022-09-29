namespace WinApk_Entity.Forms.Dishes
{
    partial class DeleteDish
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
            this.restaurant_CB = new System.Windows.Forms.ComboBox();
            this.dishes_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restaurant_CB
            // 
            this.restaurant_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restaurant_CB.FormattingEnabled = true;
            this.restaurant_CB.Location = new System.Drawing.Point(36, 106);
            this.restaurant_CB.Name = "restaurant_CB";
            this.restaurant_CB.Size = new System.Drawing.Size(191, 23);
            this.restaurant_CB.TabIndex = 0;
            this.restaurant_CB.SelectedIndexChanged += new System.EventHandler(this.restaurant_CB_SelectedIndexChanged);
            // 
            // dishes_CB
            // 
            this.dishes_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dishes_CB.FormattingEnabled = true;
            this.dishes_CB.Location = new System.Drawing.Point(267, 106);
            this.dishes_CB.Name = "dishes_CB";
            this.dishes_CB.Size = new System.Drawing.Size(207, 23);
            this.dishes_CB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dishes";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(402, 353);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DeleteDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dishes_CB);
            this.Controls.Add(this.restaurant_CB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteDish";
            this.Text = "DeleteDish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox restaurant_CB;
        private ComboBox dishes_CB;
        private Label label1;
        private Label label2;
        private Button deleteBtn;
    }
}