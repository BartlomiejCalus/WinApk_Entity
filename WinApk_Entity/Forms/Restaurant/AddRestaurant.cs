using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinApk_Entity.Models;
using WinApk_Entity.Services;

namespace WinApk_Entity.Forms.Restaurant
{
    public partial class AddRestaurant : Form
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();

        public AddRestaurant()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddRestaurantDto dto = new AddRestaurantDto()
            {
                Name = name_TB.Text,
                Description = description_TB.Text,
                City = city_TB.Text,
                Street = street_TB.Text,
                PostCode = postCode_TB.Text
            };

            _restaurantService.AddRestaurant(dto);

            city_TB.Clear();
            description_TB.Clear();
            name_TB.Clear();
            postCode_TB.Clear();
            street_TB.Clear();

            MessageBox.Show("Added sucessful", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
