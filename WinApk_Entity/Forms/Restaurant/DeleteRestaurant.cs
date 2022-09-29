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

namespace WinApk_Entity.Forms.Restaurant
{
    public partial class DeleteRestaurant : Form
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();
        public DeleteRestaurant()
        {
            InitializeComponent();
            _restaurantService.LoadRestaurant(restaurant_CB);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var name = restaurant_CB.Text;
            if (name != "")
            {
                var result = MessageBox.Show($"Do you want to permanently remove {name} ?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    _restaurantService.DeleteRestaurant(name);

                _restaurantService.LoadRestaurant(restaurant_CB);
            }
        }
    }
}
