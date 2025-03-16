using ASMS.Base.Entities;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using ASMS.Forms.Services;
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
    public partial class UpdateCarForm : Form
    {
        private readonly IEntityService<CarDTO> _carService;
        private CarDTO _car;
        public UpdateCarForm(IEntityService<CarDTO> carService, CarDTO carDTO)
        {
            _carService = carService;
            _car = carDTO;
            InitializeComponent();

            BrandBox.Text = _car.Brand;
            ModelBox.Text = _car.Model;
            RegNumberBox.Text = _car.RegNumber;
            VinBox.Text = _car.Vin;
            YearBox.Text = _car.Year.ToString();
        }

        private void BrandBox_TextChanged(object sender, EventArgs e)
        {
            _car.Brand = BrandBox.Text;
        }

        private void ModelBox_TextChanged(object sender, EventArgs e)
        {
            _car.Model = ModelBox.Text;
        }

        private void RegNumberBox_TextChanged(object sender, EventArgs e)
        {
            _car.RegNumber = RegNumberBox.Text;
        }

        private void UpdateCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                _carService.UpDate(_car);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VinBox_TextChanged(object sender, EventArgs e)
        {
            _car.Vin = VinBox.Text;
        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {
            _car.Year = int.Parse(YearBox.Text);
        }
    }
}
