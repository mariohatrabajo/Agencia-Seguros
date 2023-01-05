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
    public partial class VentanaInformes : Form
    {
        int cliDesde = -1, cliHasta = -1;
        String fechaDesde, fechaHasta;
        public VentanaInformes(String cliDesde, String cliHasta, String fechaDesde, String fechaHasta)
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
        }

        private void Informes_Load(object sender, EventArgs e)
        {
            if (cliDesde != -1 && cliHasta != -1 && fechaDesde != null && fechaHasta != null)
            {
                // TODO: esta línea de código carga datos en la tabla 'DataSetInforme.polizas' Puede moverla o quitarla según sea necesario.
                this.polizasTableAdapter.Fill(this.DataSetInforme.polizas, cliDesde, cliHasta, DateTime.Parse(fechaDesde), DateTime.Parse(fechaHasta));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
