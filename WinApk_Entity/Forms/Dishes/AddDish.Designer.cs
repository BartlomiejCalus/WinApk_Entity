namespace WinApk_Entity.Forms.Dishes
{
    partial class AddDish
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
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Prize_TB = new System.Windows.Forms.TextBox();
            this.Descr_TB = new System.Windows.Forms.TextBox();
            this.Restaurant_ComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(54, 159);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(201, 23);
            this.Name_TB.TabIndex = 1;
            // 
            // Prize_TB
            // 
            this.Prize_TB.Location = new System.Drawing.Point(54, 214);
            this.Prize_TB.Name = "Prize_TB";
            this.Prize_TB.Size = new System.Drawing.Size(201, 23);
            this.Prize_TB.TabIndex = 2;
            // 
            // Descr_TB
            // 
            this.Descr_TB.Location = new System.Drawing.Point(54, 270);
            this.Descr_TB.Name = "Descr_TB";
            this.Descr_TB.Size = new System.Drawing.Size(297, 23);
            this.Descr_TB.TabIndex = 3;
            // 
            // Restaurant_ComboBox
            // 
            this.Restaurant_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Restaurant_ComboBox.FormattingEnabled = true;
            this.Restaurant_ComboBox.Location = new System.Drawing.Point(54, 45);
            this.Restaurant_ComboBox.Name = "Restaurant_ComboBox";
            this.Restaurant_ComboBox.Size = new System.Drawing.Size(201, 23);
            this.Restaurant_ComboBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(402, 353);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(81, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Restaurants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // AddDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.Restaurant_ComboBox);
            this.Controls.Add(this.Descr_TB);
            this.Controls.Add(this.Prize_TB);
            this.Controls.Add(this.Name_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDish";
            this.Text = "AddDish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Name_TB;
        private TextBox Prize_TB;
        private TextBox Descr_TB;
        private ComboBox Restaurant_ComboBox;
        private Button addBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}