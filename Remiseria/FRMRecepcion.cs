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
            
        }
        private void BTNFind_Click(object sender, EventArgs e)
        {
            if ( ValidBlanks_Authenticate() )
            {
                o_customer = Customers.Find(Convert.ToInt32(MTXCode.Text));

                if (!o_customer.Equals(new Customers()))
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
                o_customer.Save();

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
                Travels travel = new Travels(TXTDeparture.Text, TXTDestiny.Text, DTPDuration.Value, true);

                o_customer.OrderTravel(travel);

                DGVTravels.DataSource = null;
                DGVTravels.DataSource = Customers.Find();

                GRPAuthenticate.Enabled = true;
                GRPTravel.Enabled = false;
                BTNFind.Enabled = true;
                MTXCode.Enabled = true;
                BTNRegister.Enabled = true;

                TXTDeparture.Text = "";
                TXTDestiny.Text = "";
                DTPDuration.Value = new DateTime(2001, 1, 1);
            }
        }

        private void BTNCancelTravel_Click(object sender, EventArgs e)
        {
            if (ValidBlanks_OrderTravel())
            {
                Travels travel = new Travels(TXTDeparture.Text, TXTDestiny.Text, new DateTime(2000, 1, 1), false);

                o_customer.SaveTravel(travel);

                GRPAuthenticate.Enabled = true;
                GRPCustomer.Enabled = false;
                GRPTravel.Enabled = false;
            }
        }

        private void BTNArrived_Click(object sender, EventArgs e)
        {

        }

        private void BTNViewCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AUTO");
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
            return ((TXTDestiny.Text != "") && (TXTDeparture.Text != "") && (DTPDuration.Text != ""));
        }
        public bool ValidBlanks_CancelTravel()
        {
            return ((TXTDestiny.Text != "") && (TXTDeparture.Text != ""));
        }
        public bool ValidBlanks_Authenticate()
        {
            return ((MTXCode.Text.Length == 6) && (MTXCode.Text != ""));
        }
    }
}
