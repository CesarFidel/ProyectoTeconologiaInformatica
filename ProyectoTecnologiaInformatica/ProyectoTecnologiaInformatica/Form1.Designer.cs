
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
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(296, 260);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(193, 59);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(296, 338);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(193, 59);
            this.btnAyuda.TabIndex = 1;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // lblEligeJuego
            // 
            this.lblEligeJuego.AutoSize = true;
            this.lblEligeJuego.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEligeJuego.Location = new System.Drawing.Point(12, 125);
            this.lblEligeJuego.Name = "lblEligeJuego";
            this.lblEligeJuego.Size = new System.Drawing.Size(187, 37);
            this.lblEligeJuego.TabIndex = 2;
            this.lblEligeJuego.Text = "Elige un juego";
            this.lblEligeJuego.Visible = false;
            // 
            // btnMemorama
            // 
            this.btnMemorama.Location = new System.Drawing.Point(52, 184);
            this.btnMemorama.Name = "btnMemorama";
            this.btnMemorama.Size = new System.Drawing.Size(215, 35);
            this.btnMemorama.TabIndex = 3;
            this.btnMemorama.Text = "Memorama";
            this.btnMemorama.UseVisualStyleBackColor = true;
            this.btnMemorama.Visible = false;
            // 
            // btnDondeEstaba
            // 
            this.btnDondeEstaba.Location = new System.Drawing.Point(52, 260);
            this.btnDondeEstaba.Name = "btnDondeEstaba";
            this.btnDondeEstaba.Size = new System.Drawing.Size(215, 35);
            this.btnDondeEstaba.TabIndex = 4;
            this.btnDondeEstaba.Text = "¿Dónde estaba?";
            this.btnDondeEstaba.UseVisualStyleBackColor = true;
            this.btnDondeEstaba.Visible = false;
            // 
            // btnAquiNo
            // 
            this.btnAquiNo.Location = new System.Drawing.Point(52, 338);
            this.btnAquiNo.Name = "btnAquiNo";
            this.btnAquiNo.Size = new System.Drawing.Size(215, 35);
            this.btnAquiNo.TabIndex = 5;
            this.btnAquiNo.Text = "¡Aquí no va!";
            this.btnAquiNo.UseVisualStyleBackColor = true;
            this.btnAquiNo.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblAyudaGrande.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAyudaGrande.Location = new System.Drawing.Point(196, 22);
            this.lblAyudaGrande.Name = "lblAyudaGrande";
            this.lblAyudaGrande.Size = new System.Drawing.Size(409, 46);
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
            this.lblAyudaPequeña.Location = new System.Drawing.Point(196, 114);
            this.lblAyudaPequeña.Name = "lblAyudaPequeña";
            this.lblAyudaPequeña.Size = new System.Drawing.Size(409, 143);
            this.lblAyudaPequeña.TabIndex = 8;
            this.lblAyudaPequeña.Text = " ";
            this.lblAyudaPequeña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAyudaPequeña.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAyudaPequeña);
            this.Controls.Add(this.lblAyudaGrande);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAquiNo);
            this.Controls.Add(this.btnDondeEstaba);
            this.Controls.Add(this.btnMemorama);
            this.Controls.Add(this.lblEligeJuego);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnInicio);
            this.Name = "Form1";
            this.Text = "CogniGames";
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
    }
}

