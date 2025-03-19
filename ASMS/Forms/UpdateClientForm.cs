using ASMS.Base.Entities;
using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
using ASMS.Forms.Controlls;
using ASMS.Forms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASMS.Forms.Forms
{
    public partial class UpdateClientForm : Form
    {
        private readonly IEntityService<ClientDTO> _clientService;
        private ClientDTO _client;

        public UpdateClientForm(IEntityService<ClientDTO> clientService, ClientDTO client)
        {
            _clientService = clientService;
            _client = client;
            InitializeComponent();

            NameBox.Text = _client.Name;
            PhoneBox.Text = _client.Phone;
            BithdayBox.Text = _client.BirthDay.ToString("dd.MM.yyyy");
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            _client.Name = NameBox.Text;
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            _client.Phone = PhoneBox.Text;
        }

        private void BithdayBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Некорректный формат даты. Пожалуйста, используйте формат dd/MM/yyyy.");
        }
        private void BithdayBox_TextChanged(object sender, EventArgs e)
        {
            string birthDateText = BithdayBox.Text;

            string cleanDateText = birthDateText.Replace("/", "").Replace("-", "").Replace(".", "");

            if (cleanDateText.Length == 8) 
            {
                DateTime birthDate;
                if (DateTime.TryParseExact(cleanDateText, "ddMMyyyy", CultureInfo.InvariantCulture, 
                                           DateTimeStyles.None, out birthDate))
                {
                    _client.BirthDay = birthDate.ToUniversalTime(); 
                }
                else
                {
                    MessageBox.Show("Некорректный формат даты.");
                }
            }
        }

        private void UpdateClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                _clientService.UpDate(_client);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateClientFrom_Load(object sender, EventArgs e)
        {
            
        }
    }
}
