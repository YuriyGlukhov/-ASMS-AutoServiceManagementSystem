using ASMS.Base.Models;
using ASMS.Forms.Abstraction;
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

namespace ASMS.Forms.Forms
{
    public partial class AddClientForm : Form
    {
        private readonly IEntityService<ClientDTO> _clientService;
        public AddClientForm(IEntityService<ClientDTO> clientService)
        {
            InitializeComponent();
            _clientService = clientService;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string phone = textBox4.Text;
            string birthDateText = maskedTextBox1.Text;
            try
            {
                DateTime birthDate;
                if (DateTime.TryParseExact(birthDateText, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
                {

                    var client = new ClientDTO
                    {
                        Name = name,
                        Phone = phone,
                        BirthDay = birthDate.ToUniversalTime()
                    };

                    _clientService.Add(client);
                }
                else
                {
                    MessageBox.Show("Некорректный формат даты. Пожалуйста, введите дату в формате: dd.MM.yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
