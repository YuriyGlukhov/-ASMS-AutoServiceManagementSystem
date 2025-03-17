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
    public partial class UpdateOrderForm : Form
    {
        private readonly IEntityService<OrderDTO> _orderService;
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;
        private readonly IEntityService<ServiceDTO> _serviceService;
        private readonly IClientsCarService _clientsCarService;

        private OrderDTO _orderDTO;
        private string selectedCarBrand = string.Empty;
        private int selectedCarId = 0;
        private int selectedClientId = 0;
        public UpdateOrderForm(OrderDTO orderDTO,
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
            _orderDTO = orderDTO;
            _clientsCarService = clientsCarService;
            InitializeComponent();

        }

        private void UpdateOrderForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();

            comboBoxCars.SelectedValue = _orderDTO.CarId;
            comboBoxClients.SelectedValue = _orderDTO.ClientId;
            comboBoxOrderStatus.SelectedItem = _orderDTO.Status;
            DescriptionBox.Text = _orderDTO.Description;

            if (_orderDTO.Services.Any())
            {
                var tempService = new ServiceDTO();
                foreach (var service in _orderDTO.Services)
                {
                    tempService.Name = service.Name;
                }
                comboBoxServices.Text = tempService.Name;
            }
            selectedClientId = _orderDTO.ClientId;
            selectedCarId = _orderDTO.CarId;
            selectedCarBrand = GetCarBrand(_orderDTO.CarId);

        }

        private void LoadComboBoxData()
        {
            var clients = _clientService.Get();
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "Name";
            comboBoxClients.ValueMember = "Id";

            var cars = _carService.Get();
            comboBoxCars.DataSource = cars;
            comboBoxCars.DisplayMember = "DisplayText";
            comboBoxCars.ValueMember = "Id";

            comboBoxOrderStatus.DataSource = Enum.GetValues(typeof(OrderStatus));

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
        private void comboBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void comboBoxCars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCars.SelectedItem is CarDTO selectedCar)
            {
                selectedCarBrand = selectedCar.Brand;
                comboBoxServices.ResetText();

            }
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxCars_TextChanged(object sender, EventArgs e)
        {
            _orderDTO.Description = DescriptionBox.Text;
        }
        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                _orderDTO.ClientId = (int)comboBoxClients.SelectedValue;
                _orderDTO.CarId = (int)comboBoxCars.SelectedValue;
                _orderService.UpDate(_orderDTO);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServices.SelectedItem is ServiceDTO selectedService)
            {
                _orderDTO.Services.Clear();
                _orderDTO.Services.Add(selectedService);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetCarBrand(int carId)
        {
            var car = _carService.Get().FirstOrDefault(x => x.Id == carId);
            if (car != null)
            {
                return car.Brand;

            }
            MessageBox.Show("Не удалось подгрузить машину! Выберите из списка!");
            return null;


        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            var addClientFrom = new AddClientForm(_clientService);
            addClientFrom.ShowDialog();
            LoadComboBoxData();

        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm(_carService);
            addCarForm.ShowDialog();
            LoadComboBoxData();

        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            var addServiceForm = new AddServiceForm(_serviceService);
            addServiceForm.ShowDialog();
            LoadComboBoxData();
        }
    }
}
