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

namespace WinApk_Entity.Forms
{
    public partial class DataGrid : Form
    {

        private readonly DataService _dtService = new DataService();

        public DataGridView gridView;
        public DataGrid()
        {
            InitializeComponent();
            gridView = dataGridView1;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string? restaurant = dataGridView1
                .CurrentRow
                .Cells[1].Value
                .ToString();

            dataGridView1.DataSource = _dtService.GetDishes(restaurant);
        }
    }
}
