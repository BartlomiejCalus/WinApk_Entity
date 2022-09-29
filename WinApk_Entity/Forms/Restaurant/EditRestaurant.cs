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

namespace WinApk_Entity.Forms.Restaurant
{
    public partial class EditRestaurant : Form
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();
        public EditRestaurant()
        {
            InitializeComponent();
            _restaurantService.LoadRestaurant(restaurant_CB);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AddRestaurantDto dto = new AddRestaurantDto()
            {
                Name = name_TB.Text,
                Description = description_TB.Text,
                City = city_TB.Text,
                Street = street_TB.Text,
                PostCode = postCode_TB.Text
            };

            var restaurantName = restaurant_CB.Text;

            _restaurantService.EditRestaurant(restaurantName, dto);

            MessageBox.Show("Edited sucessful", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restaurant_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var restaurantName = restaurant_CB.Text;

            AddRestaurantDto dto = _restaurantService.ShowRestaurant(restaurantName);

            if (dto == null)
                return;

            city_TB.Text = dto.City;
            description_TB.Text = dto.Description;
            name_TB.Text = dto.Name;
            postCode_TB.Text = dto.PostCode;
            street_TB.Text = dto.Street;
        }
    }
}
