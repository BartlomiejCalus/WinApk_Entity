using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ComponentModel.DataAnnotations;

using WinApk_Entity.Services;
using WinApk_Entity.Models;

namespace WinApk_Entity.Forms.Dishes
{
    public partial class AddDish : Form
    {
        private readonly DishService _dishService = new DishService();

        public AddDish()
        {
            InitializeComponent();

            _dishService.LoadRestaurant(Restaurant_ComboBox);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool isPrize = Double.TryParse(Prize_TB.Text,out double reuslt);
            if (isPrize)
            {
                AddDishDto dto = new AddDishDto()
                {
                    Name = Name_TB.Text,
                    Prize = reuslt,
                    Description = Descr_TB.Text
                };

                var Restaurant = Restaurant_ComboBox.Text;

                _dishService.AddDish(dto, Restaurant);
            }
            else
            {
                MessageBox.Show("Prize is not correct", "message");
            }
            
        }
    }
}
