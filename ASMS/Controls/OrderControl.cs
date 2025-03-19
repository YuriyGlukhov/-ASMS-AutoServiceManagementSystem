using ASMS.Base.Entities;
using ASMS.Base.Enums;
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
    public partial class OrderControl : UserControl
    {
        private readonly IEntityService<OrderDTO> _orderService;
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;
        private readonly IEntityService<ServiceDTO> _serviceService;
        private readonly IClientsCarService _clientsCarService;

        private OrderDTO orderDTO = new OrderDTO();
        private List<ServiceDTO> servicesList = new List<ServiceDTO>();
        public OrderControl(
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

        private void LoadOrders()
        {
            var orders = _orderService.Get();

            foreach (var order in orders)
            {
                order.ServicesInfo = string.Join(", ", order.Services.Select(s => s.Name));
            }

            dataGridViewOrders.DataSource = orders;

            dataGridViewOrders.Columns["ServicesInfo"].HeaderText = "Услуга";
            dataGridViewOrders.Columns["ClientName"].HeaderText = "Клиент";
            dataGridViewOrders.Columns["CarInfo"].HeaderText = "Машина";

        }
        private void OrderControl_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null) return;
            {
                var selectedRow = dataGridViewOrders.CurrentRow;

                try
                {
                    var tempList = _serviceService.Get();
                    foreach(var service in tempList)
                    {
                        if (service.Name == selectedRow.Cells["ServicesInfo"].Value?.ToString())
                        {
                            servicesList.Clear();
                            servicesList.Add(service);
                        }
                    }

                    orderDTO.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    orderDTO.Description = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty;
                    orderDTO.OrderDate = Convert.ToDateTime(selectedRow.Cells["OrderDate"].Value).ToUniversalTime();
                    orderDTO.Status = ParseOrderStatus(selectedRow.Cells["Status"].Value);
                    orderDTO.ClientId = Convert.ToInt32(selectedRow.Cells["ClientId"].Value);
                    orderDTO.CarId = Convert.ToInt32(selectedRow.Cells["CarId"].Value);
                    orderDTO.Services = servicesList;
                  

                    selectedRow.Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обработке данных: {ex.Message}");
                }
            }
        }

        private void buttonAddGetOrder_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm(_clientService,_carService,_orderService,_serviceService, _clientsCarService);
            addOrderForm.ShowDialog();
            LoadOrders();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            if (orderDTO != null)
            {
                var updateOrderForm = new UpdateOrderForm(orderDTO,_clientService,_carService,
                                                           _orderService,_serviceService,
                                                           _clientsCarService);
                updateOrderForm.ShowDialog();
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Выберите заказ!");
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (orderDTO != null)
            {
                try
                {
                    _orderService.Remove(orderDTO);
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления.");
            }
        }

        private OrderStatus ParseOrderStatus(object statusValue)
        {
            if (statusValue == null) return OrderStatus.Created;

            string statusString = statusValue.ToString()?.Trim(); 
            switch (statusString)
            {
                case "Created":
                    return OrderStatus.Created;
                case "Canceled":
                    return OrderStatus.Canceled;
                case "InProgress":
                    return OrderStatus.InProgress;
                case "Completed":
                    return OrderStatus.Completed;
                default:
                    return OrderStatus.Created;
            }
        }
    }
}
