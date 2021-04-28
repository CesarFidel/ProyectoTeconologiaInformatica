
namespace ProyectoTecnologiaInformatica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.lblEligeJuego = new System.Windows.Forms.Label();
            this.btnMemorama = new System.Windows.Forms.Button();
            this.btnDondeEstaba = new System.Windows.Forms.Button();
            this.btnAquiNo = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblAyudaGrande = new System.Windows.Forms.Label();
            this.lblAyudaPequeña = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbMemo = new System.Windows.Forms.PictureBox();
            this.pbDonde = new System.Windows.Forms.PictureBox();
            this.pbAqui = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAqui)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.Location = new System.Drawing.Point(296, 260);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(193, 59);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INICIAR";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.Location = new System.Drawing.Point(296, 338);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(193, 59);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblEligeJuego
            // 
            this.lblEligeJuego.AutoSize = true;
            this.lblEligeJuego.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEligeJuego.Location = new System.Drawing.Point(95, 126);
            this.lblEligeJuego.Name = "lblEligeJuego";
            this.lblEligeJuego.Size = new System.Drawing.Size(204, 40);
            this.lblEligeJuego.TabIndex = 2;
            this.lblEligeJuego.Text = "Elige un juego:";
            this.lblEligeJuego.Visible = false;
            // 
            // btnMemorama
            // 
            this.btnMemorama.BackColor = System.Drawing.Color.Lime;
            this.btnMemorama.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnMemorama.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMemorama.ForeColor = System.Drawing.Color.White;
            this.btnMemorama.Location = new System.Drawing.Point(164, 191);
            this.btnMemorama.Name = "btnMemorama";
            this.btnMemorama.Size = new System.Drawing.Size(215, 45);
            this.btnMemorama.TabIndex = 3;
            this.btnMemorama.Text = "Memorama";
            this.btnMemorama.UseVisualStyleBackColor = false;
            this.btnMemorama.Visible = false;
            this.btnMemorama.Click += new System.EventHandler(this.btnMemorama_Click);
            // 
            // btnDondeEstaba
            // 
            this.btnDondeEstaba.BackColor = System.Drawing.Color.Lime;
            this.btnDondeEstaba.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDondeEstaba.ForeColor = System.Drawing.Color.White;
            this.btnDondeEstaba.Location = new System.Drawing.Point(164, 278);
            this.btnDondeEstaba.Name = "btnDondeEstaba";
            this.btnDondeEstaba.Size = new System.Drawing.Size(215, 45);
            this.btnDondeEstaba.TabIndex = 4;
            this.btnDondeEstaba.Text = "¿Dónde Estaba?";
            this.btnDondeEstaba.UseVisualStyleBackColor = false;
            this.btnDondeEstaba.Visible = false;
            this.btnDondeEstaba.Click += new System.EventHandler(this.btnDondeEstaba_Click);
            // 
            // btnAquiNo
            // 
            this.btnAquiNo.BackColor = System.Drawing.Color.Lime;
            this.btnAquiNo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAquiNo.ForeColor = System.Drawing.Color.White;
            this.btnAquiNo.Location = new System.Drawing.Point(164, 366);
            this.btnAquiNo.Name = "btnAquiNo";
            this.btnAquiNo.Size = new System.Drawing.Size(215, 45);
            this.btnAquiNo.TabIndex = 5;
            this.btnAquiNo.Text = "¡Aquí No Va!";
            this.btnAquiNo.UseVisualStyleBackColor = false;
            this.btnAquiNo.Visible = false;
            this.btnAquiNo.Click += new System.EventHandler(this.btnAquiNo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegresar.Location = new System.Drawing.Point(726, 390);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(62, 48);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblAyudaGrande
            // 
            this.lblAyudaGrande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyudaGrande.AutoSize = true;
            this.lblAyudaGrande.Font = new System.Drawing.Font("Verdana", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAyudaGrande.ForeColor = System.Drawing.Color.White;
            this.lblAyudaGrande.Location = new System.Drawing.Point(150, 47);
            this.lblAyudaGrande.Name = "lblAyudaGrande";
            this.lblAyudaGrande.Size = new System.Drawing.Size(498, 40);
            this.lblAyudaGrande.TabIndex = 7;
            this.lblAyudaGrande.Text = "Bienvenido a CogniGames";
            this.lblAyudaGrande.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAyudaGrande.Visible = false;
            // 
            // lblAyudaPequeña
            // 
            this.lblAyudaPequeña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyudaPequeña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAyudaPequeña.Location = new System.Drawing.Point(196, 114);
            this.lblAyudaPequeña.Name = "lblAyudaPequeña";
            this.lblAyudaPequeña.Size = new System.Drawing.Size(409, 169);
            this.lblAyudaPequeña.TabIndex = 8;
            this.lblAyudaPequeña.Text = " ";
            this.lblAyudaPequeña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAyudaPequeña.Visible = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Green;
            this.pbLogo.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Cogni;
            this.pbLogo.Location = new System.Drawing.Point(196, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(421, 209);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // pbMemo
            // 
            this.pbMemo.BackColor = System.Drawing.Color.Purple;
            this.pbMemo.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Memo;
            this.pbMemo.Location = new System.Drawing.Point(460, 149);
            this.pbMemo.Name = "pbMemo";
            this.pbMemo.Size = new System.Drawing.Size(101, 114);
            this.pbMemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemo.TabIndex = 10;
            this.pbMemo.TabStop = false;
            this.pbMemo.Visible = false;
            // 
            // pbDonde
            // 
            this.pbDonde.BackColor = System.Drawing.Color.Purple;
            this.pbDonde.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Pensi;
            this.pbDonde.Location = new System.Drawing.Point(460, 260);
            this.pbDonde.Name = "pbDonde";
            this.pbDonde.Size = new System.Drawing.Size(113, 89);
            this.pbDonde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDonde.TabIndex = 11;
            this.pbDonde.TabStop = false;
            this.pbDonde.Visible = false;
            // 
            // pbAqui
            // 
            this.pbAqui.BackColor = System.Drawing.Color.Purple;
            this.pbAqui.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Aqui_no;
            this.pbAqui.Location = new System.Drawing.Point(427, 356);
            this.pbAqui.Name = "pbAqui";
            this.pbAqui.Size = new System.Drawing.Size(163, 55);
            this.pbAqui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAqui.TabIndex = 12;
            this.pbAqui.TabStop = false;
            this.pbAqui.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbAqui);
            this.Controls.Add(this.pbDonde);
            this.Controls.Add(this.pbMemo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblAyudaPequeña);
            this.Controls.Add(this.lblAyudaGrande);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAquiNo);
            this.Controls.Add(this.btnDondeEstaba);
            this.Controls.Add(this.btnMemorama);
            this.Controls.Add(this.lblEligeJuego);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnInicio);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "CogniGames";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDonde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAqui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblEligeJuego;
        private System.Windows.Forms.Button btnMemorama;
        private System.Windows.Forms.Button btnDondeEstaba;
        private System.Windows.Forms.Button btnAquiNo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblAyudaGrande;
        private System.Windows.Forms.Label lblAyudaPequeña;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbMemo;
        private System.Windows.Forms.PictureBox pbDonde;
        private System.Windows.Forms.PictureBox pbAqui;
    }
}

