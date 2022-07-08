using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria
{
    static class Tools
    {
        static public void ActivarDesactivar(this Control control, bool enable)
        {
            control.Enabled = enable;
        }
        static public void ChangeText(this Control control, string texto)
        {
            control.Text = texto;
        }
        static public bool SelecionaronFilas(this DataGridView dataGridView)
        {
            return dataGridView.SelectedRows.Count >= 1;
        }
        static public bool Validated(Control.ControlCollection listaControles)
        {
            foreach (Control c in listaControles)
            {
                if (c.Text == "")
                {
                    return false;
                }
            }

            return true;
        }
    }
}
