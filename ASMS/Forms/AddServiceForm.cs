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
    public partial class AddServiceForm : Form
    {
        private readonly IEntityService<ServiceDTO> _serviceService;
        public AddServiceForm(IEntityService<ServiceDTO> serviceService)
        {
            _serviceService = serviceService;
            InitializeComponent();
        }
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string durationInput = DurationBox.Text.Trim();

                if (int.TryParse(durationInput, out int durationInMinutes))
                {

                    TimeSpan duration = TimeSpan.FromMinutes(durationInMinutes);
                    var service = new ServiceDTO()
                    {
                        Name = NameBox.Text,
                        Description = DescriptionBox.Text,
                        Price = Convert.ToDecimal(PriceBox.Text),
                        CarBrand = BrandBox.Text,
                        Duration = duration
                    };
                    _serviceService.Add(service);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddServiceForm_Load(object sender, EventArgs e)
        {

        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PriceBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void BrandBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DurationBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
