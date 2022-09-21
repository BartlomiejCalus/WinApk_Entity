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

            _accountService.LoginUser(dto,this);
        }
    }
}
