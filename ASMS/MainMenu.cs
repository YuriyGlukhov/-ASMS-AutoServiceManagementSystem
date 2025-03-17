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
        private readonly IClientsCarService _clientsCarService;
        public MainMenu(IEntityService<ClientDTO> clientService,
                    IEntityService<CarDTO> carService,
                    IEntityService<OrderDTO> orderService,
                    IEntityService<ServiceDTO> serviceService,
                    IClientsCarService clientsCarService,
                    ASMSDbContext context)
        {
            _clientService = clientService;
            _carService = carService;
            _orderService = orderService;
            _serviceService = serviceService;
            _clientsCarService = clientsCarService;
            _context = context;
            InitializeComponent();
            LoadControl();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadControl()
        {
            var clientControl = new ClientControl(_clientService, _clientsCarService, _carService);
            clientControl.Dock = DockStyle.Fill;
            ControlMenu?.SelectedTab?.Controls.Add(clientControl);
        }
        private void ControlMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = ControlMenu.SelectedTab;
            if (selectedTab == null) return;

            selectedTab.Controls.Clear();

            switch (selectedTab.Name)
            {
                case "ClientControl":
                    var clientControl = new ClientControl(_clientService, _clientsCarService, _carService) { Dock = DockStyle.Fill };
                    selectedTab.Controls.Add(clientControl);
                    break;

                case "CarControl":
                    var carControl = new CarControl(_carService, _clientsCarService,_clientService) { Dock = DockStyle.Fill };
                    selectedTab.Controls.Add(carControl);
                    break;

                case "OrderControler":
                    var orderControl = new OrderControl(_clientService, _carService, _orderService, _serviceService,_clientsCarService) { Dock = DockStyle.Fill };
                    selectedTab.Controls.Add(orderControl);
                    break;

                case "ServiceControl":
                    var serviceControl = new ServiceControl(_serviceService) { Dock = DockStyle.Fill };
                    selectedTab.Controls.Add(serviceControl);
                    break;
            }
        }

        private void ClientControl_Click(object sender, EventArgs e)
        {

        }
    }
}
