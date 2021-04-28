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
            this.BackColor = Color.Green;
        }
        
        public void CambiaTextoLabel()
        {
            lblAyudaPequeña.Text = "Esta es una aplicación que ayuda a los niños a mejorar sus habilidades cognitivas.\n" +
                "Lo primero que tienes que hacer es darle clic en el botón de inicio que te aparecio al principio " +
                "y de ahí puedes selecionar uno de los 3 juegos que hay, " +
                "en cada uno de esos juegos viene la como se juega y de que trata." +
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
            this.BackColor = Color.Purple;
            btnMemorama.Visible = !btnMemorama.Visible;
            btnDondeEstaba.Visible = !btnDondeEstaba.Visible;
            btnAquiNo.Visible = !btnAquiNo.Visible;
            btnRegresar.Visible = !btnRegresar.Visible;
            lblEligeJuego.Visible = !lblEligeJuego.Visible;
            pantallaJuego = !pantallaJuego;
            pbLogo.BackColor = Color.Purple;
            pbLogo.Location = new Point(280, 10);
            pbLogo.ClientSize = new Size(210, 104);
            pbMemo.Visible = true;
            pbDonde.Visible = true;
            pbAqui.Visible = true;
        }

        public void CambiaVisibleInicio()
        {
            btnInicio.Visible = !btnInicio.Visible;
            btnAyuda.Visible = !btnAyuda.Visible;
            pbMemo.Visible = !pbMemo.Visible;
            pbDonde.Visible = !pbDonde.Visible;
            pbAqui.Visible = !pbAqui.Visible;
            this.BackColor = Color.Green;
            pbLogo.BackColor = Color.Green;
            pbLogo.Location = new Point(184, 10);
            pbLogo.ClientSize = new Size(421, 209);
        }

       public void CambiaVisibleAyuda()
        {
            this.BackColor = Color.BlueViolet;
            lblAyudaGrande.Visible = !lblAyudaGrande.Visible;
            lblAyudaPequeña.Visible = !lblAyudaPequeña.Visible;
            btnRegresar.Visible = !btnRegresar.Visible;
            pantallaAyuda = !pantallaAyuda;
            pbLogo.BackColor = Color.BlueViolet;
            pbLogo.Location = new Point(280, 300);
            pbLogo.ClientSize = new Size(210, 104);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CambiaVisibleInicio();
            if(pantallaJuego)
                CambiaVisibleEscogerJuegos();
            if (pantallaAyuda)
                CambiaVisibleAyuda();

        }

        private void btnMemorama_Click(object sender, EventArgs e)
        {
            Memorama memorama = new Memorama();
            memorama.ShowDialog();
        }

        private void btnDondeEstaba_Click(object sender, EventArgs e)
        {
            DondeEstaba donde = new DondeEstaba();
            donde.ShowDialog();
        }

        private void btnAquiNo_Click(object sender, EventArgs e)
        {
            AquiNoVa aqui = new AquiNoVa();
            aqui.ShowDialog();
        }
    }
}
