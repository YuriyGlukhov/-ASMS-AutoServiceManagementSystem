using ASMS.Base.Context;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using ASMS.Forms.Controlls;
using ASMS.Forms.Controls;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMS.Forms
{
    public partial class MainMenu : Form
    {
        private readonly ASMSDbContext _context;
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;
        private readonly IEntityService<OrderDTO> _orderService;
        private readonly IEntityService<ServiceDTO> _serviceService;
        public MainMenu(IEntityService<ClientDTO> clientService,
                    IEntityService<CarDTO> carService,
                    IEntityService<OrderDTO> orderService,
                    IEntityService<ServiceDTO> serviceService,
                    ASMSDbContext context)
        {
            _clientService = clientService;
            _carService = carService;
            _orderService = orderService;
            _serviceService = serviceService;
            _context = context;
            InitializeComponent();
        }

        private void ClientControl_Click(object sender, EventArgs e)
        {
            var clientControl = new ClientControl(_clientService);
            clientControl.Dock = DockStyle.Fill;
            this.Controls.Add(clientControl);
            clientControl.Visible = true;
        }

        private void CarControl_Click(object sender, EventArgs e)
        {
            var carControl = new CarControl(_carService);
            carControl.Dock = DockStyle.Fill;
            this.Controls.Add(carControl);
            carControl.Visible = true;
        }

        private void OrderControl_Click(object sender, EventArgs e)
        {
            var orderControl = new OrderControl(_clientService, _carService, _orderService, _serviceService);
            orderControl.Dock = DockStyle.Fill;
            this.Controls.Add(orderControl);
            orderControl.Visible = true;
        }

        private void ServiceControl_Click(object sender, EventArgs e)
        {
            var serviceControl = new ServiceControl(_serviceService);
            serviceControl.Dock = DockStyle.Fill;
            this.Controls.Add(serviceControl);
            serviceControl.Visible = true;
        }
    }
}
