
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
            ((System.ComponentModel.ISupportInitialize)(this.pbAqui)).BeginInit();
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
            this.lbPuntos.Size = new System.Drawing.Size(74, 22);
            this.lbPuntos.TabIndex = 19;
            this.lbPuntos.Text = "Puntos:";
            this.lbPuntos.Visible = false;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.BackColor = System.Drawing.Color.Aqua;
            this.lbTiempo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTiempo.Location = new System.Drawing.Point(27, 18);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(79, 22);
            this.lbTiempo.TabIndex = 18;
            this.lbTiempo.Text = "Tiempo:";
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
            // AquiNoVa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}