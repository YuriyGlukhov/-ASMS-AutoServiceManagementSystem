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
    public partial class UpdateServiceForm : Form
    {
        private readonly IEntityService<ServiceDTO> _serviceService;
        private ServiceDTO _serviceDTO;
        public UpdateServiceForm(IEntityService<ServiceDTO> serviceService, ServiceDTO serviceDTO)
        {
            _serviceService = serviceService;
            _serviceDTO = serviceDTO;
            InitializeComponent();

            NameBox.Text = _serviceDTO.Name;
            DescriptionBox.Text = _serviceDTO.Description;
            PriceBox.Text = _serviceDTO.Price.ToString();
            BrandBox.Text = _serviceDTO.CarBrand;
            DurationBox.Text = _serviceDTO.Duration.TotalMinutes.ToString();
        }

        private void UpdateServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            _serviceDTO.Name = NameBox.Text;
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            _serviceDTO.Description = DescriptionBox.Text;
        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            _serviceDTO.Price = Convert.ToDecimal(PriceBox.Text);
        }

        private void BrandBox_TextChanged(object sender, EventArgs e)
        {
            _serviceDTO.CarBrand = BrandBox.Text;
        }

        private void DurationBox_TextChanged(object sender, EventArgs e)
        {
            _serviceDTO.Duration = TimeSpan.Parse(DurationBox.Text);
        }



        private void UpdateServiceButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                _serviceService.UpDate(_serviceDTO);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DurationBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
