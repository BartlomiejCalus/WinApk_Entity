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

using WinApk_Entity.Services;
using WinApk_Entity.Models;

namespace WinApk_Entity
{
    public partial class LoginPanel : Form
    {
        private readonly AccountService _accountService = new AccountService();
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void SingUpBtn_Click(object sender, EventArgs e)
        {
            SignUpPanel singUpPanel = new SignUpPanel();
            singUpPanel.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserLoginDto dto = new UserLoginDto()
            {
                Email = Email_TB.Text,
                Password = Password_TB.Text
            };

            var result = _accountService.LoginUser(dto);

            if (result!=null)
            {
                Form1 fm1 = new Form1(result);
                this.Visible = false;
                fm1.ShowDialog();
                this.Close();              
            }
            else
            {
                MessageBox.Show("Email or Password is wrong", "Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
