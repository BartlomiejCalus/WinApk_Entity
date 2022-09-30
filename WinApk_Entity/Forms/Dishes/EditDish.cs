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

namespace WinApk_Entity.Forms.Dishes
{
    public partial class EditDish : Form
    {

        private readonly DishService _dishService = new DishService();

        public EditDish()
        {
            
            InitializeComponent();

            _dishService.LoadRestaurant(restaurant_CB);

            var name = restaurant_CB.Text;

            _dishService.LoadDishes(dishes_CB, name);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            bool isPrize = Double.TryParse(Prize_TB.Text, out double reuslt);
            if (isPrize)
            {
                AddDishDto dto = new AddDishDto()
                {
                    Name = Name_TB.Text,
                    Prize = reuslt,
                    Description = Descr_TB.Text
                };

                var restaurantName = restaurant_CB.Text;
                var dishName = dishes_CB.Text;

                _dishService.EditDish(restaurantName, dishName, dto);

                MessageBox.Show("Edited sucessful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Prize is not correct", "message");
            }
        }

        private void restaurant_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = restaurant_CB.Text;

            _dishService.LoadDishes(dishes_CB, name);
        }

        private void dishes_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var restaurantName = restaurant_CB.Text;
            var dishName = dishes_CB.Text;

            DishDto dto = _dishService.showDish(restaurantName, dishName);

            Name_TB.Text = dto.Name.ToString();
            Descr_TB.Text = dto.Description?.ToString();
            Prize_TB.Text = dto.Prize.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var name = dishes_CB.Text;
            if (name != "")
            {
                var result = MessageBox.Show($"Do you want to permanently remove {name} ?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    _dishService.DeleteDish(name);
            }

            var nameRestaurant = restaurant_CB.Text;

            _dishService.LoadDishes(dishes_CB, nameRestaurant);
        }
    }
}
