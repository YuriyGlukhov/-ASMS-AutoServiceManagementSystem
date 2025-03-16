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

        private OrderDTO _orderDTO;

        public UpdateOrderForm(OrderDTO orderDTO,
                                IEntityService<ClientDTO> clientService,
                                IEntityService<CarDTO> carService,
                                IEntityService<OrderDTO> orderService,
                                IEntityService<ServiceDTO> serviceService)
        {
            _clientService = clientService;
            _carService = carService;
            _orderService = orderService;
            _serviceService = serviceService;
            _orderDTO = orderDTO;
            InitializeComponent();
        }

        private void UpdateOrderForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();

            comboBoxCars.SelectedValue = _orderDTO.CarId;
            comboBoxClients.SelectedValue = _orderDTO.ClientId;
            comboBoxOrderStatus.SelectedItem = _orderDTO.Status;
            DescriptionBox.Text = _orderDTO.Description;
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

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            _orderDTO.Description = DescriptionBox.Text;
        }

        private void UpdateOrderButton_Click(object sender, EventArgs e)
        {
            _orderDTO.ClientId = (int)comboBoxClients.SelectedValue;
            _orderDTO.CarId = (int)comboBoxCars.SelectedValue;

            _orderService.UpDate(_orderDTO);

            this.Close();
        }
    }
}
