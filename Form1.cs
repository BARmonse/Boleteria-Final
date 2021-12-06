using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boleteria_Final
{
    public partial class Form1 : Form
    {
        private GestorColas gestorColas;
        private double cantidadClientes;
        private double tiempo;
        private double desde;
        private double hasta;
        private double limInferior;
        private double limSuperior;
        private double media1;
        private double media2;
        private double desviacion1;
        private double desviacion2;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void tomarDatos()
        {
            desde = double.Parse(txtDesde.Text);
            hasta = double.Parse(txtHasta.Text);
            limInferior = double.Parse(txtLimInferior.Text);
            limSuperior = double.Parse(txtLimSuperior.Text);
            media1 = double.Parse(txtMedia1.Text);
            media2 = double.Parse(txtMedia2.Text);
            desviacion1 = double.Parse(txtDesviacion1.Text);
            desviacion2 = double.Parse(txtDesviacion2.Text);
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            tomarDatos();
            if (hayErrores())
            {
                MessageBox.Show("Hay datos inválidos");
            }
            else
            {
                gestorColas = new GestorColas(this);
                gestorColas.simular(desde,hasta,limInferior,limSuperior,media1,media2,desviacion1,desviacion2);
            }
        }

        private Boolean hayErrores()
        {
            if (desde >= hasta || desde < 0 || hasta < 0 ||
                limInferior >= limSuperior || limInferior < 0 || limSuperior < 0 ||
                media1 < 0 || desviacion1 < 0 || media2 < 0 || desviacion2 < 0) { return true; }

            return false;
        }

        public void mostrarResultados(DataTable resultados)
        {
            grdResultados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdResultados.DataSource = resultados;
        }
    }
}
