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
        private CarDTO _carDTO;
        public UpdateCarForm(IEntityService<CarDTO> carService, CarDTO carDTO)
        {
            _carService = carService;
            _carDTO = carDTO;
            InitializeComponent();

            BrandBox.Text = _carDTO.Brand;
            ModelBox.Text = _carDTO.Model;
            RegNumberBox.Text = _carDTO.RegNumber;
            VinBox.Text = _carDTO.Vin;
            YearBox.Text = _carDTO.Year.ToString();
        }

        private void BrandBox_TextChanged(object sender, EventArgs e)
        {
            _carDTO.Brand = BrandBox.Text;
        }

        private void ModelBox_TextChanged(object sender, EventArgs e)
        {
            _carDTO.Model = ModelBox.Text;
        }

        private void RegNumberBox_TextChanged(object sender, EventArgs e)
        {
            _carDTO.RegNumber = RegNumberBox.Text;
        }

        private void UpdateCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                _carService.UpDate(_carDTO);

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
            _carDTO.Vin = VinBox.Text;
        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(YearBox.Text, out int year))
            {
                _carDTO.Year = year;
            }
            else
            {
                MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                YearBox.Clear();
            }
        }

        private void UpdateCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
