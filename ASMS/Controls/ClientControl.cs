using ASMS.Base.Entities;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using ASMS.Forms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASMS.Forms.Controlls
{
    public partial class ClientControl : UserControl
    {
        private readonly IEntityService<ClientDTO> _clientService;
        private readonly IEntityService<CarDTO> _carService;
        private readonly IClientsCarService _clientsCarService;
        private ClientDTO _clientDTO = new ClientDTO();
        public ClientControl(IEntityService<ClientDTO> clientService, IClientsCarService clientsCarService, IEntityService<CarDTO> carService)
        {
            _clientService = clientService;
            _clientsCarService = clientsCarService;
            _carService = carService;
            InitializeComponent();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void LoadClients()
        {
            var clients = _clientService.Get();
            dataGridViewClients.DataSource = clients;
        }

        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow == null) return;
            {
                var selectedRow = dataGridViewClients.CurrentRow;

                try
                {
                    _clientDTO.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    _clientDTO.Name = selectedRow.Cells["Name"].Value.ToString();
                    _clientDTO.Phone = selectedRow.Cells["Phone"].Value.ToString();
                    _clientDTO.BirthDay = Convert.ToDateTime(selectedRow.Cells["BirthDay"].Value).ToUniversalTime().Date;
                 
                    selectedRow.Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void buttonAddGetClient_Click(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm(_clientService);
            addClientForm.ShowDialog();
            LoadClients();
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            if (_clientDTO != null)
            {
                var updateClientForm = new UpdateClientForm(_clientService, _clientDTO);
                updateClientForm.ShowDialog();
                LoadClients();
            }
            else
            {
                MessageBox.Show("Выберите клиента для редактирования.");
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (_clientDTO != null)
            {
                _clientService.Remove(_clientDTO);
                LoadClients();
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BindingButton_Click(object sender, EventArgs e)
        {
            var bindingForm = new BindingClientsAndCars(_clientsCarService, _clientService, _carService);
            bindingForm.ShowDialog();

        }

        private void unBindButton_Click(object sender, EventArgs e)
        {
            if (_clientDTO != null)
            {
                var unBingingForm = new UnBindingClientsAndCars(_clientsCarService, _clientService, _carService, _clientDTO);
                unBingingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
        }

        private void ShowClientsCars_Click(object sender, EventArgs e)
        {
            if (_clientDTO != null)
            {
                var clientCarsList = _clientsCarService.GetClientCars(_clientDTO.Id);
                Form carsForm = new Form
                {
                    Text = $"Машины клиента - {_clientDTO.Name}",
                    Size = new Size(1200, 400),
                    StartPosition = FormStartPosition.CenterParent
                };

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    
                    DataSource = clientCarsList
                };

                carsForm.Controls.Add(dgv);
                carsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите клиента!");
            }
        }
    }
}
