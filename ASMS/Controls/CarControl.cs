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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ASMS.Forms.Controls
{
    public partial class CarControl : UserControl
    {
        private readonly IEntityService<CarDTO> _carService;
        private CarDTO carDTO = new CarDTO();
        public CarControl(IEntityService<CarDTO> carService, IClientsCarService clientsCarService,
                          IEntityService<ClientDTO> clientService)
        {
            _carService = carService;
            InitializeComponent();
        }
        private void CarControl_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            var cars = _carService.Get();
            dataGridViewCars.DataSource = cars;
        }
        private void dataGridViewCars_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCars.CurrentRow == null) return;
            {
                var selectedRow = dataGridViewCars.CurrentRow;
                try
                {
                    carDTO.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    carDTO.RegNumber = selectedRow.Cells["RegNumber"].Value.ToString();
                    carDTO.Brand = selectedRow.Cells["Brand"].Value.ToString();
                    carDTO.Model = selectedRow.Cells["Model"].Value.ToString();
                    carDTO.Vin = selectedRow.Cells["Vin"].Value.ToString();
                    carDTO.Year = Convert.ToInt32(selectedRow.Cells["Year"].Value.ToString());

                    selectedRow.Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonGetCars_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            var addCarForm = new AddCarForm(_carService);
            addCarForm.ShowDialog();
            LoadCars();
        }

        private void buttonUpdateCar_Click(object sender, EventArgs e)
        {
            if (carDTO != null)
            {
                var updateCarFomr = new UpdateCarForm(_carService, carDTO);
                updateCarFomr.ShowDialog();
                LoadCars();
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для изменения.");
            }
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            if (carDTO != null)
            {
                try
                {
                    _carService.Remove(carDTO);
                    LoadCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Невозможно удалить авто, так как на нем есть связанные заказы.\n" +
                                    $"{ex.Message}", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите автомобиль для удаления.");
            }
        }

    }
}
