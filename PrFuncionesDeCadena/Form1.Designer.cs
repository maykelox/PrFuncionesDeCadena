namespace PrFuncionesDeCadena
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUltimoCaracter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimerCaracter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt26 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimeraLetra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMayuscula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinuscula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEspacioEnBlanco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena:";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(150, 28);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(210, 23);
            this.txtCadena.TabIndex = 1;
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(150, 80);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(210, 23);
            this.txtLongitud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitud:";
            // 
            // txtUltimoCaracter
            // 
            this.txtUltimoCaracter.Location = new System.Drawing.Point(150, 125);
            this.txtUltimoCaracter.Name = "txtUltimoCaracter";
            this.txtUltimoCaracter.Size = new System.Drawing.Size(210, 23);
            this.txtUltimoCaracter.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ultimo Caracter:";
            // 
            // txtPrimerCaracter
            // 
            this.txtPrimerCaracter.Location = new System.Drawing.Point(150, 170);
            this.txtPrimerCaracter.Name = "txtPrimerCaracter";
            this.txtPrimerCaracter.Size = new System.Drawing.Size(210, 23);
            this.txtPrimerCaracter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Primer Caracter:";
            // 
            // txt26
            // 
            this.txt26.Location = new System.Drawing.Point(150, 218);
            this.txt26.Name = "txt26";
            this.txt26.Size = new System.Drawing.Size(210, 23);
            this.txt26.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "2do y 6to Caracter:";
            // 
            // txtPrimeraLetra
            // 
            this.txtPrimeraLetra.Location = new System.Drawing.Point(166, 263);
            this.txtPrimeraLetra.Name = "txtPrimeraLetra";
            this.txtPrimeraLetra.Size = new System.Drawing.Size(194, 23);
            this.txtPrimeraLetra.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Posicion de la 1ra letra A:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtMayuscula
            // 
            this.txtMayuscula.Location = new System.Drawing.Point(150, 316);
            this.txtMayuscula.Name = "txtMayuscula";
            this.txtMayuscula.Size = new System.Drawing.Size(210, 23);
            this.txtMayuscula.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mayuscula:";
            // 
            // txtMinuscula
            // 
            this.txtMinuscula.Location = new System.Drawing.Point(150, 363);
            this.txtMinuscula.Name = "txtMinuscula";
            this.txtMinuscula.Size = new System.Drawing.Size(210, 23);
            this.txtMinuscula.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Minuscula:";
            // 
            // txtEspacioEnBlanco
            // 
            this.txtEspacioEnBlanco.Location = new System.Drawing.Point(166, 402);
            this.txtEspacioEnBlanco.Name = "txtEspacioEnBlanco";
            this.txtEspacioEnBlanco.Size = new System.Drawing.Size(194, 23);
            this.txtEspacioEnBlanco.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Borrar espacios en blanco:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(458, 27);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 18;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 451);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtEspacioEnBlanco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMinuscula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMayuscula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimeraLetra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt26);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrimerCaracter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUltimoCaracter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Funciones de cadena string ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCadena;
        private TextBox txtLongitud;
        private Label label2;
        private TextBox txtUltimoCaracter;
        private Label label3;
        private TextBox txtPrimerCaracter;
        private Label label4;
        private TextBox txt26;
        private Label label5;
        private TextBox txtPrimeraLetra;
        private Label label6;
        private TextBox txtMayuscula;
        private Label label7;
        private TextBox txtMinuscula;
        private Label label8;
        private TextBox txtEspacioEnBlanco;
        private Label label9;
        private Button btnProcesar;
        private EventHandler label6_Click;

        public EventHandler Form1_Load { get; private set; }
    }
}