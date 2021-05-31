
namespace ProyectoTecnologiaInformatica
{
    partial class DondeEstaba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbDonde = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lbInstrucciones = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pbDonde = new System.Windows.Forms.PictureBox();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbTrofeo = new System.Windows.Forms.PictureBox();
            this.pBimg1 = new System.Windows.Forms.PictureBox();
            this.pBimg2 = new System.Windows.Forms.PictureBox();
            this.pBimg3 = new System.Windows.Forms.PictureBox();
            this.pBMuestra = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrofeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMuestra)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDonde
            // 
            this.lbDonde.AutoSize = true;
            this.lbDonde.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDonde.Location = new System.Drawing.Point(198, 83);
            this.lbDonde.Name = "lbDonde";
            this.lbDonde.Size = new System.Drawing.Size(269, 47);
            this.lbDonde.TabIndex = 16;
            this.lbDonde.Text = "¿Dónde Estaba?";
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Blue;
            this.btnComenzar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(291, 354);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(221, 68);
            this.btnComenzar.TabIndex = 15;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // lbInstrucciones
            // 
            this.lbInstrucciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInstrucciones.Location = new System.Drawing.Point(166, 173);
            this.lbInstrucciones.Name = "lbInstrucciones";
            this.lbInstrucciones.Size = new System.Drawing.Size(535, 178);
            this.lbInstrucciones.TabIndex = 14;
            this.lbInstrucciones.Text = " ";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.Color.Red;
            this.lbTitulo.Location = new System.Drawing.Point(217, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(384, 65);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "INSTRUCCIONES";
            // 
            // pbDonde
            // 
            this.pbDonde.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Pensi;
            this.pbDonde.Location = new System.Drawing.Point(470, 65);
            this.pbDonde.Name = "pbDonde";
            this.pbDonde.Size = new System.Drawing.Size(94, 80);
            this.pbDonde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDonde.TabIndex = 17;
            this.pbDonde.TabStop = false;
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.BackColor = System.Drawing.Color.DeepPink;
            this.lbPuntos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPuntos.ForeColor = System.Drawing.Color.White;
            this.lbPuntos.Location = new System.Drawing.Point(660, 18);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(74, 22);
            this.lbPuntos.TabIndex = 19;
            this.lbPuntos.Text = "Puntos:";
            this.lbPuntos.Visible = false;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.BackColor = System.Drawing.Color.DeepPink;
            this.lbTiempo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTiempo.ForeColor = System.Drawing.Color.White;
            this.lbTiempo.Location = new System.Drawing.Point(22, 18);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(79, 22);
            this.lbTiempo.TabIndex = 18;
            this.lbTiempo.Text = "Tiempo:";
            this.lbTiempo.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbTrofeo
            // 
            this.pbTrofeo.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.trofeo;
            this.pbTrofeo.Location = new System.Drawing.Point(585, 277);
            this.pbTrofeo.Name = "pbTrofeo";
            this.pbTrofeo.Size = new System.Drawing.Size(159, 159);
            this.pbTrofeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTrofeo.TabIndex = 20;
            this.pbTrofeo.TabStop = false;
            this.pbTrofeo.Visible = false;
            // 
            // pBimg1
            // 
            this.pBimg1.Location = new System.Drawing.Point(96, 213);
            this.pBimg1.Name = "pBimg1";
            this.pBimg1.Size = new System.Drawing.Size(133, 123);
            this.pBimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimg1.TabIndex = 23;
            this.pBimg1.TabStop = false;
            this.pBimg1.Visible = false;
            this.pBimg1.Click += new System.EventHandler(this.pBimg1_Click);
            // 
            // pBimg2
            // 
            this.pBimg2.Location = new System.Drawing.Point(334, 213);
            this.pBimg2.Name = "pBimg2";
            this.pBimg2.Size = new System.Drawing.Size(133, 123);
            this.pBimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimg2.TabIndex = 24;
            this.pBimg2.TabStop = false;
            this.pBimg2.Visible = false;
            this.pBimg2.Click += new System.EventHandler(this.pBimg2_Click);
            // 
            // pBimg3
            // 
            this.pBimg3.Location = new System.Drawing.Point(585, 213);
            this.pBimg3.Name = "pBimg3";
            this.pBimg3.Size = new System.Drawing.Size(133, 123);
            this.pBimg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimg3.TabIndex = 25;
            this.pBimg3.TabStop = false;
            this.pBimg3.Visible = false;
            this.pBimg3.Click += new System.EventHandler(this.pBimg3_Click);
            // 
            // pBMuestra
            // 
            this.pBMuestra.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Tar2;
            this.pBMuestra.Location = new System.Drawing.Point(334, 65);
            this.pBMuestra.Name = "pBMuestra";
            this.pBMuestra.Size = new System.Drawing.Size(133, 123);
            this.pBMuestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMuestra.TabIndex = 26;
            this.pBMuestra.TabStop = false;
            this.pBMuestra.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultado.Location = new System.Drawing.Point(336, 351);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(107, 45);
            this.lblResultado.TabIndex = 27;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // DondeEstaba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pBMuestra);
            this.Controls.Add(this.pBimg3);
            this.Controls.Add(this.pBimg2);
            this.Controls.Add(this.pBimg1);
            this.Controls.Add(this.pbTrofeo);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.pbDonde);
            this.Controls.Add(this.lbDonde);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lbInstrucciones);
            this.Controls.Add(this.lbTitulo);
            this.Name = "DondeEstaba";
            this.Text = "DondeEstaba";
            ((System.ComponentModel.ISupportInitialize)(this.pbDonde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrofeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMuestra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDonde;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lbInstrucciones;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pbDonde;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbTrofeo;
        private System.Windows.Forms.PictureBox pBimg1;
        private System.Windows.Forms.PictureBox pBimg2;
        private System.Windows.Forms.PictureBox pBimg3;
        private System.Windows.Forms.PictureBox pBMuestra;
        private System.Windows.Forms.Label lblResultado;
    }
}