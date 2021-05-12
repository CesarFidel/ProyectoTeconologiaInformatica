using System;
using System.Collections;
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
        int tamañoColumnas = 3; //Change
        int tamañoFilas = 2;
        int movimientos = 0;
        int cartasVolteadas = 0;
        List<string> cartasEnumeradas;
        List<string> cartasRevueltas;
        ArrayList cartaSeleccionadas;
        PictureBox cartaTemporal1;
        PictureBox cartaTemporal2;
        int cartaActual = 0;
        int pares = 0;
        int contador = 0;
        int n;
        public Memorama()
        {
            InitializeComponent();
            labelInstrucciones();           
        }

        public void iniciarMemorama()
        {
            tamañoColumnas = n / 2;
            timer1.Enabled = false;
            timer1.Stop();
            lbTiempo.Text = lbTiempo.Text + "0";
            lbPares.Text = lbPares.Text + "0";
            cartasVolteadas = 0;
            movimientos = 0;
            panelMemo.Controls.Clear();
            cartasEnumeradas = new List<string>();
            cartasRevueltas = new List<string>();
            cartaSeleccionadas = new ArrayList();
            for(int i=0; i < tamañoColumnas; i++)//Change
            {
                cartasEnumeradas.Add(i.ToString());
                cartasEnumeradas.Add(i.ToString());
            }
            var aleatorio = new Random();
            var resultado = cartasEnumeradas.OrderBy(item=> aleatorio.Next());
            foreach(string valorCarta in resultado)
            {
                cartasRevueltas.Add(valorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = tamañoFilas;
            tablaPanel.ColumnCount = tamañoColumnas;

            for(int i=0; i<tamañoColumnas; i++)
            {
                var porcentajeCol = 150f / (float)tamañoColumnas - 10;
                var porcentajeFil = 150f / (float)tamañoFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, porcentajeCol));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, porcentajeFil));
            }

            int contadorFichas = 1;

            for(var i=0; i<tamañoFilas; i++)
            {
                for(var j=0; j<tamañoColumnas; j++)
                {
                    var cartasJuego = new PictureBox();
                    cartasJuego.Name = string.Format("{0}", contadorFichas);
                    cartasJuego.Dock = DockStyle.Fill;
                    cartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartasJuego.Image = Properties.Resources.Tar2; // Tarjeta;// tar; //Carta Volteada
                    cartasJuego.Cursor = Cursors.Hand;
                    cartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(cartasJuego, j, i);
                    contadorFichas++;
                }
            }

            tablaPanel.Dock = DockStyle.Fill;
            panelMemo.Controls.Add(tablaPanel);
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (cartaSeleccionadas.Count < 2)
            {
                movimientos++;
                var cartasSeleccionadasU = (PictureBox)sender;

                cartaActual = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartasSeleccionadasU.Name) - 1]);
                cartasSeleccionadasU.Image = recuperarImagen(cartaActual);
                cartaSeleccionadas.Add(cartasSeleccionadasU);
                if (cartaSeleccionadas.Count == 2)
                {
                    cartaTemporal1 = (PictureBox)cartaSeleccionadas[0];
                    cartaTemporal2 = (PictureBox)cartaSeleccionadas[1];
                    int carta1 = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartaTemporal1.Name) - 1]);
                    int carta2 = Convert.ToInt32(cartasRevueltas[Convert.ToInt32(cartaTemporal2.Name) - 1]);

                    if (carta1 != carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        cartasVolteadas++;
                        pares++;
                        lbPares.Text = "Pares: " + pares.ToString();                        
                        cartaTemporal1.Enabled = false; cartaTemporal2.Enabled = false;
                        cartaSeleccionadas.Clear();
                    }
                }
            }

        }

        public Bitmap recuperarImagen(int numImg)
        {
            Bitmap tmpImg = new Bitmap(200, 100);
            switch (numImg)
            {
                case 0:
                    tmpImg = Properties.Resources.img5;
                    break;
                default: tmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + numImg);
                    break;
            }
            return tmpImg;
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
            if ((cbNumeroPares.SelectedIndex == 0) || (cbNumeroPares.SelectedIndex == 1))
            {
                lbInstrucciones.Visible = false;
                pbMemo1.Visible = false;
                pbMemo2.Visible = false;
                lbTitulo.Visible = false;
                btnComenzar.Visible = false;
                lbMemo.Location = new Point(305,10);
                lbTiempo.Visible = true;
                lbPares.Visible = true;
                panelMemo.Visible = true;
                lbCartas.Visible = false;
                cbNumeroPares.Visible = false;
                iniciarMemorama();
                tiempo.Start();
            }
            else
            {
                MessageBox.Show("Selecciona un Número de Cartas !!!","Cartas",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tiempoVoltearCarta = 1;
            if (tiempoVoltearCarta == 1)
            {
                cartaTemporal1.Image = Properties.Resources.Tar2;
                cartaTemporal2.Image = Properties.Resources.Tar2;
                cartaSeleccionadas.Clear();
                tiempoVoltearCarta = 0;
                timer1.Stop();
            }
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            contador++;
            lbTiempo.Text = "Tiempo: " + contador.ToString();
            if(pares == tamañoColumnas)//Change
            {
                tiempo.Stop();
                panelMemo.Visible = false;                
                pbMemo1.Visible = true;
                pbMemo2.Visible = true;
                pbMemo1.Image = Properties.Resources.win2Memo;
                pbMemo1.SizeMode = PictureBoxSizeMode.AutoSize;
                pbMemo1.Location = new Point(0, 10);
                pbMemo2.Image = Properties.Resources.trofeo;
                pbMemo2.SizeMode = PictureBoxSizeMode.AutoSize;
                pbMemo2.Location = new Point(580, 260);
                lbMemo.Text = "Haz realizado Memorama";
                lbMemo.Location = new Point(50, 290);
                lbTiempo.Location = new Point(150, 350);
                lbPares.Location = new Point(150, 390);
            }
        }

        private void cbNumeroPares_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNumeroPares.SelectedIndex == 0)
            {
                n = 6;
            }
            if (cbNumeroPares.SelectedIndex == 1)
            {
                n = 10;
            }
        }
    }
}
