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
    public partial class Memorama : Form
    {
        public Memorama()
        {
            InitializeComponent();
            labelInstrucciones();           
        }

        public void labelInstrucciones()
        {
            lbInstrucciones.Text = "+ Al inicio se revolveran las cartas.\n" +
                "+ En tu turno puedes levantar dos cartas.\n" +
                "+ Si ves que las dos cartas son iguales entonces ya tienes un par, puedes \n " +
                "seguir tirando hasta que te equivoques.\n" +
                "+ Si dichas cartas no son iguales entonces se voltearan y deberás de \n" +
                "intentar otra vez.\n" +
                "+ El juego debe continuar hasta que se acaben todas las cartas que están \n" +
                "boca abajo.\n" +
                "+ Al final seras el ganador cuando consigas encontrar todos los pares.\n";
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            lbInstrucciones.Visible = false;
            pbMemo1.Visible = false;
            pbMemo2.Visible = false;
            lbTitulo.Visible = false;
            btnComenzar.Visible = false;
            lbMemo.Location = new Point(305,10);
            lbTiempo.Visible = true;
            lbPares.Visible = true;
        }
    }
}
