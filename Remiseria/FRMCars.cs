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
            SubirCarCMB();
        }

        private void BTNAssignment_Click(object sender, EventArgs e)
        {
            if (CMBDriver.SelectedIndex >= 0 && CMBCar.SelectedIndex >= 0)
            {
                // Obtener un objeto desde un ComboBox
                Driver driver = CMBDriver.SelectedItem as Driver;

                driver.AsignarAuto(CMBCar.SelectedItem as Car);

                CMBCar.Text = "";
                CMBDriver.Text = "";

                MessageBox.Show("Chofer asignado.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void SubirDriverCMB()
        {
            // Cargar solo los choferes que llegaron
            foreach (Driver d in Driver.GetListDriver())
            {
                if (d.IncomeLocal != new DateTime())
                {
                    CMBDriver.Items.Add(d);
                }
            }
        }
        public void SubirCarCMB()
        {
            foreach (Car c in Car.GetListCar())
            {
                CMBCar.Items.Add(c);
            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if (TXTBland.Text != "" && TXTColor.Text != "" && TXTModel.Text != "")
            {
                Car car = new Car(MTXPatent.Text, TXTBland.Text, TXTModel.Text, TXTColor.Text, 0);

                car.SaveCar();

                SubirCarCMB();

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
