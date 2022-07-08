using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clases;

namespace Remiseria
{
    public partial class FRMCars : Form
    {
        public FRMCars()
        {
            InitializeComponent();
        }
        
        private void FRMCars_Load(object sender, EventArgs e)
        {
            SubirDriverCMB();
            SubirCarCMB(Car.GetListCar());
        }

        private void BTNAssignment_Click(object sender, EventArgs e)
        {
            if (CMBDriver.SelectedIndex >= 0 && CMBCar.SelectedIndex >= 0)
            {
                Driver driver = CMBDriver.SelectedItem as Driver;

                driver.AsignarAuto(CMBCar.SelectedItem as Car);
                // SacarCMBCar(CMBCar.SelectedItem as Car);
                // SacarCMBDriver(CMBDriver.SelectedItem as Driver);

                CMBCar.Text = "";
                CMBDriver.Text = "";

                MessageBox.Show("Chofer asignado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        public void SacarCMBCar(Car car_p)
        {
            List<Car> lista = new List<Car>();
            lista = CMBCar.DataSource as List<Car>;
            lista.Remove(car_p);
            CMBCar.DataSource = lista;
            
        }

        public void SacarCMBDriver(Driver driver_p)
        {
            List<Driver> lista = new List<Driver>();
            lista = CMBDriver.DataSource as List<Driver>;
            lista.Remove(driver_p);
            CMBDriver.DataSource = lista;
        }
        */
        public void SubirDriverCMB()
        {
            // Carga los choferes presentes

            if (Driver.GetAusentesDrivers().Count >= 1)
            {
                CMBDriver.DataSource = Driver.GetAusentesDrivers();
            }
            else
            {
                MessageBox.Show("Lista de conductores presentes vacia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SubirCarCMB(List<Car> listaCar)
        {
            CMBCar.DataSource = null;
            CMBCar.DataSource = listaCar;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if (TXTBland.Text != "" && TXTColor.Text != "" && TXTModel.Text != "")
            {
                Car car = new Car(MTXPatent.Text, TXTBland.Text, TXTModel.Text, TXTColor.Text, 0);

                car.SaveCar();

                SubirCarCMB(Car.GetListCar());

                VaciarCampos();
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VaciarCampos()
        {
            TXTColor.Text = "";
            TXTBland.Text = "";
            TXTModel.Text = "";
            MTXPatent.Text = "";
        }

        private void BTNEnd_Click(object sender, EventArgs e)
        {
            FRMRecepcion frmRecepcion = new FRMRecepcion();

            frmRecepcion.ShowDialog();
            this.Hide();
        }
    }
}
