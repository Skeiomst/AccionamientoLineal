namespace AccionamientoLineal
{
    partial class FrmMain
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
            btnEncender = new Button();
            btnApagar = new Button();
            btnConectar = new Button();
            lblPuerto = new Label();
            cbxPuertos = new ComboBox();
            pictureBox1 = new PictureBox();
            lblEstado = new Label();
            textBox1 = new TextBox();
            lblEncendido = new Label();
            lblPasos = new Label();
            lblRegistros = new Label();
            lblInferior = new Label();
            lblLsd = new Label();
            lblSuperior = new Label();
            lblLsu = new Label();
            txtPasos = new TextBox();
            lbxRegistros = new ListBox();
            colorDialog1 = new ColorDialog();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnEncender
            // 
            btnEncender.Enabled = false;
            btnEncender.Location = new Point(50, 58);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(182, 90);
            btnEncender.TabIndex = 0;
            btnEncender.Text = "Encender";
            btnEncender.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            btnApagar.Enabled = false;
            btnApagar.Location = new Point(50, 178);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(182, 90);
            btnApagar.TabIndex = 1;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(50, 297);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(182, 89);
            btnConectar.TabIndex = 2;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            // 
            // lblPuerto
            // 
            lblPuerto.Anchor = AnchorStyles.None;
            lblPuerto.AutoSize = true;
            lblPuerto.ImageAlign = ContentAlignment.MiddleLeft;
            lblPuerto.Location = new Point(50, 404);
            lblPuerto.Margin = new Padding(0);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(162, 25);
            lblPuerto.TabIndex = 3;
            lblPuerto.Text = "Puerto del Arduino";
            // 
            // cbxPuertos
            // 
            cbxPuertos.FormattingEnabled = true;
            cbxPuertos.Location = new Point(50, 432);
            cbxPuertos.Name = "cbxPuertos";
            cbxPuertos.Size = new Size(182, 33);
            cbxPuertos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Apgado;
            pictureBox1.Location = new Point(80, 499);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(50, 636);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(70, 25);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 636);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 31);
            textBox1.TabIndex = 7;
            // 
            // lblEncendido
            // 
            lblEncendido.AutoSize = true;
            lblEncendido.Location = new Point(380, 58);
            lblEncendido.Name = "lblEncendido";
            lblEncendido.Size = new Size(427, 25);
            lblEncendido.TabIndex = 9;
            lblEncendido.Text = "Sistema encendido capturando datos desde arduino";
            // 
            // lblPasos
            // 
            lblPasos.AutoSize = true;
            lblPasos.Location = new Point(405, 123);
            lblPasos.Name = "lblPasos";
            lblPasos.Size = new Size(167, 25);
            lblPasos.TabIndex = 10;
            lblPasos.Text = "Pasos totales leidos";
            // 
            // lblRegistros
            // 
            lblRegistros.AutoSize = true;
            lblRegistros.Location = new Point(405, 255);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(150, 25);
            lblRegistros.TabIndex = 11;
            lblRegistros.Text = "Registro histórico";
            // 
            // lblInferior
            // 
            lblInferior.AutoSize = true;
            lblInferior.Location = new Point(863, 147);
            lblInferior.Name = "lblInferior";
            lblInferior.Size = new Size(221, 25);
            lblInferior.TabIndex = 12;
            lblInferior.Text = "Detección extremo inferior";
            // 
            // lblLsd
            // 
            lblLsd.AutoSize = true;
            lblLsd.Location = new Point(920, 181);
            lblLsd.Name = "lblLsd";
            lblLsd.Size = new Size(43, 25);
            lblLsd.TabIndex = 13;
            lblLsd.Text = "LSD";
            // 
            // lblSuperior
            // 
            lblSuperior.AutoSize = true;
            lblSuperior.Location = new Point(863, 246);
            lblSuperior.Name = "lblSuperior";
            lblSuperior.Size = new Size(230, 25);
            lblSuperior.TabIndex = 14;
            lblSuperior.Text = "Detección extremo superior";
            // 
            // lblLsu
            // 
            lblLsu.AutoSize = true;
            lblLsu.Location = new Point(920, 285);
            lblLsu.Name = "lblLsu";
            lblLsu.Size = new Size(42, 25);
            lblLsu.TabIndex = 15;
            lblLsu.Text = "LSU";
            // 
            // txtPasos
            // 
            txtPasos.Location = new Point(405, 169);
            txtPasos.Name = "txtPasos";
            txtPasos.ReadOnly = true;
            txtPasos.Size = new Size(200, 31);
            txtPasos.TabIndex = 16;
            // 
            // lbxRegistros
            // 
            lbxRegistros.FormattingEnabled = true;
            lbxRegistros.ItemHeight = 25;
            lbxRegistros.Location = new Point(411, 304);
            lbxRegistros.Name = "lbxRegistros";
            lbxRegistros.SelectionMode = SelectionMode.None;
            lbxRegistros.Size = new Size(238, 329);
            lbxRegistros.TabIndex = 17;
            lbxRegistros.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Apgado;
            pictureBox3.Location = new Point(790, 147);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 62);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Apgado;
            pictureBox4.Location = new Point(790, 248);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(67, 62);
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Apgado;
            pictureBox2.Location = new Point(282, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 62);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(lbxRegistros);
            Controls.Add(txtPasos);
            Controls.Add(lblLsu);
            Controls.Add(lblSuperior);
            Controls.Add(lblLsd);
            Controls.Add(lblInferior);
            Controls.Add(lblRegistros);
            Controls.Add(lblPasos);
            Controls.Add(lblEncendido);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(lblEstado);
            Controls.Add(pictureBox1);
            Controls.Add(cbxPuertos);
            Controls.Add(lblPuerto);
            Controls.Add(btnConectar);
            Controls.Add(btnApagar);
            Controls.Add(btnEncender);
            Name = "FrmMain";
            Text = "Sistema para calibración de milimetros por paso";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncender;
        private Button btnApagar;
        private Button btnConectar;
        private Label lblPuerto;
        private ComboBox cbxPuertos;
        private PictureBox pictureBox1;
        private Label lblEstado;
        private TextBox textBox1;
        private Label lblEncendido;
        private Label lblPasos;
        private Label lblRegistros;
        private Label lblInferior;
        private Label lblLsd;
        private Label lblSuperior;
        private Label lblLsu;
        private TextBox txtPasos;
        private ListBox lbxRegistros;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
    }
}
