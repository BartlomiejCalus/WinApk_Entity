using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
