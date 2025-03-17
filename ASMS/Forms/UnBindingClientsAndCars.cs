using ASMS.Base.Entities;
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
    public partial class UnBindingClientsAndCars : Form
    {
        private readonly IClientsCarService _clientsCarService;
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;

        private int ClientId = 0;
        private int CarId = 0;
        private ClientDTO _client;
        public UnBindingClientsAndCars(IClientsCarService clientsCarService, IEntityService<ClientDTO> clientService,
                                       IEntityService<CarDTO> carService, ClientDTO client)

        {
            _clientsCarService = clientsCarService;
            _clientService = clientService;
            _carService = carService;
            _client = client;
            InitializeComponent();
        }
        private void UnBindingClientsAndCars_Load(object sender, EventArgs e)
        {
            var clients = _clientService.Get();
            comboBoxClients.DataSource = clients;
            comboBoxClients.DisplayMember = "Name";
            comboBoxClients.ValueMember = "Id";
            comboBoxClients.SelectedValue = _client.Id;
            ClientId = _client.Id;
        }
        private void comboBoxClients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClients.SelectedItem is ClientDTO selectedClient)
            {
                ClientId = selectedClient.Id;
                comboBoxCars.ResetText();

            }
        }

        private void comboBoxCars_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxCars.SelectedItem is CarDTO selectedCar)
            {
                CarId = selectedCar.Id;
            }

        }
        private void comboBoxCars_DropDown(object sender, EventArgs e)
        {
            var cars = _clientsCarService.GetClientCars(ClientId);
            comboBoxCars.DataSource = cars;
            comboBoxCars.DisplayMember = "DisplayText";
            comboBoxCars.ValueMember = "Id";
        }
        private void comboBoxClients_DropDown(object sender, EventArgs e)
        {
      
        }
        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BindButton_Click(object sender, EventArgs e)
        {
            try
            {
                _clientsCarService.RemoveCarFromClient(ClientId, CarId);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCars_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
