using WinApk_Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace WinApk_Entity
{
    public partial class Form1 : Form
    {
        private readonly string _mail;
        public Form1(string mail)
        {
            InitializeComponent();
            _mail = mail;

            label1.Text = _mail;
            
        }

        
    }
}