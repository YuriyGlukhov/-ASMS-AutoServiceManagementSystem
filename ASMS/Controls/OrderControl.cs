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

        private OrderDTO _orderDTO;
        public OrderControl(
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

        private void OrderControl_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void LoadOrders()
        {
            var orders = _orderService.Get();
            
            dataGridViewOrders.DataSource = orders;
            dataGridViewOrders.Columns["ClientName"].HeaderText = "Клиент";
            dataGridViewOrders.Columns["CarInfo"].HeaderText = "Машина";

        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
    {
                var selectedRow = dataGridViewOrders.Rows[e.RowIndex];

                try
                {
                    _orderDTO = new OrderDTO
                    {
                        Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                        Description = selectedRow.Cells["Description"].Value?.ToString() ?? string.Empty,
                        OrderDate = Convert.ToDateTime(selectedRow.Cells["OrderDate"].Value).ToUniversalTime(),
                        Status = ParseOrderStatus(selectedRow.Cells["Status"].Value),
                        ClientId = Convert.ToInt32(selectedRow.Cells["ClientId"].Value),
                        CarId = Convert.ToInt32(selectedRow.Cells["CarId"].Value)
                    };

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
            var addOrderForm = new AddOrderForm(_clientService,_carService,_orderService,_serviceService);
            addOrderForm.ShowDialog();
            LoadOrders();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            if (_orderDTO != null)
            {
                var updateOrderForm = new UpdateOrderForm(_orderDTO,_clientService,_carService,_orderService,_serviceService);
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
            if (_orderDTO != null)
            {

                _orderService.Remove(_orderDTO);
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления.");
            }
        }

        private OrderStatus ParseOrderStatus(object statusValue)
        {
            if (statusValue == null) return OrderStatus.Created;

            string statusString = statusValue.ToString()?.Trim(); // Убираем пробелы и лишние символы
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
