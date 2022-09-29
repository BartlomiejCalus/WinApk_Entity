namespace WinApk_Entity.Forms.Dishes
{
    partial class EditDish
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dishes_CB = new System.Windows.Forms.ComboBox();
            this.restaurant_CB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Descr_TB = new System.Windows.Forms.TextBox();
            this.Prize_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dishes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Restaurants";
            // 
            // dishes_CB
            // 
            this.dishes_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dishes_CB.FormattingEnabled = true;
            this.dishes_CB.Location = new System.Drawing.Point(266, 59);
            this.dishes_CB.Name = "dishes_CB";
            this.dishes_CB.Size = new System.Drawing.Size(207, 23);
            this.dishes_CB.TabIndex = 1;
            this.dishes_CB.SelectedIndexChanged += new System.EventHandler(this.dishes_CB_SelectedIndexChanged);
            // 
            // restaurant_CB
            // 
            this.restaurant_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restaurant_CB.FormattingEnabled = true;
            this.restaurant_CB.Location = new System.Drawing.Point(35, 59);
            this.restaurant_CB.Name = "restaurant_CB";
            this.restaurant_CB.Size = new System.Drawing.Size(191, 23);
            this.restaurant_CB.TabIndex = 0;
            this.restaurant_CB.SelectedIndexChanged += new System.EventHandler(this.restaurant_CB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prize";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // Descr_TB
            // 
            this.Descr_TB.Location = new System.Drawing.Point(35, 274);
            this.Descr_TB.Name = "Descr_TB";
            this.Descr_TB.Size = new System.Drawing.Size(297, 23);
            this.Descr_TB.TabIndex = 4;
            // 
            // Prize_TB
            // 
            this.Prize_TB.Location = new System.Drawing.Point(35, 218);
            this.Prize_TB.Name = "Prize_TB";
            this.Prize_TB.Size = new System.Drawing.Size(201, 23);
            this.Prize_TB.TabIndex = 3;
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(35, 163);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(201, 23);
            this.Name_TB.TabIndex = 2;
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
            // EditDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Descr_TB);
            this.Controls.Add(this.Prize_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dishes_CB);
            this.Controls.Add(this.restaurant_CB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditDish";
            this.Text = "EditDish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label1;
        private ComboBox dishes_CB;
        private ComboBox restaurant_CB;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Descr_TB;
        private TextBox Prize_TB;
        private TextBox Name_TB;
        private Button editBtn;
    }
}