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
    public partial class SeleccionInformes : Form
    {
        public SeleccionInformes()
        {
            InitializeComponent();
        }

        private void Generar(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                VentanaInformes form = new VentanaInformes(cbCliDesde.SelectedValue.ToString(), cbCliHasta.SelectedValue.ToString(), dtpDesde.Value.GetDateTimeFormats()[7], dtpHasta.Value.GetDateTimeFormats()[7]);
                form.ShowDialog();
            }else if (rbEstado.Checked)
            {
                VentanaInformesEstados form = new VentanaInformesEstados(cbCliDesde.SelectedValue.ToString(), cbCliHasta.SelectedValue.ToString(), dtpDesde.Value.GetDateTimeFormats()[7], dtpHasta.Value.GetDateTimeFormats()[7], cbEstado.SelectedValue.ToString());
                form.ShowDialog();
            }
        }

        private void SeleccionInformes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataset_seleccionInformesEstados.polizas' Puede moverla o quitarla según sea necesario.
            this.polizasTableAdapter.Fill(this.dataset_seleccionInformesEstados.polizas);
            // TODO: esta línea de código carga datos en la tabla 'dataset_seleccionInformesClientesHasta.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.dataset_seleccionInformesClientesHasta.clientes);
            // TODO: esta línea de código carga datos en la tabla 'dataset_seleccionInformesClientes.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataset_seleccionInformesClientes.clientes);

        }

        private void rbEstado_CheckedChanged(object sender, EventArgs e)
        {
            cbEstado.Enabled = rbEstado.Checked;
        }
    }
}
