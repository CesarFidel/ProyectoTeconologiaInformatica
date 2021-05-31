using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoTecnologiaInformatica
{
    public partial class AquiNoVa : Form
    {
        Stopwatch oSW = new Stopwatch();
        int nivelActual = 1;
        int imgMal; //Guardas cual es la imagen que esta mal
        int puntuacion = 1000;
        int segundosTotal = 0;

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
                "+ Al final seras el ganador cuando consigas encontrar todas las figuras\n" +
                "diferentes.\n";
            txtBoxPuntos.Text = puntuacion.ToString();
            txtTiempo.Text = "00";
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

            //Inicia cronometro
            iniciaCronometro();
            cargaNivel(nivelActual);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0,0,0,0,(int)oSW.ElapsedMilliseconds);
            txtTiempo.Text = ts.Seconds.ToString().Length<2 ? "0" + ts.Seconds.ToString():ts.Seconds.ToString();

        }

        public void iniciaCronometro()
        {
            oSW.Start();
            timer1.Enabled = true;
            txtTiempo.Visible = true;
            txtBoxPuntos.Visible = true;
        }


        public void reiniciaCronometro()
        {
            oSW.Reset();
            segundosTotal += Int32.Parse(txtTiempo.Text);
            txtTiempo.Text = "00";
            timer1.Enabled = false;
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
            Random r = new Random();
            imgMal = r.Next(1, 4);

            pBimg1.Visible = true;
            pBimg2.Visible = true;
            pBimg3.Visible = true;

            switch (nivel)
            {
                case 1:
                    Image imagedif1 = Image.FromFile(@"Img\AquiNo\animaldif.png");
                    Image image1 = Image.FromFile(@"Img\AquiNo\animal.png");
                    switch (imgMal)
                    {
                        case 1:
                            pBimg1.Image = imagedif1;
                            pBimg2.Image = image1;
                            pBimg3.Image = image1;
                            break;
                        case 2:
                            pBimg1.Image = image1;
                            pBimg2.Image = imagedif1;
                            pBimg3.Image = image1;
                            break;
                        case 3:
                            pBimg1.Image = image1;
                            pBimg2.Image = image1;
                            pBimg3.Image = imagedif1;
                            break;
                    }
                    break;
                case 2:
                    Image imagedif2 = Image.FromFile(@"Img\AquiNo\caradif.png");
                    Image image2 = Image.FromFile(@"Img\AquiNo\cara.png");
                    switch (imgMal)
                    {
                        case 1:
                            pBimg1.Image = imagedif2;
                            pBimg2.Image = image2;
                            pBimg3.Image = image2;
                            break;
                        case 2:
                            pBimg1.Image = image2;
                            pBimg2.Image = imagedif2;
                            pBimg3.Image = image2;
                            break;
                        case 3:
                            pBimg1.Image = image2;
                            pBimg2.Image = image2;
                            pBimg3.Image = imagedif2;
                            break;
                    }
                    break;
                case 3:
                    Image imagedif3 = Image.FromFile(@"Img\AquiNo\flordif.png");
                    Image image3 = Image.FromFile(@"Img\AquiNo\flor.png");
                    switch (imgMal)
                    {
                        case 1:
                            pBimg1.Image = imagedif3;
                            pBimg2.Image = image3;
                            pBimg3.Image = image3;
                            break;
                        case 2:
                            pBimg1.Image = image3;
                            pBimg2.Image = imagedif3;
                            pBimg3.Image = image3;
                            break;
                        case 3:
                            pBimg1.Image = image3;
                            pBimg2.Image = image3;
                            pBimg3.Image = imagedif3;
                            break;
                    }
                    break;            
            }
        }

        private void pBimg1_Click(object sender, EventArgs e)
        {
            if (imgMal == 1)
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Correcto";
                nivelActual++;                
                Task.Delay(1500);
                lblResultado.Visible = false;
                cargaNivel(nivelActual);
                reiniciaCronometro();
                iniciaCronometro();
                if (nivelActual == 4)
                {
                    finalizaJuego();
                }
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Incorrecto";
                puntuacion -= 100;
                txtBoxPuntos.Text = puntuacion.ToString();
            }
        }

        private void pBimg2_Click(object sender, EventArgs e)
        {
            if (imgMal == 2)
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Correcto";
                nivelActual++;                
                Task.Delay(1500);
                lblResultado.Visible = false;
                cargaNivel(nivelActual);
                reiniciaCronometro();
                iniciaCronometro();
                if (nivelActual == 4)
                {
                    finalizaJuego();
                }
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Incorrecto";
                puntuacion -= 100;
                txtBoxPuntos.Text = puntuacion.ToString();
            }
        }

        private void pBimg3_Click(object sender, EventArgs e)
        {
            if (imgMal == 3)
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Correcto";
                nivelActual++;
                Task.Delay(1500);                
                lblResultado.Visible = false;
                cargaNivel(nivelActual);
                reiniciaCronometro();
                iniciaCronometro();
                if (nivelActual == 4)
                {
                    finalizaJuego();
                }
            }
            else
            {
                lblResultado.Visible = true;
                lblResultado.Text = "Incorrecto";                
                puntuacion -= 100;
                txtBoxPuntos.Text = puntuacion.ToString();
            }
                
        }

        public void finalizaJuego()
        {
            txtTiempo.Visible = false;
            txtBoxPuntos.Visible = false;
            lbTiempo.Text = "Tiempo Total: " + segundosTotal.ToString();
            lbPuntos.Text = lbPuntos.Text + (puntuacion - segundosTotal * 10).ToString();
            lbAqui.Visible = false;
            pbAqui.Visible = true;
            pbAqui.Image = Properties.Resources.winAqui;
            pbAqui.SizeMode = PictureBoxSizeMode.AutoSize;
            pbAqui.Location = new Point(0, 10);
            cambiaVisibleImagenes();
            lblResultado.Location = new Point(50, 290);
            pbTrofeo.Visible = true;
            lblResultado.ForeColor = Color.Black;
            lblResultado.Text = "Haz Realizado ¡Aquí No Va!";//"Felicidades ganaste\nPuntuación final: " + (puntuacion - segundosTotal * 10).ToString();
            txtBoxPuntos.Text = puntuacion.ToString();           
            lblResultado.Visible = true;
            lbTiempo.Location = new Point(150, 350);
            lbPuntos.Location = new Point(150, 390);
        }
    }
}
