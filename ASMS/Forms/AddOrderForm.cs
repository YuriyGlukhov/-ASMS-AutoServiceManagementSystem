using ASMS.Base.Entities;
using ASMS.Base.Enums;
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
    public partial class AddOrderForm : Form
    {
        private readonly IEntityService<OrderDTO> _orderService;
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;
        private readonly IEntityService<ServiceDTO> _serviceService;

        private List<ServiceDTO> _services = new List<ServiceDTO>();
        public AddOrderForm(
                        IEntityService<ClientDTO> clientService,
                        IEntityService<CarDTO> carService,
                        IEntityService<OrderDTO> orderService,
                        IEntityService<ServiceDTO> serviceService)
        {

            _clientService = clientService;
            _carService = carService;
            _orderService = orderService;
            _serviceService = serviceService;
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxClients_DropDown(object sender, EventArgs e)
        {
            var clients = _clientService.Get();
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "Name";
            comboBoxClients.ValueMember = "Id";
        }

        private void comboBoxCars_DropDown(object sender, EventArgs e)
        {

            var cars = _carService.Get();
            comboBoxCars.DataSource = cars;
            comboBoxCars.DisplayMember = "DisplayText";
            comboBoxCars.ValueMember = "Id";
        }

        private void comboBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedValue == null || comboBoxCars.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента и машину");
                return;
            }
            var selectedCarId = comboBoxCars.SelectedValue as int?;
            var selectedClientId = comboBoxClients.SelectedValue as int?;

            var selectedService = comboBoxServices.SelectedItem as ServiceDTO;

            if (selectedService == null)
            {
                MessageBox.Show("Выберите услугу");
                return;
            }
            _services.Add(selectedService);

            var order = new OrderDTO
            {
                Description = DescriptionBox.Text,
                ClientId = selectedClientId.Value,
                CarId = selectedCarId.Value,
                OrderDate = DateTime.Now.ToUniversalTime(),
                Status = OrderStatus.Created,
                ClientName = null,
                CarInfo = null,
                Services = _services

            };

            try
            {
                _orderService.Add(order);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void comboBoxClients_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxServices_DropDown(object sender, EventArgs e)
        {
            var services = _serviceService.Get();
            comboBoxServices.DataSource = services;
            comboBoxServices.DisplayMember = "Name";
            comboBoxServices.ValueMember = "Id";
        }
    }
}
