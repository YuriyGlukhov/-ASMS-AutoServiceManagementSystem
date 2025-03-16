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
        private ClientDTO _clientDTO;
        public ClientControl(IEntityService<ClientDTO> clientService)
        {
            _clientService = clientService;
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

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewClients.Rows[e.RowIndex];

                try
                {
                    _clientDTO = new ClientDTO
                    {
                        Id = Convert.ToInt32(selectedRow.Cells["Id"].Value),
                        Name = selectedRow.Cells["Name"].Value.ToString(),
                        Phone = selectedRow.Cells["Phone"].Value.ToString(),
                        BirthDay = Convert.ToDateTime(selectedRow.Cells["BirthDay"].Value).ToUniversalTime()
                    };

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

            // Проверка на null перед использованием _clientDTO
            if (_clientDTO != null)
            {
                var updateClientForm = new UpdateClientFrom(_clientService, _clientDTO);
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
            // Проверка на null перед удалением
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
    }
}
