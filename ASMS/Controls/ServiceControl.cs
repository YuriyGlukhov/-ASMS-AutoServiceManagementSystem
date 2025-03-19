using ASMS.Base.Entities;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using ASMS.Forms.Forms;
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

namespace ASMS.Forms.Controls
{
    public partial class ServiceControl : UserControl
    {
        private readonly IEntityService<ServiceDTO> _serviceService;
        private ServiceDTO serviceDTO = new ServiceDTO();
        public ServiceControl(IEntityService<ServiceDTO> serviceService)
        {
            _serviceService = serviceService;
            InitializeComponent();
        }

        private void ServiceControl_Load(object sender, EventArgs e)
        {
            LoadServices();
        }
        private void LoadServices()
        {
            var services = _serviceService.Get();
            dataGridViewServices.DataSource = services;
        }
        private void dataGridViewServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewServices.CurrentRow == null) return;
            {
                var selectedRow = dataGridViewServices.CurrentRow;

                try
                {
                    serviceDTO.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    serviceDTO.Name = Name = selectedRow.Cells["Name"].Value.ToString() ?? string.Empty;
                    serviceDTO.Description = selectedRow.Cells["Description"].Value.ToString() ?? string.Empty;
                    serviceDTO.Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value.ToString());
                    serviceDTO.CarBrand = selectedRow.Cells["CarBrand"].Value.ToString() ?? string.Empty;
                    serviceDTO.Duration = TimeSpan.TryParse(selectedRow.Cells["Duration"].Value?.ToString()
                                                                , out var duration)
                                                                ? duration
                                                                : TimeSpan.Zero;
                    selectedRow.Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonGetServices_Click(object sender, EventArgs e)
        {
            LoadServices();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            var addServiceForm = new AddServiceForm(_serviceService);
            addServiceForm.ShowDialog();
            LoadServices();
           
        }

        private void buttonUpdateService_Click(object sender, EventArgs e)
        {
            var updateServiceForm = new UpdateServiceForm(_serviceService, serviceDTO);
            updateServiceForm.ShowDialog();
            LoadServices();
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            if (serviceDTO != null)
            {
                try
                {
                    _serviceService.Remove(serviceDTO);
                    LoadServices();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
            else
            {
                MessageBox.Show("Выберите услугу для удаления.");
            }
        }
    }
}
