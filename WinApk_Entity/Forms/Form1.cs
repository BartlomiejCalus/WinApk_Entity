using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Entities;
using WinApk_Entity.Services;

namespace WinApk_Entity
{
    public partial class Form1 : Form
    {
        private readonly DataService _dtService = new DataService();

        private readonly string _mail;
        private readonly int _role;

        private DataGridView _dGV;
        public Form1(string mail, int role)
        {
            InitializeComponent();
            _mail = mail;
            _role = role;
            label1.Text = $"Zalogowany: {_mail}";

            _dGV = _dtService.SetGrid(this.mainPanel);
            
            if(role != 1)
                settingsBtn.Visible = true;

            _dGV.DataSource = _dtService.ShowData();
            
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            _dtService.SettingsMenu(_role, this.mainPanel);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            _dGV.DataSource=_dtService.GetRestaurant(textBox1.Text);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            _dGV = _dtService.SetGrid(this.mainPanel);
            _dGV.DataSource = _dtService.ShowData();
        }

        private void FiltrBtn_Click(object sender, EventArgs e)
        {
            _dGV.DataSource = _dtService.GetRestaurant(City_TB.Text,Street_TB.Text);
        }
    }
}