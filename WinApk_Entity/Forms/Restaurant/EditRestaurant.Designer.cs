namespace WinApk_Entity.Forms.Restaurant
{
    partial class EditRestaurant
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
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.postCode_TB = new System.Windows.Forms.TextBox();
            this.city_TB = new System.Windows.Forms.TextBox();
            this.street_TB = new System.Windows.Forms.TextBox();
            this.description_TB = new System.Windows.Forms.TextBox();
            this.name_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.restaurant_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(63, 326);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 15);
            this.label21.TabIndex = 8;
            this.label21.Text = "Post Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(63, 208);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 15);
            this.label33.TabIndex = 11;
            this.label33.Text = "Street";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(392, 356);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Update";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // postCode_TB
            // 
            this.postCode_TB.Location = new System.Drawing.Point(63, 344);
            this.postCode_TB.Name = "postCode_TB";
            this.postCode_TB.Size = new System.Drawing.Size(142, 23);
            this.postCode_TB.TabIndex = 4;
            // 
            // city_TB
            // 
            this.city_TB.Location = new System.Drawing.Point(63, 288);
            this.city_TB.Name = "city_TB";
            this.city_TB.Size = new System.Drawing.Size(142, 23);
            this.city_TB.TabIndex = 3;
            // 
            // street_TB
            // 
            this.street_TB.Location = new System.Drawing.Point(63, 226);
            this.street_TB.Name = "street_TB";
            this.street_TB.Size = new System.Drawing.Size(218, 23);
            this.street_TB.TabIndex = 2;
            // 
            // description_TB
            // 
            this.description_TB.Location = new System.Drawing.Point(63, 161);
            this.description_TB.Name = "description_TB";
            this.description_TB.Size = new System.Drawing.Size(218, 23);
            this.description_TB.TabIndex = 1;
            // 
            // name_TB
            // 
            this.name_TB.Location = new System.Drawing.Point(63, 99);
            this.name_TB.Name = "name_TB";
            this.name_TB.Size = new System.Drawing.Size(142, 23);
            this.name_TB.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Restaurants";
            // 
            // restaurant_CB
            // 
            this.restaurant_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restaurant_CB.FormattingEnabled = true;
            this.restaurant_CB.Location = new System.Drawing.Point(311, 55);
            this.restaurant_CB.Name = "restaurant_CB";
            this.restaurant_CB.Size = new System.Drawing.Size(191, 23);
            this.restaurant_CB.TabIndex = 6;
            this.restaurant_CB.SelectedIndexChanged += new System.EventHandler(this.restaurant_CB_SelectedIndexChanged);
            // 
            // EditRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.restaurant_CB);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.postCode_TB);
            this.Controls.Add(this.city_TB);
            this.Controls.Add(this.street_TB);
            this.Controls.Add(this.description_TB);
            this.Controls.Add(this.name_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRestaurant";
            this.Text = "EditRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label21;
        private Label label12;
        private Label label2;
        private Label label33;
        private Label label1;
        private Button editBtn;
        private TextBox postCode_TB;
        private TextBox city_TB;
        private TextBox street_TB;
        private TextBox description_TB;
        private TextBox name_TB;
        private Label label3;
        private ComboBox restaurant_CB;
    }
}