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
                    CustomerCompletBlanks(o_customer);

                    LBLEstado.ChangeText("Cliente Encontrado!");
                    MTXCode.ChangeText("");
                    GRPAuthenticate.ActivarDesactivar(false);
                    GRPCustomer.ActivarDesactivar(false);
                    GRPTravel.ActivarDesactivar(true);
                }
                else
                {
                    LBLEstado.ChangeText("Cliente NO encontrado");
                    MTXCode.ChangeText("");
                    BTNGenerate.ActivarDesactivar(true);
                }
            }
            else
            {
                MessageBox.Show("Ingese un codigo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNGenerate_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();

            //LBLEstado.Text = "Codigo generado!";
            //LBLCode_Content.Text = Customers.GenerateCode(rnd).ToString();

            GRPAuthenticate.ActivarDesactivar(false);
            GRPCustomer.ActivarDesactivar(true);
            MTXCode.ChangeText("");
        }

        private void BTNRegister_Click(object sender, EventArgs e)
        {
            if (ValidBlanks_Customer())
            {
                o_customer = new Customers(name_p: TXTName.Text, surname_p: TXTSurname.Text, birthDay_p: DTPBirthDay.Value, telephone_p: Convert.ToInt32(NUDTelephone.Value));
                o_customer.SaveCustomer();
                MostrarCodigo(o_customer);

                GRPCustomer.ActivarDesactivar(false);
                GRPTravel.ActivarDesactivar(false);
            }
            else
            {
                MessageBox.Show("Complete correctamente todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MostrarCodigo(Customers customer)
        {
            MessageBox.Show(string.Format("El codigo de es {0}", customer.GetCodigo().ToString()), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BTNOrderTravel_Click(object sender, EventArgs e)
        {
            if (ValidBlanks_OrderTravel())
            {
                Car car_p;

                if (Car.GetFreeCars().Count <= 1)
                {
                    MessageBox.Show("No hay autos libres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    car_p = Car.GetFreeCars().Last();
                    
                    TimeSpan timespan;
                    TimeSpan.TryParse(DTPDuration.Value.ToString(), out timespan);

                    Travels travel = new Travels(TXTDeparture.Text, TXTDestiny.Text, timespan, true, car_p);
                    travel.Save();

                    car_p.OcuparAuto();

                    LoadGDVTravels(Travels.ListTravels);

                    GRPAuthenticate.ActivarDesactivar(true);
                    GRPTravel.ActivarDesactivar(false);
                    BTNFind.ActivarDesactivar(true);
                    MTXCode.ActivarDesactivar(true);
                    BTNRegister.ActivarDesactivar(true);

                    TXTDeparture.ChangeText("");
                    TXTDestiny.ChangeText("");
                    DTPDuration.Value = new DateTime(2001, 1, 1);

                    VaciarCampos();

                    GRPDriver.ActivarDesactivar(true);
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
            if (DGVTravels.SelecionaronFilas())
            {
                foreach (DataGridViewRow fila in DGVTravels.SelectedRows)
                {
                    Travels t = fila.DataBoundItem as Travels;
                    t.GetCar().OcuparAuto();
                }

                LoadGDVTravels(Travels.ListTravels);

                GRPAuthenticate.ActivarDesactivar(true);
                GRPCustomer.ActivarDesactivar(false);
                GRPTravel.ActivarDesactivar(false);
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
                t.GetCar().DesocuparAuto();
            }

            LoadGDVTravels(Travels.ListTravels);
        }

        private void BTNViewCar_Click(object sender, EventArgs e)
        {
            Travels travel;

            foreach (DataGridViewRow fila in DGVTravels.SelectedRows)
            {
                travel = fila.DataBoundItem as Travels;
                MessageBox.Show(travel.GetCar().ToString(), "Auto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            GRPCustomer.ActivarDesactivar(false);
            TXTName.ChangeText(customer.GetName());
            TXTSurname.ChangeText(customer.GetSurname());
            LBLCode_Content.ChangeText(customer.GetCodigo().ToString());
            // DTPBirthDay.Value = customer.BirthDay;
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
