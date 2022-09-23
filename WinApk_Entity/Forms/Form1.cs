using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Entities;
using WinApk_Entity.Services;

namespace WinApk_Entity
{
    public partial class Form1 : Form
    {
        private readonly DataService _dtService = new DataService();

        private readonly string _mail;
        public Form1(string mail, int role)
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? restaurant = dataGridView1
                .CurrentRow
                .Cells[1].Value
                .ToString();

            dataGridView1.DataSource = _dtService.GetDishes(restaurant);
        }
    }
}