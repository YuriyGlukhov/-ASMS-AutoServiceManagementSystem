using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMS.Forms.Forms
{
    public partial class AddCarForm : Form
    {
        private readonly IEntityService<CarDTO> _carService;
        public AddCarForm(IEntityService<CarDTO> carService)
        {
            _carService = carService;
            InitializeComponent();
        }

        private void BrandBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            var car = new CarDTO()
            {
                Brand = BrandBox.Text,
                Model = ModelBox.Text,
                RegNumber = RegNumberBox.Text,
                Vin = VinBox.Text,
                Year = int.Parse(YearBox.Text)
            };
            _carService.Add(car);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VinBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
