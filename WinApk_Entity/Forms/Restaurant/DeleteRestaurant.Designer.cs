namespace WinApk_Entity.Forms.Restaurant
{
    partial class DeleteRestaurant
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.restaurant_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(403, 329);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Restaurants";
            // 
            // restaurant_CB
            // 
            this.restaurant_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restaurant_CB.FormattingEnabled = true;
            this.restaurant_CB.Location = new System.Drawing.Point(153, 104);
            this.restaurant_CB.Name = "restaurant_CB";
            this.restaurant_CB.Size = new System.Drawing.Size(191, 23);
            this.restaurant_CB.TabIndex = 3;
            // 
            // DeleteRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restaurant_CB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteRestaurant";
            this.Text = "DeleteRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteBtn;
        private Label label1;
        private ComboBox restaurant_CB;
    }
}