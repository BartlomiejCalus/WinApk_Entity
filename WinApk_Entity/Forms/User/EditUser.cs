using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinApk_Entity.Services;
using WinApk_Entity.Models;

namespace WinApk_Entity.Forms.User
{
    public partial class EditUser : Form
    {
        private readonly UserService _userService = new UserService();
        private readonly List<Entities.User> users;

        public EditUser()
        {
            users = _userService.LoadUser();

            InitializeComponent();

            users_CB.DataSource = users;
            users_CB.ValueMember = "Id";
            users_CB.DisplayMember = "Email";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            UserDto dto = new UserDto()
            {
                Email = mail_TB.Text,
                FirstName = firstName_TB.Text,
                LastName = lastName_TB.Text,
                RoleName = Role_CB.Text,
                RoleId = Role_CB.SelectedIndex + 1
            };

            var mail = users_CB.Text;

            _userService.EditUser(mail, dto);

            MessageBox.Show("Edited sucessful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var mail = users_CB.Text;

            if (mail != "")
            {
                var result = MessageBox.Show($"Do you want to permanently remove user with email: {mail} ?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    _userService.DeleteUser(mail);
            }
        }

        private void users_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mail = users[users_CB.SelectedIndex].Email;

            UserDto dto = _userService.ShowRestaurant(mail);

            if (dto == null)
                return;

            mail_TB.Text = dto.Email;
            firstName_TB.Text = dto.FirstName;
            lastName_TB.Text = dto.LastName;
            Role_CB.SelectedIndex = dto.RoleId-1;
        }
    }
}
