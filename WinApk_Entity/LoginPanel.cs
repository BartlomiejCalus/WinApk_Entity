using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApk_Entity
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void Email_TB_TextChanged(object sender, EventArgs e)
        {
            if (Email_TB.Text == "Email")
            {
                Email_TB.Text = String.Empty;
            }
        }
    }
}
