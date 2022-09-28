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

namespace WinApk_Entity.Forms.Dishes
{
    public partial class DeleteDish : Form
    {
        private readonly DishService _dishService = new DishService();

        public DeleteDish()
        {
            InitializeComponent();

            _dishService.LoadRestaurant(restaurant_CB);

            var name = restaurant_CB.Text;

            _dishService.LoadDishes(dishes_CB,name);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var name = dishes_CB.Text;
            if(name != "")
            {
                var result = MessageBox.Show($"Do you want to permanently remove {name} ?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(result == DialogResult.Yes)
                _dishService.DeleteDish(name);
            }
            
        }

        private void restaurant_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = restaurant_CB.Text;

            _dishService.LoadDishes(dishes_CB, name);
        }
    }
}
