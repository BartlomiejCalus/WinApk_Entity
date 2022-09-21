using Microsoft.EntityFrameworkCore;

using WinApk_Entity.Entities;
using WinApk_Entity.Services;

namespace WinApk_Entity
{
    public partial class Form1 : Form
    {
        private readonly DataService _dtService= new DataService();

        private readonly string _mail;
        public Form1(string mail)
        {
            InitializeComponent();
            _mail = mail;
            label1.Text = $"Zalogowany: {_mail}";

            dataGridView1.DataSource = _dtService.ShowData();
            
        }

    }
}