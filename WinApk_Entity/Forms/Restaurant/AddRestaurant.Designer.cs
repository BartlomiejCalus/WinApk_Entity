namespace WinApk_Entity.Forms.Restaurant
{
    partial class AddRestaurant
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
            this.name_TB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.description_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.street_TB = new System.Windows.Forms.TextBox();
            this.city_TB = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.postCode_TB = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_TB
            // 
            this.name_TB.Location = new System.Drawing.Point(57, 52);
            this.name_TB.Name = "name_TB";
            this.name_TB.Size = new System.Drawing.Size(142, 23);
            this.name_TB.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(402, 353);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // description_TB
            // 
            this.description_TB.Location = new System.Drawing.Point(57, 114);
            this.description_TB.Name = "description_TB";
            this.description_TB.Size = new System.Drawing.Size(218, 23);
            this.description_TB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // street_TB
            // 
            this.street_TB.Location = new System.Drawing.Point(57, 179);
            this.street_TB.Name = "street_TB";
            this.street_TB.Size = new System.Drawing.Size(218, 23);
            this.street_TB.TabIndex = 2;
            // 
            // city_TB
            // 
            this.city_TB.Location = new System.Drawing.Point(57, 241);
            this.city_TB.Name = "city_TB";
            this.city_TB.Size = new System.Drawing.Size(142, 23);
            this.city_TB.TabIndex = 3;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(57, 161);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 15);
            this.label33.TabIndex = 2;
            this.label33.Text = "Street";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "City";
            // 
            // postCode_TB
            // 
            this.postCode_TB.Location = new System.Drawing.Point(57, 297);
            this.postCode_TB.Name = "postCode_TB";
            this.postCode_TB.Size = new System.Drawing.Size(142, 23);
            this.postCode_TB.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(57, 279);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 15);
            this.label21.TabIndex = 2;
            this.label21.Text = "Post Code";
            // 
            // AddRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 416);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.postCode_TB);
            this.Controls.Add(this.city_TB);
            this.Controls.Add(this.street_TB);
            this.Controls.Add(this.description_TB);
            this.Controls.Add(this.name_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRestaurant";
            this.Text = "AddRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox name_TB;
        private Button addBtn;
        private Label label1;
        private TextBox description_TB;
        private Label label2;
        private TextBox street_TB;
        private TextBox city_TB;
        private Label label33;
        private Label label12;
        private TextBox postCode_TB;
        private Label label21;
    }
}