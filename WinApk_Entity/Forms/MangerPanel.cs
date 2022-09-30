using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinApk_Entity.Forms.Dishes;
using WinApk_Entity.Forms.Restaurant;
using WinApk_Entity.Forms.User;

namespace WinApk_Entity.Forms
{
    public partial class MangerPanel : Form
    {
        private Color background, font;

        public MangerPanel(int role)
        {
            InitializeComponent();

            if(role == 3)
            {
                UserEditBtn.Visible = true;
            }
                
            background = AddBtn.BackColor;
            font = AddBtn.ForeColor;

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            isClicked(sender);

            this.canvasPanel.Controls.Clear();
            AddDish AddDish_vr = new AddDish() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            AddDish_vr.FormBorderStyle = FormBorderStyle.None;
            this.canvasPanel.Controls.Add(AddDish_vr);
            AddDish_vr.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            isClicked(sender);

            this.canvasPanel.Controls.Clear();
            EditDish EditDish_vr = new EditDish() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            EditDish_vr.FormBorderStyle = FormBorderStyle.None;
            this.canvasPanel.Controls.Add(EditDish_vr);
            EditDish_vr.Show();
        }

        private void addRestaurantBtn_Click(object sender, EventArgs e)
        {
            isClicked(sender);

            this.canvasPanel.Controls.Clear();
            AddRestaurant AddRestaurant_vr = new AddRestaurant() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            AddRestaurant_vr.FormBorderStyle = FormBorderStyle.None;
            this.canvasPanel.Controls.Add(AddRestaurant_vr);
            AddRestaurant_vr.Show();
        }

        private void editRestaurantBtn_Click(object sender, EventArgs e)
        {
            isClicked(sender);

            this.canvasPanel.Controls.Clear();
            EditRestaurant EditRestaurant_vr = new EditRestaurant() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            EditRestaurant_vr.FormBorderStyle = FormBorderStyle.None;
            this.canvasPanel.Controls.Add(EditRestaurant_vr);
            EditRestaurant_vr.Show();
        }

        private void UserEditBtn_Click(object sender, EventArgs e)
        {
            isClicked(sender);

            this.canvasPanel.Controls.Clear();
            EditUser EditUser_vr = new EditUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            EditUser_vr.FormBorderStyle = FormBorderStyle.None;
            this.canvasPanel.Controls.Add(EditUser_vr);
            EditUser_vr.Show();
        }

        private void isClicked(object sender)
        {
            allClicked();
            var btn = (Button)sender;
            btn.BackColor = Color.Gray;
            btn.ForeColor = Color.White;

        }

        private void allClicked()
        {
            UserEditBtn.ForeColor = font;
            AddBtn.ForeColor = font;
            EditBtn.ForeColor = font;
            addRestaurantBtn.ForeColor = font;
            editRestaurantBtn.ForeColor = font;

            UserEditBtn.BackColor = background;
            AddBtn.BackColor = background;
            EditBtn.BackColor = background;
            addRestaurantBtn.BackColor = background;
            editRestaurantBtn.BackColor = background;
        }
    }
}
