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
    public partial class VentanaInformesEstados : Form
    {
        int cliDesde = -1, cliHasta = -1;
        String fechaDesde, fechaHasta, estado;
        public VentanaInformesEstados(String cliDesde, String cliHasta, String fechaDesde, String fechaHasta, String estado)
        {
            InitializeComponent();
            try
            {
                this.cliDesde = Int32.Parse(cliDesde);
                this.cliHasta = Int32.Parse(cliHasta);
            }
            catch (FormatException) { }
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.estado = estado;
        }

        private void VentanaInformesEstados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataset_informeEstados.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.dataset_informeEstados.DataTable1, cliDesde, cliHasta, DateTime.Parse(fechaDesde), DateTime.Parse(fechaHasta), estado);

            this.reportViewer1.RefreshReport();
        }
    }
}
