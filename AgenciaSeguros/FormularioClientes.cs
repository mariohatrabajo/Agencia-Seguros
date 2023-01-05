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
    public partial class FormularioClientes : Form
    {
        public FormularioClientes()
        {
            InitializeComponent();
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataset_municipios.municipios' Puede moverla o quitarla según sea necesario.
            this.municipiosTableAdapter.Fill(this.dataset_municipios.municipios);
            // TODO: esta línea de código carga datos en la tabla 'dataset_provincias.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dataset_provincias.provincias);
        }
        private void comboBoxProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProv.SelectedValue != null)
            {
                cbMun.Enabled = true;
                string sql = "SELECT id, municipio from MUNICIPIOS WHERE provincia = " + cbProv.SelectedValue;

                Conexion.SetComando(sql);

                MySqlDataAdapter da1 = new MySqlDataAdapter(Conexion.comando);
                DataTable dt = new DataTable();
                da1.Fill(dt);

                cbMun.ValueMember = "id";
                cbMun.DisplayMember = "municipio";
                cbMun.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("Nombre") &&
                !txtApell.Text.Equals("Apellidos") &&
                (txtCP.Text.Length == 5) &&
                (txtDNI.Text.Length == 10) &&
                (txtTlf.Text.Length == 9) &&
                (rbEmp.Checked || rbPart.Checked))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                lblError.Visible = true;
        }
    }
}
