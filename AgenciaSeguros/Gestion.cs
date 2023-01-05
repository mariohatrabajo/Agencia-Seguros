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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataset_pagos.pagos' Puede moverla o quitarla según sea necesario.
            this.pagosTableAdapter.Fill(this.dataset_pagos.pagos);
            // TODO: esta línea de código carga datos en la tabla 'dataset_polizas.polizas' Puede moverla o quitarla según sea necesario.
            this.polizasTableAdapter.Fill(this.dataset_polizas.polizas);
            // TODO: esta línea de código carga datos en la tabla 'dataset_clientes.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataset_clientes.clientes);

            if (tablaClientes.CurrentRow != null)
                tablaClientes.CurrentRow.Selected = false;
            if (tablaPolizas.CurrentRow != null)
                tablaPolizas.CurrentRow.Selected = false;
            if (tablaPagos.CurrentRow != null)
                tablaPagos.CurrentRow.Selected = false;

            tablaPagos.Columns[0].Visible = false;

            // Cargamos las tablas para que no haya que ir a la tab antes de seleccionar un cliente
            tabControl1.SelectedTab = tabPolizas;
            tabControl1.SelectedTab = tabPagos;
            tabControl1.SelectedTab = tabClientes;
        }

        // Busca en el datagridview por apellido o telefono
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

        private void Alta(object sender, EventArgs e)
        {
            String sql = "";
            // Clientes
            if (tabControl1.SelectedTab.Name == "tabClientes")
            {
                FormularioClientes form = new FormularioClientes();
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    String tipo = "Particular";
                    if (form.rbEmp.Checked)
                        tipo = "Empresa";

                    // Alta en la BD
                    sql = $"INSERT INTO Clientes(Nombre, Apellidos, Telefono, DNI, Provincia, Municipio, CP, Tipo) " +
                        $"VALUES('{form.txtNombre.Text}', " +
                        $"'{form.txtApell.Text}', " +
                        $"'{form.txtTlf.Text}', " +
                        $"'{form.txtDNI.Text}', " +
                        $"{form.cbProv.SelectedValue.ToString()}, " +
                        $"{form.cbMun.SelectedValue.ToString()}," +
                        $"'{form.txtCP.Text}', " +
                        $"'{tipo}')";
                    Conexion.SetComando(sql);
                    Conexion.comando.ExecuteNonQuery();
                }
            }// Pólizas
            else if (tabControl1.SelectedTab.Name == "tabPolizas")
            {
                FormularioPolizas form = new FormularioPolizas();
                try
                {
                    // Cargamos el cliente
                    form.txtIdCli.Text = tablaClientes.SelectedRows[0].Cells[0].Value.ToString();
                    form.txtNomCli.Text = tablaClientes.SelectedRows[0].Cells[1].Value.ToString();
                }
                catch (ArgumentOutOfRangeException) { }
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    // Alta en la BD
                    sql = $"INSERT INTO Polizas " +
                        $"VALUES('{form.txtNum.Text}', " +
                        $"{form.txtImporte.Text}, " +
                        $"'{form.dtpFecha.Value.GetDateTimeFormats()[7]} ', " +
                        $"'{form.cbEstado.Text}', " +
                        $"'{form.txtObservaciones.Text}', " +
                        $"{form.txtIdCli.Text})";
                    Conexion.SetComando(sql);
                    try
                    {
                        Conexion.comando.ExecuteNonQuery();
                    }
                    catch (MySqlException) { }
                }
            }// Pagos
            else if (tabControl1.SelectedTab.Name == "tabPagos")
            {
                if (tablaPolizas.SelectedRows.Count > 0)
                {
                    FormularioPagos form = new FormularioPagos(tablaPolizas.SelectedRows[0].Cells[0].Value.ToString());
                    form.txtPoliza.Text = tablaPolizas.SelectedRows[0].Cells[0].Value.ToString();
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        // Alta en la BD
                        sql = $"INSERT INTO Pagos (Importe, Fecha, Poliza)" +
                            $"VALUES({form.txtImporte.Text}," +
                            $"'{form.dtpFecha.Value.GetDateTimeFormats()[7]}'," +
                            $"'{tablaPolizas.SelectedRows[0].Cells[0].Value.ToString()}')";
                        Conexion.SetComando(sql);
                        Conexion.comando.ExecuteNonQuery();
                    }
                }
            }
            ActualizarTablas();
        }

        private void Baja(object sender, EventArgs e)
        {
            Confirmacion conf = new Confirmacion();
            if (conf.ShowDialog() == DialogResult.Yes)
            {
                // Sql que no hace nada 
                String sql = "Delete from pagos where importe < 0";

                // Clientes
                if (tabControl1.SelectedTab.Name == "tabClientes" && tablaClientes.SelectedRows.Count > 0)
                    sql = $"Delete from clientes where id = {tablaClientes.SelectedRows[0].Cells[0].Value.ToString()}";
                //Polizas
                else if (tabControl1.SelectedTab.Name == "tabPolizas" && tablaPolizas.SelectedRows.Count > 0)
                    sql = $"Delete from polizas where numero = '{tablaPolizas.SelectedRows[0].Cells[0].Value.ToString()}'";
                // Pagos
                else if (tabControl1.SelectedTab.Name == "tabPagos" && tablaPagos.SelectedRows.Count > 0)
                    sql = $"Delete from pagos where id = {tablaPagos.SelectedRows[0].Cells[0].Value.ToString()}";

                Conexion.SetComando(sql);
                Conexion.comando.ExecuteNonQuery();
            }
            ActualizarTablas();
        }

        private void Modificacion(object sender, EventArgs e)
        {
            String sql = "";
            // Clientes
            if (tabControl1.SelectedTab.Name == "tabClientes" && tablaClientes.SelectedRows.Count > 0)
            {
                FormularioClientes form = new FormularioClientes();

                // Cambiar el color del texto a negro
                form.txtNombre.ForeColor = Color.Black;
                form.txtApell.ForeColor = Color.Black;
                form.txtTlf.ForeColor = Color.Black;
                form.txtCP.ForeColor = Color.Black;
                form.txtDNI.ForeColor = Color.Black;

                //Cargamos los datos en el formulario
                form.txtNombre.Text = tablaClientes.SelectedRows[0].Cells[1].Value.ToString();
                form.txtApell.Text = tablaClientes.SelectedRows[0].Cells[2].Value.ToString();
                form.txtDNI.Text = tablaClientes.SelectedRows[0].Cells[3].Value.ToString();
                form.txtTlf.Text = tablaClientes.SelectedRows[0].Cells[4].Value.ToString();
                form.cbProv.SelectedValue = tablaClientes.SelectedRows[0].Cells[5].Value;
                form.cbMun.SelectedValue = tablaClientes.SelectedRows[0].Cells[6].Value;
                form.txtCP.Text = tablaClientes.SelectedRows[0].Cells[7].Value.ToString();
                if (tablaClientes.SelectedRows[0].Cells[8].Value.ToString().Equals("Empresa"))
                    form.rbEmp.Checked = true;
                else
                    form.rbPart.Checked = true;

                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    String tipo = "Particular";
                    if (form.rbEmp.Checked)
                        tipo = "Empresa";

                    sql = $"UPDATE Clientes SET " +
                        $"NOMBRE = '{form.txtNombre.Text}', " +
                        $"APELLIDOS = '{form.txtApell.Text}', " +
                        $"DNI = '{form.txtDNI.Text}', " +
                        $"CP = '{form.txtCP.Text}'," +
                        $"MUNICIPIO = {form.cbMun.SelectedValue.ToString()}, " +
                        $"PROVINCIA = {form.cbProv.SelectedValue.ToString()}," +
                        $"TELEFONO = '{form.txtTlf.Text}', " +
                        $"TIPO = '{tipo}'" +
                        $"WHERE id = {tablaClientes.SelectedRows[0].Cells[0].Value.ToString()}";
                    Conexion.SetComando(sql);
                    Conexion.comando.ExecuteNonQuery();
                    ActualizarTablas();
                }
            }// Pólizas
            else if (tabControl1.SelectedTab.Name == "tabPolizas" && tablaPolizas.SelectedRows.Count > 0)
            {
                FormularioPolizas form = new FormularioPolizas();

                // Cambiar el color del texto a negro
                form.txtNum.ForeColor = Color.Black;
                form.txtImporte.ForeColor = Color.Black;
                form.txtIdCli.ForeColor = Color.Black;
                form.txtNomCli.ForeColor = Color.Black;
                form.txtObservaciones.ForeColor = Color.Black;
                form.txtNum.ReadOnly = true;

                //Cargamos los datos en el formulario
                form.txtNum.Text = tablaPolizas.SelectedRows[0].Cells[0].Value.ToString();
                form.txtImporte.Text = tablaPolizas.SelectedRows[0].Cells[1].Value.ToString();
                form.dtpFecha.Value = DateTime.Parse(tablaPolizas.SelectedRows[0].Cells[2].Value.ToString());
                form.cbEstado.Text = tablaPolizas.SelectedRows[0].Cells[3].Value.ToString();
                form.txtObservaciones.Text = tablaPolizas.SelectedRows[0].Cells[4].Value.ToString();
                form.txtIdCli.Text = tablaPolizas.SelectedRows[0].Cells[5].Value.ToString();// No cambia el nombre

                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    sql = $"UPDATE Polizas SET " +
                    $"IMPORTE = {form.txtImporte.Text}, " +
                    $"FECHA = '{form.dtpFecha.Value.GetDateTimeFormats()[7]}', " +
                    $"ESTADO = '{form.cbEstado.Text}', " +
                    $"OBSERVACIONES = '{form.txtObservaciones.Text}' " +
                    $"WHERE NUMERO = '{form.txtNum.Text}' ";
                    Conexion.SetComando(sql);
                    Conexion.comando.ExecuteNonQuery();
                    ActualizarTablas();
                }
            }// Pagos
            else if (tabControl1.SelectedTab.Name == "tabPagos" && tablaPagos.SelectedRows.Count > 0)
            {
                FormularioPagos form = new FormularioPagos(tablaPagos.SelectedRows[0].Cells[1].Value.ToString());

                // Cambiar el color del texto a negro
                form.txtImporte.ForeColor = Color.Black;

                //Cargamos los datos en el formulario
                form.txtPoliza.Text = tablaPagos.SelectedRows[0].Cells[1].Value.ToString();
                form.txtImporte.Text = tablaPagos.SelectedRows[0].Cells[2].Value.ToString();
                form.dtpFecha.Value = DateTime.Parse(tablaPagos.SelectedRows[0].Cells[3].Value.ToString());

                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    sql = $"UPDATE Pagos SET " +
                    $"IMPORTE = {form.txtImporte.Text}, " +
                    $"FECHA = '{form.dtpFecha.Value.GetDateTimeFormats()[7]}' " +
                    $"WHERE Id = {tablaPagos.SelectedRows[0].Cells[0].Value} ";
                    Conexion.SetComando(sql);
                    Conexion.comando.ExecuteNonQuery();
                    ActualizarTablas();
                }
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPagadoRestante();
            ColorearPolizas();
        }

        // Vuelve a cargar los datos en las tablas, asi como recalcula los datos y colorea la tabla de polizas
        private void ActualizarTablas()
        {
            int i;

            // Clientes
            i = 0;
            if (tablaClientes.SelectedRows.Count > 0)
                i = tablaClientes.SelectedRows[0].Index;

            this.clientesTableAdapter.Fill(this.dataset_clientes.clientes);
            tablaClientes.Refresh();

            if (tablaClientes.RowCount != 0)
            {
                tablaClientes.Rows[0].Selected = false;
                tablaClientes.Rows[i].Selected = true;
            }

            // Pólizas
            i = 0;
            if (tablaPolizas.SelectedRows.Count > 0)
                i = tablaPolizas.SelectedRows[0].Index;

            this.polizasTableAdapter.Fill(this.dataset_polizas.polizas);
            tablaPolizas.Refresh();

            if (tablaPolizas.RowCount != 0)
            {
                tablaPolizas.Rows[0].Selected = false;
                tablaPolizas.Rows[i].Selected = true;
            }

            ColorearPolizas();
            CalcularPagadoRestante();

            // Pagos
            i = 0;
            if (tablaPagos.SelectedRows.Count > 0)
                i = tablaPagos.SelectedRows[0].Index;

            this.pagosTableAdapter.Fill(this.dataset_pagos.pagos);
            tablaPagos.Refresh();
            tablaPagos.Columns[0].Visible = false;

            if (tablaPagos.RowCount != 0)
            {
                tablaPagos.Rows[0].Selected = false;
                tablaPagos.Rows[i].Selected = true;
            }

            seleccionarCliente();
            seleccionarPoliza();
        }

        // Rellena las columnas de Pagado y Restante
        private void CalcularPagadoRestante()
        {
            for (int i = 0; i < tablaPolizas.RowCount; i++)
            {
                if (tablaPolizas.Rows[i].Cells[0].Value != null)
                {
                    String sql = $"SELECT SUM(IMPORTE) FROM PAGOS WHERE POLIZA = '{tablaPolizas.Rows[i].Cells[0].Value}'";
                    Conexion.SetComando(sql);
                    MySqlDataReader lector = Conexion.comando.ExecuteReader();
                    while (lector.Read())
                    {
                        if (!lector.GetValue(0).ToString().Equals(""))
                        {
                            tablaPolizas.Rows[i].Cells[6].Value = lector.GetValue(0);
                            tablaPolizas.Rows[i].Cells[7].Value = double.Parse(tablaPolizas.Rows[i].Cells[1].Value.ToString())
                                                                  - double.Parse(lector.GetValue(0).ToString());
                        }
                        else
                        {
                            tablaPolizas.Rows[i].Cells[6].Value = 0;
                            tablaPolizas.Rows[i].Cells[7].Value = tablaPolizas.Rows[i].Cells[1].Value;
                        }
                    }
                    lector.Close();
                }
            }
        }

        // Pinta la tabla de pólizas
        private void ColorearPolizas()
        {
            for (int f = 0; f < tablaPolizas.RowCount; f++)
            {
                if (tablaPolizas.Rows[f].Cells[3].Value.ToString().Equals("Cobrada"))
                    PintarFila(f, Color.LightGreen);
                else if (tablaPolizas.Rows[f].Cells[3].Value.ToString().Equals("A cuenta"))
                    PintarFila(f, Color.LightBlue);
                else if (tablaPolizas.Rows[f].Cells[3].Value.ToString().Equals("Liquidada"))
                    PintarFila(f, Color.MediumPurple);
                else if (tablaPolizas.Rows[f].Cells[3].Value.ToString().Equals("Pre anulada"))
                    PintarFila(f, Color.Pink);
                else if (tablaPolizas.Rows[f].Cells[3].Value.ToString().Equals("Anulada"))
                    PintarFila(f, Color.Gray);
            }
        }
        // Pinta todas las celdas de la fila de un color
        private void PintarFila(int f, Color color)
        {
            for (int c = 0; c < tablaPolizas.ColumnCount; c++)
                tablaPolizas.Rows[f].Cells[c].Style.BackColor = color;
        }

        private void seleccionarCliente(object sender, EventArgs e)
        {
            seleccionarCliente();
        }

        public void seleccionarCliente()
        {
            Console.WriteLine("Seleccionando cliente");
            if (tablaClientes.SelectedRows.Count > 0)
            {
                Console.WriteLine("Hay una fila seleccionada");
                tablaPolizas.CurrentCell = null;
                for (int i = 0; i < tablaPolizas.RowCount; i++)
                {
                    Console.WriteLine($"Fila {tablaPolizas.Rows[i].Cells[0].Value.ToString()}: {tablaPolizas.Rows[i].Cells[5].Value.ToString().Equals(tablaClientes.SelectedRows[0].Cells[0].Value.ToString())}");
                    tablaPolizas.Rows[i].Visible = tablaPolizas.Rows[i].Cells[5].Value.ToString().Equals(
                                                   tablaClientes.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void seleccionarPoliza(object sender, EventArgs e)
        {
            seleccionarPoliza();
        }

        private void seleccionarPoliza()
        {
            if (tablaPolizas.SelectedRows.Count > 0)
            {
                tablaPagos.CurrentCell = null;
                for (int i = 0; i < tablaPagos.RowCount; i++)
                {
                    tablaPagos.Rows[i].Visible = tablaPagos.Rows[i].Cells[1].Value.ToString().Equals(
                                                   tablaPolizas.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionInformes inf = new SeleccionInformes();
            inf.ShowDialog();
        }
    }
}
