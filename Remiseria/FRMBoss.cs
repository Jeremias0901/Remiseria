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
            FRMCars frmCars = new FRMCars();

            frmCars.ShowDialog();
            this.Close();
        }

        private void FRMBoos_Load(object sender, EventArgs e)
        {
            LoadListDrivers();
        }

        public void LoadListDrivers()
        {
            DGVDrivers.DataSource = null;
            DGVDrivers.DataSource = Driver.GetListDriver();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            car = new Car();
            driver = new Driver(TXTName.Text, TXTSurname.Text, car, Convert.ToInt32(NUDTelephone.Value), 0, 0, DTPSchedule.Value, new DateTime(), new DateTime(), new DateTime(), DTPBirthDay.Value);

            driver.SaveDrivers();

            LoadListDrivers();

            VaciarCampos();
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
            DGVDriversLate.DataSource = GetAusentes();


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

        }
    }
}
