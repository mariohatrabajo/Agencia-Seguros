using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaSeguros
{
    public partial class FormularioPagos : Form
    {
        String nPoliza = "";
        public FormularioPagos(String nPoliza)
        {
            InitializeComponent();
            this.nPoliza = nPoliza;
        }

        private void Aceptar(object sender, EventArgs e)
        {
            if (!txtImporte.Text.Equals("Importe"))
                this.DialogResult = DialogResult.OK;
            else
                lblError.Visible = true;
        }
    }
}
