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
    public partial class BindingClientsAndCars : Form
    {
        private readonly IClientsCarService _clientsCarService;
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;
       

        private int CarID = 0;
        private int ClientID = 0;
        public BindingClientsAndCars(IClientsCarService clientsCarService, 
                                     IEntityService<ClientDTO> clientService, 
                                     IEntityService<CarDTO> carService)
        {
            _clientsCarService = clientsCarService;
            _carService = carService;
            _clientService = clientService;
            InitializeComponent();
        }
        private void BindButton_Click(object sender, EventArgs e)
        {

            _clientsCarService.AddCarToClient(ClientID, CarID);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem is ClientDTO selectedClient)
            {
                ClientID = selectedClient.Id;

            }
        }

        private void comboBoxCars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCars.SelectedItem is CarDTO selectedCar)
            {
                CarID = selectedCar.Id;

            }

        }
        private void comboBoxCars_DropDown(object sender, EventArgs e)
        {
            var cars = _carService.Get();
            comboBoxCars.DataSource = cars;
            comboBoxCars.DisplayMember = "DisplayText";
            comboBoxCars.ValueMember = "Id";
        }
        private void comboBoxClients_DropDown(object sender, EventArgs e)
        {
            var clients = _clientService.Get();
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "Name";
            comboBoxClients.ValueMember = "Id";
        }
        private void BindingClientsAndCars_Load(object sender, EventArgs e)
        {

        }
    }
}
