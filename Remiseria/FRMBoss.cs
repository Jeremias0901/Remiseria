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
            foreach (Driver driver in GetAusentes())
            {
                driver.Absent();
            }
            
            FRMCars frmCars = new FRMCars();

            frmCars.ShowDialog();
            this.Hide();
        }

        private void FRMBoos_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadListDrivers(DataGridView DGV, List<Driver> lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if(CamposValidos())
            {
                car = new Car();
                driver = new Driver(TXTName.Text, TXTSurname.Text, car, Convert.ToInt32(NUDTelephone.Value), 0, 0, DTPBirthDay.Value);

                driver.SaveDrivers();

                LoadListDrivers(DGVDrivers, Driver.GetListDriver());

                VaciarCampos();
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CamposValidos()
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
                List<Driver> listaDriverPresents = Driver.GetListDriver();

                foreach (DataGridViewRow fila in DGVDrivers.SelectedRows)
                {
                    driver = fila.DataBoundItem as Driver;

                    driver.Arrived();

                    listaDriverPresents.Remove(driver);
                }

                LoadListDrivers(DGVDrivers, listaDriverPresents);
            }
        }
        private void BTNArrived_Click(object sender, EventArgs e)
        {
            if (DGVDriversLate.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos 1 chofer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Driver> listaDriverLast = DGVDriversLate.DataSource as List<Driver>;
                
                foreach (DataGridViewRow fila in DGVDriversLate.SelectedRows)
                {
                    driver = fila.DataBoundItem as Driver;

                    driver.Arrived();

                    listaDriverLast.Remove(driver);
                }

                LoadListDrivers(DGVDriversLate, listaDriverLast);
            }
        }
        private void BTNContinue_Click(object sender, EventArgs e)
        {
            if ( Driver.GetListDriver().Count >= 1 )
            {
                GRPAddDriver.Enabled = false;
                BTNPresentDrivers.Enabled = false;
                BTNContinue.Enabled = false;

                DGVDriversLate.DataSource = GetAusentes();

                DGVDriversLate.Enabled = true;
                BTNArrived.Enabled = true;
                BTNFinish.Enabled = true;
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
                if(d.IncomeLocal.Count == 0)
                {
                    lista_result.Add(d);
                }
            }

            return lista_result;
        }
    }
}
