using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgenciaSeguros
{
    public partial class FormularioPolizas : Form
    {
        public FormularioPolizas()
        {
            InitializeComponent();
        }

        private void BuscarCliente(object sender, EventArgs e)
        {
            BuscarCliente bc = new BuscarCliente();
            bc.ShowDialog();
            if(bc.DialogResult == DialogResult.OK)
            {
                txtIdCli.Text = bc.tablaClientes.CurrentRow.Cells[0].Value.ToString();
                txtNomCli.Text = bc.tablaClientes.CurrentRow.Cells[1].Value.ToString() + " " +
                    bc.tablaClientes.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void Aceptar(object sender, EventArgs e)
        {
            // Control de errores
            if (!txtNum.Text.ToString().Equals("") &&
                !txtImporte.Text.ToString().Equals("") &&
                !cbEstado.Text.ToString().Equals("") &&
                !txtIdCli.Text.ToString().Equals("ID"))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                lblError.Visible = true;
        }

        private void txtIdCli_TextChanged(object sender, EventArgs e)
        {
            String sql = $"SELECT nombre, apellidos FROM CLIENTES WHERE ID = {txtIdCli.Text}";
            Conexion.SetComando(sql);
           // ResultSet result = comando.ExecuteQuery();
        }
    }
}
