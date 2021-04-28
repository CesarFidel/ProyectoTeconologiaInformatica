using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTecnologiaInformatica
{
    public partial class AquiNoVa : Form
    {
        public AquiNoVa()
        {
            InitializeComponent();
            labelInstrucciones();
        }

        public void labelInstrucciones()
        {
            lbInstrucciones.Text = "+ Al inicio apareceran varias figuras.\n" +
                "+ Tendras que ver cada figura.\n" +
                "+ Una de estas figuras será diferente a las otras.\n" +
                "+ Tendrás que encontrarla y seleccionarla.\n" +
                "+ Seleccionas la figura y si aciertas avanzas y si te equivocas regresaras a\n" +
                "ver las figuras.\n" +
                "+ Al final seras el ganador cuando consigas encontrar todos las figuras\n" +
                "diferente.\n";
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            lbInstrucciones.Visible = false;
            lbTitulo.Visible = false;
            btnComenzar.Visible = false;
            pbAqui.Visible = false;
            lbAqui.Location = new Point(300, 10);
            lbTiempo.Visible = true;
            lbPuntos.Visible = true;
        }
    }
}
