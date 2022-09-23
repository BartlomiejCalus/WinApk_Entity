using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Entities;
using WinApk_Entity.Services;

namespace WinApk_Entity
{
    public partial class Form1 : Form
    {
        private readonly DataService _dtService = new DataService();

        private readonly string _mail;
        public Form1(string mail)
        {
            InitializeComponent();
            _mail = mail;
            label1.Text = $"Zalogowany: {_mail}";

            dataGridView1.DataSource = _dtService.ShowData();
            
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=_dtService.GetRestaurant(textBox1.Text);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dtService.ShowData();
        }

        private void FiltrBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _dtService.GetRestaurant(City_TB.Text,Street_TB.Text);
        }
    }
}