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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataset_buscarClientes.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataset_buscarClientes.clientes);

        }

        private void buscador_TextChanged(object sender, EventArgs e)
        {
            if (buscador.Text.Length >= 3 && buscador.Text != buscador.Hint)
            {
                for (int i = 0; i < tablaClientes.RowCount; i++)
                {
                    tablaClientes.CurrentCell = null;
                    tablaClientes.Rows[i].Visible = (tablaClientes.Rows[i].Cells[2].Value.ToString().ToUpper().StartsWith(buscador.Text.ToUpper())
                                            || tablaClientes.Rows[i].Cells[3].Value.ToString().StartsWith(buscador.Text));
                }
            }
            else
            {
                for (int i = 0; i < tablaClientes.RowCount; i++)
                {
                    tablaClientes.Rows[i].Visible = true;
                }
            }
        }

        private void Aceptar(object sender, EventArgs e)
        {
            if(tablaClientes.CurrentRow != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
