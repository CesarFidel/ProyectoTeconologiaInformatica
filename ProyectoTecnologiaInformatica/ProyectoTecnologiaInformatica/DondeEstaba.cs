using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ProyectoTecnologiaInformatica
{
    public partial class DondeEstaba : Form
    {
        int nivelActual = 1;
        int imgCorrecta;
        int puntuacion = 1000;
        int segTotal = 0;
        int tiempoVer = 0;
        Image pb1;
        Image pb2;
        Image pb3;
        Stopwatch oSW = new Stopwatch();
        bool correcto = false;
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
                "equivocas elegiras nuevamente una carta.\n" +
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
            pBMuestra.Visible = true;
            lbTiempo.Text = "Tiempo: 00";
            lbPuntos.Text = "Puntos: " + puntuacion.ToString();
            oSW.Start();
            timer1.Enabled = true;
            cargaNivel(1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);
            lbTiempo.Text = "Tiempo: " + (ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString());
            segTotal = ts.Seconds;
            if (tiempoVer > 4 && correcto == false)
            {
                pBMuestra.Visible = true;
                pBimg1.Image = Image.FromFile("Tar2.png");
                pBimg2.Image = Image.FromFile("Tar2.png");
                pBimg3.Image = Image.FromFile("Tar2.png");
                lblResultado.Text = "";

            }
            else
            {
                tiempoVer++;
            }
        }

        public void cambiaVisibleImagenes()
        {
            pBimg1.Visible = !pBimg1.Visible;
            pBimg2.Visible = !pBimg2.Visible;
            pBimg3.Visible = !pBimg3.Visible;

            pBimg1.Enabled = !pBimg1.Enabled;
            pBimg2.Enabled = !pBimg2.Enabled;
            pBimg3.Enabled = !pBimg3.Enabled;
        }

        public void cargaNivel(int nivel)
        {
            Random aleatorio = new Random();
            imgCorrecta = aleatorio.Next(1, 4);

            pBMuestra.Visible = false;
            pBimg1.Visible = true;
            pBimg2.Visible = true;
            pBimg3.Visible = true;

            oSW.Start();
            timer1.Enabled = true;

            switch (nivel)
            {
                case 1:
                    Image imagenMostrada1 = Image.FromFile("Donde1.png");
                    Image image12 = Image.FromFile("Donde2.png");
                    Image image13 = Image.FromFile("Donde3.png");
                    pBMuestra.Image = imagenMostrada1;
                    correcto = false;
                    switch (imgCorrecta)
                    {
                        case 1:
                            pBimg1.Image = imagenMostrada1;
                            pb1 = imagenMostrada1;
                            pBimg2.Image = image12;
                            pb2 = image12;
                            pBimg3.Image = image13;
                            pb3 = image13;
                            break;
                        case 2:
                            pBimg1.Image = image12;
                            pb1 = image12;
                            pBimg2.Image = imagenMostrada1;
                            pb2 = imagenMostrada1;
                            pBimg3.Image = image13;
                            pb3 = image13;
                            break;
                        case 3:
                            pBimg1.Image = image13;
                            pb1 = image13;
                            pBimg2.Image = image12;
                            pb2 = image12;
                            pBimg3.Image = imagenMostrada1;
                            pb3 = imagenMostrada1;
                            break;
                    }
                    break;
                case 2:
                    Image imagenMostrada2 = Image.FromFile("Donde2.png");
                    Image image22 = Image.FromFile("Donde1.png");
                    Image image23 = Image.FromFile("Donde3.png");
                    pBMuestra.Image = imagenMostrada2;
                    correcto = false;
                    switch (imgCorrecta)
                    {
                        case 1:
                            pBimg1.Image = imagenMostrada2;
                            pb1 = imagenMostrada2;
                            pBimg2.Image = image22;
                            pb2 = image22;
                            pBimg3.Image = image23;
                            pb3 = image23;
                            break;
                        case 2:
                            pBimg1.Image = image22;
                            pb1 = image22;
                            pBimg2.Image = imagenMostrada2;
                            pb2 = imagenMostrada2;
                            pBimg3.Image = image23;
                            pb3 = image23;
                            break;
                        case 3:
                            pBimg1.Image = image23;
                            pb1 = image23;
                            pBimg2.Image = image22;
                            pb2 = image22;
                            pBimg3.Image = imagenMostrada2;
                            pb3 = imagenMostrada2;
                            break;
                    }
                    break;
                case 3:
                    Image imagenMostrada3 = Image.FromFile("Donde3.png");
                    Image image32 = Image.FromFile("Donde1.png");
                    Image image33 = Image.FromFile("Donde2.png");
                    pBMuestra.Image = imagenMostrada3;
                    correcto = false;
                    switch (imgCorrecta)
                    {
                        case 1:
                            pBimg1.Image = imagenMostrada3;
                            pb1 = imagenMostrada3;
                            pBimg2.Image = image32;
                            pb2 = image32;
                            pBimg3.Image = image33;
                            pb3 = image33;
                            break;
                        case 2:
                            pBimg1.Image = image32;
                            pb1 = image32;
                            pBimg2.Image = imagenMostrada3;
                            pb2 = imagenMostrada3;
                            pBimg3.Image = image33;
                            pb3 = image33;
                            break;
                        case 3:
                            pBimg1.Image = image33;
                            pb1 = image33;
                            pBimg2.Image = image32;
                            pb2 = image32;
                            pBimg3.Image = imagenMostrada3;
                            pb3 = imagenMostrada3;
                            break;
                    }
                    break;

            }
        }

        private void pBimg1_Click(object sender, EventArgs e)
        {
            pBimg1.Image = pb1;

            if (imgCorrecta == 1)
            {
                lblResultado.Visible = true;
                pBimg1.Image = pb1;
                correcto = true;
                oSW.Stop();
                nivelActual++;
                lblResultado.Text = "Nivel " + nivelActual;
                tiempoVer = 0;
                cargaNivel(nivelActual);
                if (nivelActual == 4)
                {
                    timer1.Stop();
                    finalizaJuego();
                }
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Incorrecto";
                puntuacion -= 100;
                lbPuntos.Text = "Puntos: " + puntuacion.ToString();
            }
        }

        private void pBimg2_Click(object sender, EventArgs e)
        {
            pBimg2.Image = pb2;
            oSW.Start();
            if (imgCorrecta == 2)
            {
                lblResultado.Visible = true;
                pBimg2.Image = pb2;
                correcto = true;
                oSW.Stop();
                nivelActual++;
                lblResultado.Text = "Nivel " + nivelActual;
                tiempoVer = 0;
                cargaNivel(nivelActual);
                if (nivelActual == 4)
                {
                    timer1.Stop();
                    finalizaJuego();
                }
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Incorrecto";
                puntuacion -= 100;
                lbPuntos.Text = "Puntos: " + puntuacion.ToString();
            }
        }

        private void pBimg3_Click(object sender, EventArgs e)
        {
            pBimg3.Image = pb3;
            if (imgCorrecta == 3)
            {
                lblResultado.Visible = true;
                pBimg3.Image = pb3;
                correcto = true;
                oSW.Stop();
                nivelActual++;
                lblResultado.Text = "Nivel " + nivelActual;
                tiempoVer = 0;
                cargaNivel(nivelActual);
                if (nivelActual == 4)
                {
                    timer1.Stop();
                    finalizaJuego();
                }
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Incorrecto";
                puntuacion -= 100;
                lbPuntos.Text = "Puntos: " + puntuacion.ToString();
            }
        }

        public void finalizaJuego()
        {           
            lbTiempo.Text = "Tiempo Total: " + segTotal.ToString();
            lbPuntos.Text = "Puntos: " + (puntuacion - segTotal * 10).ToString();
            lbDonde.Visible = false;
            pbDonde.Visible = true;
            pbDonde.Image = Properties.Resources.winDonde;
            pbDonde.SizeMode = PictureBoxSizeMode.AutoSize;
            pbDonde.Location = new Point(0, 10);
            cambiaVisibleImagenes();
            lblResultado.Location = new Point(50, 290);
            pbTrofeo.Visible = true;
            lblResultado.ForeColor = Color.Black;
            lblResultado.Text = "Haz Realizado ¿Dónde Estaba?";
            lblResultado.Visible = true;
            lbTiempo.Location = new Point(150, 350);
            lbPuntos.Location = new Point(150, 390);
        }
    }
}