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
    public partial class DondeEstaba : Form
    {
        public DondeEstaba()
        {
            InitializeComponent();
            labelInstrucciones();
        }

        public void labelInstrucciones()
        {
            lbInstrucciones.Text = "+ Al inicio apareceran unas cartas.\n" +
                "+ Podras ver la figura que contiene cada una.\n" +
                "+ Despues de cierto tiempo se pondrán boca abajo.\n" +
                "+ En la pantalla aparecera la figura que tienes que recordar.\n" +
                "+ Seleccionas la carta donde estaba la figura, si aciertas avanzas y si te\n" +
                "equivocas regresaras a ver las figuras.\n" +
                "+ Al final seras el ganador cuando consigas encontrar todos las figuras.\n";

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            lbInstrucciones.Visible = false;
            lbTitulo.Visible = false;
            btnComenzar.Visible = false;
            pbDonde.Visible = false;
            lbDonde.Location = new Point(257, 10);
            lbTiempo.Visible = true;
            lbPuntos.Visible = true;
        }
    }
}
