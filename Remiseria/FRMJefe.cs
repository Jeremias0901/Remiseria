using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria
{
    public partial class FRMJefe : Form
    {
        public FRMJefe()
        {
            InitializeComponent();
        }

        private void TMRReloj_Tick(object sender, EventArgs e)
        {
            LBLReloj.Text = string.Format("{0:T}", DateTime.Now);
        }

        private void BTNFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
