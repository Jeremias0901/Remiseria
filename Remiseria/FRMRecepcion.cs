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
        FRMJefe formJefe = new FRMJefe();

        public FRMRecepcion()
        {
            InitializeComponent();
        }

        private void FRMRecepcion_Load(object sender, EventArgs e)
        {
            formJefe.Show();
        }

        private void BTNFind_Click(object sender, EventArgs e)
        {
            if ( FindedCode(MTXCode.Text.ToCharArray()) )
            {
                LBLEstado.Text = "Cliente Encontrado!";

                CustomerCompletBlanks(FindCode(MTXCode.Text.ToCharArray()));
            }
            else
            {
                LBLEstado.Text = "Cliente NO encontrado ";
            }
        }

        public Customers FindCode(char[] code_p)
        {
            Customers customer_result = new Customers();

            foreach(Customers c in Customers.List)
            {
                if(Char.Equals(c.Code, code_p))
                {
                    customer_result = c;
                }
            }

            return customer_result;
        }
        public bool FindedCode(char[] code_p)
        {
            bool result = false;

            foreach (Customers c in Customers.List)
            {
                if (Char.Equals(c.Code, code_p))
                {
                    result = true;
                }
            }

            return result;
        }
        public void CustomerCompletBlanks(Customers customer)
        {
            GRPCustomer.Enabled = false;
            LBLName.Text = customer.Name;
            LBLSurname.Text = customer.Surname;
            DTPBirthDay.Value = customer.BirthDay;
            LBLCode.Text = customer.Code.ToString();
        }

        private void BTNGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            LBLEstado.Text = "Codigo generado!";
            LBLCode.Text = GenerateCode(rnd).ToString();

            GRPAuthenticate.Enabled = false;
        }

        public char[] GenerateCode(Random rnd)
        {
            char[] code_p = new char[6];

            do{
                for (int i = 0; i < 6; i++)
                {
                    while (!char.IsLetterOrDigit(code_p[i]))
                    {
                        code_p[i] = Convert.ToChar(rnd.Next());
                    }
                }
            } while (FindedCode(code_p));

            return code_p;
        }

        private void BTNRegister_Click(object sender, EventArgs e)
        {
            Customers o_customer;

            o_customer = new Customers(code_p: TXTName.Text.ToCharArray(), name_p:TXTName.Text, surname_p: TXTSurname.Text, birthDay_p: DTPBirthDay.Value);
            Customers.List.Add(o_customer);
        }

        private void BTNOrderTravel_Click(object sender, EventArgs e)
        {
            Travels viaje = new Travels(placeDeparture_p: TXTDeparture.Text, placeDestiny_p: TXTDestiny.Text, timeDeparture_p: DateTime.Now, timeDestiny_p: , duration_p: DTPDelay.Value, estado_p: true);
        }
    }
}
