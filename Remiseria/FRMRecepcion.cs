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
    public partial class FRMRecepcion : Form
    {
        Customers o_customer;

        public FRMRecepcion()
        {
            InitializeComponent();
        }
        private void FRMRecepcion_Load(object sender, EventArgs e)
        {
            CMBDrivers.DataSource = Driver.GetListDriver();
        }
        private void BTNFind_Click(object sender, EventArgs e)
        {
            if( ValidBlanks_Authenticate() )
            {
                o_customer = Customers.FindCustomer(Convert.ToInt32(MTXCode.Text));

                if (o_customer.Equals(new Customers()))
                {
                    LBLEstado.Text = "Cliente Encontrado!";

                    CustomerCompletBlanks(o_customer);

                    GRPAuthenticate.Enabled = false;
                    GRPCustomer.Enabled = false;
                    GRPTravel.Enabled = true;

                    MTXCode.Text = "";
                }
                else
                {
                    LBLEstado.Text = "Cliente NO encontrado";
                    BTNGenerate.Enabled = true;
                
                    MTXCode.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ingese un codigo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            LBLEstado.Text = "Codigo generado!";
            LBLCode_Content.Text = Customers.GenerateCode(rnd).ToString();

            GRPAuthenticate.Enabled = false;
            GRPCustomer.Enabled = true;
            MTXCode.Text = "";
        }
        private void BTNRegister_Click(object sender, EventArgs e)
        {
            if (ValidBlanks_Customer())
            {
                o_customer = new Customers(code_p: Convert.ToInt32(LBLCode_Content.Text), name_p: TXTName.Text, surname_p: TXTSurname.Text, birthDay_p: DTPBirthDay.Value, telephone_p: Convert.ToInt32(NUDTelephone.Value));
                o_customer.SaveCustomer();

                GRPCustomer.Enabled = false;
                GRPTravel.Enabled = true;

                VaciarCampos();
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNOrderTravel_Click(object sender, EventArgs e)
        {
            if (ValidBlanks_OrderTravel())
            {
                Car car_p;

                List<Car> listaFreeCars = new List<Car>();

                foreach (Car c in Car.GetListCar())
                {
                    if (c.Disponible)
                    {
                        listaFreeCars.Add(c);
                    }
                }

                if (listaFreeCars.Count <= 1)
                {
                    MessageBox.Show("No hay autos libres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    car_p = listaFreeCars.Last();

                    Travels travel = new Travels(TXTDeparture.Text, TXTDestiny.Text, DTPDuration.Value, true, car_p);
                    travel.Save();

                    car_p.OcuparAuto();

                    LoadGDVTravels(Travels.ListTravels);

                    GRPAuthenticate.Enabled = true;
                    GRPTravel.Enabled = false;
                    BTNFind.Enabled = true;
                    MTXCode.Enabled = true;
                    BTNRegister.Enabled = true;

                    TXTDeparture.Text = "";
                    TXTDestiny.Text = "";
                    DTPDuration.Value = new DateTime(2001, 1, 1);

                    VaciarCampos();

                    GRPDriver.Enabled = true;
                }
            }
        }

        public void LoadGDVTravels(List<Travels> listaTravel)
        {
            DGVTravels.DataSource = null;
            DGVTravels.DataSource = listaTravel;
        }

        private void BTNCancelTravel_Click(object sender, EventArgs e)
        {
            if (DGVTravels.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow fila in DGVTravels.SelectedRows)
                {
                    Travels t = fila.DataBoundItem as Travels;
                    t.Car_o.OcuparAuto();
                }

                LoadGDVTravels(Travels.ListTravels);

                GRPAuthenticate.Enabled = true;
                GRPCustomer.Enabled = false;
                GRPTravel.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe Seleccionar al menos 1 viaje.", "Error");
            }
        }

        private void BTNArrived_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in DGVTravels.SelectedRows)
            {
                Travels t = fila.DataBoundItem as Travels;
                t.Car_o.DesocuparAuto();
            }

            LoadGDVTravels(Travels.ListTravels);
        }

        private void BTNViewCar_Click(object sender, EventArgs e)
        {
            Travels travel;

            foreach (DataGridViewRow fila in DGVTravels.SelectedRows)
            {
                travel = fila.DataBoundItem as Travels;
                MessageBox.Show(travel.Car_o.ToString(), "Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void VaciarCampos()
        {
            TXTName.Text = "";
            TXTSurname.Text = "";
            DTPBirthDay.Value = new DateTime(2001, 1, 1);
            LBLCode_Content.Text = "";
        }
        public void CustomerCompletBlanks(Customers customer)
        {
            GRPCustomer.Enabled = false;
            TXTName.Text = customer.Name;
            TXTSurname.Text = customer.Surname;
            // DTPBirthDay.Value = customer.BirthDay;
            LBLCode_Content.Text = customer.Code.ToString();
        }
        public bool ValidBlanks_Customer()
        {
            return ((TXTName.Text != "") && (TXTSurname.Text != "") && (DTPBirthDay.Text != "") && (LBLCode_Content.Text != ""));
        }
        public bool ValidBlanks_OrderTravel()
        {
            return ((TXTDestiny.Text != "") && (TXTDeparture.Text != "") && (DTPDuration.Value != new DateTime()));
        }
        public bool ValidBlanks_CancelTravel()
        {
            return ((TXTDestiny.Text != "") && (TXTDeparture.Text != ""));
        }
        public bool ValidBlanks_Authenticate()
        {
            return (MTXCode.Text != "");
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (CMBDrivers.SelectedIndex != -1)
            {
                Driver driver = CMBDrivers.SelectedItem as Driver;

                driver.Earn(NUDEarn.Value);

                MessageBox.Show("Guardado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CMBDrivers.Text = "";
                NUDEarn.Value = NUDEarn.Minimum;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Chofer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
