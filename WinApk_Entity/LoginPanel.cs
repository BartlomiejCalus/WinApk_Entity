using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Entities;

namespace WinApk_Entity
{
    public partial class LoginPanel : Form
    {
        ApkDbContext _dbContext = new ApkDbContext();
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void SingUpBtn_Click(object sender, EventArgs e)
        {
            SingUpPanel singUpPanel = new SingUpPanel();
            singUpPanel.Show();
        }
    }
}
