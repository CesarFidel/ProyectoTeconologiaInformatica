
namespace ProyectoTecnologiaInformatica
{
    partial class AquiNoVa
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
            this.lbAqui = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lbInstrucciones = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.pbAqui = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.pBimg1 = new System.Windows.Forms.PictureBox();
            this.pBimg2 = new System.Windows.Forms.PictureBox();
            this.pBimg3 = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtBoxPuntos = new System.Windows.Forms.TextBox();
            this.pbTrofeo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAqui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrofeo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAqui
            // 
            this.lbAqui.AutoSize = true;
            this.lbAqui.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAqui.Location = new System.Drawing.Point(299, 70);
            this.lbAqui.Name = "lbAqui";
            this.lbAqui.Size = new System.Drawing.Size(216, 47);
            this.lbAqui.TabIndex = 16;
            this.lbAqui.Text = "¡Aquí No Va!";
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnComenzar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(290, 368);
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
            this.lbInstrucciones.Location = new System.Drawing.Point(154, 187);
            this.lbInstrucciones.Name = "lbInstrucciones";
            this.lbInstrucciones.Size = new System.Drawing.Size(634, 169);
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
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.BackColor = System.Drawing.Color.Aqua;
            this.lbPuntos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPuntos.Location = new System.Drawing.Point(665, 18);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(79, 22);
            this.lbPuntos.TabIndex = 19;
            this.lbPuntos.Text = "Puntos: ";
            this.lbPuntos.Visible = false;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.BackColor = System.Drawing.Color.Aqua;
            this.lbTiempo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTiempo.Location = new System.Drawing.Point(27, 18);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(84, 22);
            this.lbTiempo.TabIndex = 18;
            this.lbTiempo.Text = "Tiempo: ";
            this.lbTiempo.Visible = false;
            // 
            // pbAqui
            // 
            this.pbAqui.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Aqui_no;
            this.pbAqui.Location = new System.Drawing.Point(329, 120);
            this.pbAqui.Name = "pbAqui";
            this.pbAqui.Size = new System.Drawing.Size(166, 51);
            this.pbAqui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAqui.TabIndex = 20;
            this.pbAqui.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(111, 17);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(25, 23);
            this.txtTiempo.TabIndex = 21;
            this.txtTiempo.Visible = false;
            // 
            // pBimg1
            // 
            this.pBimg1.Location = new System.Drawing.Point(122, 187);
            this.pBimg1.Name = "pBimg1";
            this.pBimg1.Size = new System.Drawing.Size(133, 123);
            this.pBimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimg1.TabIndex = 22;
            this.pBimg1.TabStop = false;
            this.pBimg1.Visible = false;
            this.pBimg1.Click += new System.EventHandler(this.pBimg1_Click);
            // 
            // pBimg2
            // 
            this.pBimg2.Location = new System.Drawing.Point(344, 187);
            this.pBimg2.Name = "pBimg2";
            this.pBimg2.Size = new System.Drawing.Size(133, 123);
            this.pBimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimg2.TabIndex = 23;
            this.pBimg2.TabStop = false;
            this.pBimg2.Visible = false;
            this.pBimg2.Click += new System.EventHandler(this.pBimg2_Click);
            // 
            // pBimg3
            // 
            this.pBimg3.Location = new System.Drawing.Point(564, 187);
            this.pBimg3.Name = "pBimg3";
            this.pBimg3.Size = new System.Drawing.Size(133, 123);
            this.pBimg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimg3.TabIndex = 24;
            this.pBimg3.TabStop = false;
            this.pBimg3.Visible = false;
            this.pBimg3.Click += new System.EventHandler(this.pBimg3_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResultado.Location = new System.Drawing.Point(322, 319);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(107, 45);
            this.lblResultado.TabIndex = 25;
            this.lblResultado.Text = "label1";
            this.lblResultado.Visible = false;
            // 
            // txtBoxPuntos
            // 
            this.txtBoxPuntos.Location = new System.Drawing.Point(745, 18);
            this.txtBoxPuntos.Name = "txtBoxPuntos";
            this.txtBoxPuntos.ReadOnly = true;
            this.txtBoxPuntos.Size = new System.Drawing.Size(43, 23);
            this.txtBoxPuntos.TabIndex = 26;
            this.txtBoxPuntos.Visible = false;
            // 
            // pbTrofeo
            // 
            this.pbTrofeo.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.trofeo;
            this.pbTrofeo.Location = new System.Drawing.Point(585, 277);
            this.pbTrofeo.Name = "pbTrofeo";
            this.pbTrofeo.Size = new System.Drawing.Size(159, 159);
            this.pbTrofeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTrofeo.TabIndex = 27;
            this.pbTrofeo.TabStop = false;
            this.pbTrofeo.Visible = false;
            // 
            // AquiNoVa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbTrofeo);
            this.Controls.Add(this.txtBoxPuntos);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pBimg3);
            this.Controls.Add(this.pBimg2);
            this.Controls.Add(this.pBimg1);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.pbAqui);
            this.Controls.Add(this.lbPuntos);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.lbAqui);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lbInstrucciones);
            this.Controls.Add(this.lbTitulo);
            this.Name = "AquiNoVa";
            this.Text = "AquiNoVa";
            ((System.ComponentModel.ISupportInitialize)(this.pbAqui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrofeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAqui;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lbInstrucciones;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.PictureBox pbAqui;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.PictureBox pBimg1;
        private System.Windows.Forms.PictureBox pBimg2;
        private System.Windows.Forms.PictureBox pBimg3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtBoxPuntos;
        private System.Windows.Forms.PictureBox pbTrofeo;
    }
}