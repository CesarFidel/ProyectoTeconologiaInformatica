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
    public partial class Form1 : Form
    {
        public bool pantallaJuego = false;
        public bool pantallaAyuda = false;

        public Form1()
        {
            InitializeComponent();
            CambiaTextoLabel();
            
        }
        
        public void CambiaTextoLabel()
        {
            lblAyudaPequeña.Text = "Esta es una aplicación que ayuda a los niños a mejorar sus habilidades cognitivas.\n" +
                "Lo primero que tienes que hacer es darle clic en el botón de inicio que te aparecio al principio " +
                "y de ahí puedes selecionar uno de los 3 juegos que hay, " +
                "en cada uno de esos juegos viene la como se uega y de que trata." +
                "\nAsí que... ¡ADELANTE!  Vamos a aprender";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CambiaVisibleInicio();

            CambiaVisibleEscogerJuegos();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            CambiaVisibleInicio();
            CambiaVisibleAyuda();
        }

        public void CambiaVisibleEscogerJuegos()
        {
            btnMemorama.Visible = !btnMemorama.Visible;
            btnDondeEstaba.Visible = !btnDondeEstaba.Visible;
            btnAquiNo.Visible = !btnAquiNo.Visible;
            btnRegresar.Visible = !btnRegresar.Visible;
            lblEligeJuego.Visible = !lblEligeJuego.Visible;
            pantallaJuego = !pantallaJuego;
        }

        public void CambiaVisibleInicio()
        {
            btnInicio.Visible = !btnInicio.Visible;
            btnAyuda.Visible = !btnAyuda.Visible;
        }

       public void CambiaVisibleAyuda()
        {
            lblAyudaGrande.Visible = !lblAyudaGrande.Visible;
            lblAyudaPequeña.Visible = !lblAyudaPequeña.Visible;
            btnRegresar.Visible = !btnRegresar.Visible;
            pantallaAyuda = !pantallaAyuda;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CambiaVisibleInicio();
            if(pantallaJuego)
                CambiaVisibleEscogerJuegos();
            if (pantallaAyuda)
                CambiaVisibleAyuda();


        }
    }
}
