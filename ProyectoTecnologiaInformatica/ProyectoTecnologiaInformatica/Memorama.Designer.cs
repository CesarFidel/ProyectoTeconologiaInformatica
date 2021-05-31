
namespace ProyectoTecnologiaInformatica
{
    partial class Memorama
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbInstrucciones = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.pbMemo1 = new System.Windows.Forms.PictureBox();
            this.lbMemo = new System.Windows.Forms.Label();
            this.pbMemo2 = new System.Windows.Forms.PictureBox();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.lbPares = new System.Windows.Forms.Label();
            this.panelMemo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.cbNumeroPares = new System.Windows.Forms.ComboBox();
            this.lbCartas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemo2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.Color.Red;
            this.lbTitulo.Location = new System.Drawing.Point(214, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(384, 65);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "INSTRUCCIONES";
            // 
            // lbInstrucciones
            // 
            this.lbInstrucciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInstrucciones.Location = new System.Drawing.Point(102, 148);
            this.lbInstrucciones.Name = "lbInstrucciones";
            this.lbInstrucciones.Size = new System.Drawing.Size(689, 240);
            this.lbInstrucciones.TabIndex = 9;
            this.lbInstrucciones.Text = " ";
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.Yellow;
            this.btnComenzar.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComenzar.Location = new System.Drawing.Point(287, 368);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(221, 68);
            this.btnComenzar.TabIndex = 10;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // pbMemo1
            // 
            this.pbMemo1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pbMemo1.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Memo;
            this.pbMemo1.Location = new System.Drawing.Point(214, 66);
            this.pbMemo1.Name = "pbMemo1";
            this.pbMemo1.Size = new System.Drawing.Size(84, 86);
            this.pbMemo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemo1.TabIndex = 11;
            this.pbMemo1.TabStop = false;
            // 
            // lbMemo
            // 
            this.lbMemo.AutoSize = true;
            this.lbMemo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMemo.Location = new System.Drawing.Point(305, 79);
            this.lbMemo.Name = "lbMemo";
            this.lbMemo.Size = new System.Drawing.Size(198, 47);
            this.lbMemo.TabIndex = 12;
            this.lbMemo.Text = "Memorama";
            // 
            // pbMemo2
            // 
            this.pbMemo2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pbMemo2.Image = global::ProyectoTecnologiaInformatica.Properties.Resources.Memo;
            this.pbMemo2.Location = new System.Drawing.Point(510, 66);
            this.pbMemo2.Name = "pbMemo2";
            this.pbMemo2.Size = new System.Drawing.Size(84, 86);
            this.pbMemo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemo2.TabIndex = 13;
            this.pbMemo2.TabStop = false;
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.BackColor = System.Drawing.Color.Yellow;
            this.lbTiempo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTiempo.Location = new System.Drawing.Point(21, 17);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(79, 22);
            this.lbTiempo.TabIndex = 16;
            this.lbTiempo.Text = "Tiempo:";
            this.lbTiempo.Visible = false;
            // 
            // lbPares
            // 
            this.lbPares.AutoSize = true;
            this.lbPares.BackColor = System.Drawing.Color.Yellow;
            this.lbPares.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPares.Location = new System.Drawing.Point(659, 17);
            this.lbPares.Name = "lbPares";
            this.lbPares.Size = new System.Drawing.Size(65, 22);
            this.lbPares.TabIndex = 17;
            this.lbPares.Text = "Pares:";
            this.lbPares.Visible = false;
            // 
            // panelMemo
            // 
            this.panelMemo.Location = new System.Drawing.Point(62, 66);
            this.panelMemo.Name = "panelMemo";
            this.panelMemo.Size = new System.Drawing.Size(674, 338);
            this.panelMemo.TabIndex = 18;
            this.panelMemo.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // cbNumeroPares
            // 
            this.cbNumeroPares.FormattingEnabled = true;
            this.cbNumeroPares.Items.AddRange(new object[] {
            "6",
            "10"});
            this.cbNumeroPares.Location = new System.Drawing.Point(436, 339);
            this.cbNumeroPares.Name = "cbNumeroPares";
            this.cbNumeroPares.Size = new System.Drawing.Size(114, 23);
            this.cbNumeroPares.TabIndex = 19;
            this.cbNumeroPares.SelectedIndexChanged += new System.EventHandler(this.cbNumeroPares_SelectedIndexChanged);
            // 
            // lbCartas
            // 
            this.lbCartas.AutoSize = true;
            this.lbCartas.Location = new System.Drawing.Point(253, 342);
            this.lbCartas.Name = "lbCartas";
            this.lbCartas.Size = new System.Drawing.Size(177, 15);
            this.lbCartas.TabIndex = 20;
            this.lbCartas.Text = "Selecciona el Numero de Cartas:";
            // 
            // Memorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCartas);
            this.Controls.Add(this.cbNumeroPares);
            this.Controls.Add(this.panelMemo);
            this.Controls.Add(this.lbPares);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.pbMemo2);
            this.Controls.Add(this.lbMemo);
            this.Controls.Add(this.pbMemo1);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lbInstrucciones);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Memorama";
            this.Text = "Memorama";
            ((System.ComponentModel.ISupportInitialize)(this.pbMemo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbInstrucciones;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.PictureBox pbMemo1;
        private System.Windows.Forms.Label lbMemo;
        private System.Windows.Forms.PictureBox pbMemo2;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Label lbPares;
        private System.Windows.Forms.Panel panelMemo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.ComboBox cbNumeroPares;
        private System.Windows.Forms.Label lbCartas;
    }
}