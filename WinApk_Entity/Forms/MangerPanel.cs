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

namespace WinApk_Entity.Forms
{
    public partial class MangerPanel : Form
    {
        public MangerPanel(int role)
        {
            InitializeComponent();

            if(role == 3)
            {
                UserAddBtn.Visible = true;
                UserDelBtn.Visible = true;
                UserEditBtn.Visible = true;
            }
                

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.canvasPanel.Controls.Clear();
            AddDish AddDish_vr = new AddDish() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            AddDish_vr.FormBorderStyle = FormBorderStyle.None;
            this.canvasPanel.Controls.Add(AddDish_vr);
            AddDish_vr.Show();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void UserAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void UserDelBtn_Click(object sender, EventArgs e)
        {

        }

        private void UserEditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
