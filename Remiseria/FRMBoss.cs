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
    public partial class FRMBoss : Form
    {
        Driver driver;
        Car car;

        public FRMBoss()
        {
            InitializeComponent();
        }

        private void TMRReloj_Tick(object sender, EventArgs e)
        {
            LBLReloj.Text = string.Format("{0:hh:mm:ss  dd/MM/yyyy}", DateTime.Now);
        }

        private void BTNFinish_Click(object sender, EventArgs e)
        {
            Boss boss = new Boss();

            foreach (Driver driver in GetAusentes())
            {
                boss.AddAbsences(driver);
            }
            
            FRMCars frmCars = new FRMCars();

            frmCars.Show();
            this.Hide();
        }

        private void FRMBoos_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadListDrivers()
        {
            DGVDrivers.DataSource = null;
            DGVDrivers.DataSource = Driver.GetListDriver();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if(camposValidos())
            {
                car = new Car();
                driver = new Driver(TXTName.Text, TXTSurname.Text, car, Convert.ToInt32(NUDTelephone.Value), 0, 0, DTPSchedule.Value, new DateTime(), new DateTime(), new DateTime(), DTPBirthDay.Value);

                driver.SaveDrivers();

                LoadListDrivers();

                VaciarCampos();
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool camposValidos()
        {
            return (TXTName.Text != "" && TXTSurname.Text != "");
        }

        public void VaciarCampos()
        {
            TXTName.Text = "";
            TXTSurname.Text = "";
            NUDTelephone.Value = 1000000000;
            DTPBirthDay.Value = DTPBirthDay.MinDate;
        }

        private void BTNPresentDrivers_Click(object sender, EventArgs e)
        {
            if (DGVDrivers.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos 1 chofer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow fila in DGVDrivers.SelectedRows)
                {
                    driver = (Driver)fila.DataBoundItem;

                    driver.Arrived();

                    DGVDrivers.ClearSelection();
                }
            }
        }

        private void BTNContinue_Click(object sender, EventArgs e)
        {
            if (Driver.GetListDriver() != null)
            {
                if(!GetAusentes().Equals(new List<Driver>()))
                {
                    DGVDriversLate.DataSource = GetAusentes();

                    DGVDriversLate.Enabled = true;
                    BTNArrived.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Lista de Choferes vacia. Agregue a un chofer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Driver> GetAusentes()
        {
            List<Driver> lista_result = new List<Driver>();

            foreach (Driver d in Driver.GetListDriver())
            {
                if(d.IncomeLocal.Equals(new DateTime()))
                {
                    lista_result.Add(d);
                }
            }

            return lista_result;
        }

        private void BTNArrived_Click(object sender, EventArgs e)
        {
            if (DGVDriversLate.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos 1 chofer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow fila in DGVDriversLate.SelectedRows)
                {
                    driver = (Driver)fila.DataBoundItem;

                    driver.Arrived();
                    
                    DGVDrivers.ClearSelection();
                }
            }
        }
    }
}
