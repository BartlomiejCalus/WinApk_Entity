using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using FluentValidation.Results;

using WinApk_Entity.Services;
using WinApk_Entity.Models;

namespace WinApk_Entity
{
    public partial class SignUpPanel : Form
    {
        AccountService _accountService = new AccountService();
        UserRegisterDto dto;
        public SignUpPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto = new UserRegisterDto()
            {
                Email = Email_TB.Text,
                Password = Password_TB.Text,
                ConfirmPassword = ConfirmPW_TB.Text
            };
            
            if(dto != null)
            {
                UserRegisterValidation validator = new UserRegisterValidation();
                ValidationResult result = validator.Validate(dto);
                IList<ValidationFailure> failures = result.Errors;
                if (!result.IsValid)
                {
                    foreach(ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                
            }
            _accountService.RegisterUser(dto);

            this.Close();
        }
    }
}
