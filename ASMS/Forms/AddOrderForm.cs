using ASMS.Base.Entities;
using ASMS.Base.Enums;
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
    public partial class AddOrderForm : Form
    {
        private readonly IEntityService<OrderDTO> _orderService;
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;
        private readonly IEntityService<ServiceDTO> _serviceService;
        private readonly IClientsCarService _clientsCarService;

        private List<ServiceDTO> services = new List<ServiceDTO>();
        private string selectedCarBrand = string.Empty;
        private int selectedClientId = 0;

        public AddOrderForm(
                        IEntityService<ClientDTO> clientService,
                        IEntityService<CarDTO> carService,
                        IEntityService<OrderDTO> orderService,
                        IEntityService<ServiceDTO> serviceService,
                        IClientsCarService clientsCarService)
        {

            _clientService = clientService;
            _carService = carService;
            _orderService = orderService;
            _serviceService = serviceService;
            _clientsCarService = clientsCarService;
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

            var cars = _clientsCarService.GetClientCars(selectedClientId);
            if (cars.Count < 1)
            {
                cars = _carService.Get();
            }
            comboBoxCars.DataSource = cars;
            comboBoxCars.DisplayMember = "DisplayText";
            comboBoxCars.ValueMember = "Id";

        }

        private void comboBoxClients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem is ClientDTO selectedClient)
            {
                selectedClientId = selectedClient.Id;
                comboBoxCars.ResetText();

            }
        }
        private void comboBoxCars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCars.SelectedItem is CarDTO selectedCar)
            {
                selectedCarBrand = selectedCar.Brand;
                comboBoxServices.ResetText();

            }
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
            services.Add(selectedService);

            var order = new OrderDTO
            {
                Description = DescriptionBox.Text,
                ClientId = selectedClientId.Value,
                CarId = selectedCarId.Value,
                OrderDate = DateTime.Now.ToUniversalTime(),
                Status = OrderStatus.Created,
                ClientName = null,
                CarInfo = null,
                Services = services

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
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBoxServices_DropDown(object sender, EventArgs e)
        {
            var services = _serviceService.Get();

            if (comboBoxCars.Text == string.Empty)
            {
                comboBoxServices.DataSource = services;
                comboBoxServices.DisplayMember = "Name";
                comboBoxServices.ValueMember = "Id";
            }
            else
            {
                var tempServiceList = new List<ServiceDTO>();
                foreach (var service in services)
                {
                    if (service.CarBrand == selectedCarBrand || service.CarBrand == "All")
                    {
                        tempServiceList.Add(service);
                    }
                }
                comboBoxServices.DataSource = tempServiceList;
                comboBoxServices.DisplayMember = "Name";
                comboBoxServices.ValueMember = "Id";
            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            var addClientFrom = new AddClientForm(_clientService);
            addClientFrom.ShowDialog();
            this.Refresh();

        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm(_carService);
            addCarForm.ShowDialog();
            this.Refresh();

        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            var addServiceForm = new AddServiceForm(_serviceService);
            addServiceForm.ShowDialog();
            this.Refresh();
        }
    }
}
