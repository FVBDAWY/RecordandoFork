namespace Ejercicio_8
{
    partial class Form1
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
            this.bNumeroAleatorio = new System.Windows.Forms.Button();
            this.bIngresarNumeros = new System.Windows.Forms.Button();
            this.bNumerosAcertados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNumeroAleatorio
            // 
            this.bNumeroAleatorio.Location = new System.Drawing.Point(249, 47);
            this.bNumeroAleatorio.Name = "bNumeroAleatorio";
            this.bNumeroAleatorio.Size = new System.Drawing.Size(249, 51);
            this.bNumeroAleatorio.TabIndex = 0;
            this.bNumeroAleatorio.Text = "Generar Numero Aleatorio";
            this.bNumeroAleatorio.UseVisualStyleBackColor = true;
            this.bNumeroAleatorio.Click += new System.EventHandler(this.bNumeroAleatorio_Click);
            // 
            // bIngresarNumeros
            // 
            this.bIngresarNumeros.Location = new System.Drawing.Point(249, 140);
            this.bIngresarNumeros.Name = "bIngresarNumeros";
            this.bIngresarNumeros.Size = new System.Drawing.Size(249, 43);
            this.bIngresarNumeros.TabIndex = 1;
            this.bIngresarNumeros.Text = "Ingresar numeros ";
            this.bIngresarNumeros.UseVisualStyleBackColor = true;
            this.bIngresarNumeros.Click += new System.EventHandler(this.bIngresarNumeros_Click);
            // 
            // bNumerosAcertados
            // 
            this.bNumerosAcertados.Location = new System.Drawing.Point(249, 219);
            this.bNumerosAcertados.Name = "bNumerosAcertados";
            this.bNumerosAcertados.Size = new System.Drawing.Size(249, 44);
            this.bNumerosAcertados.TabIndex = 2;
            this.bNumerosAcertados.Text = "Numeros acertados";
            this.bNumerosAcertados.UseVisualStyleBackColor = true;
            this.bNumerosAcertados.Click += new System.EventHandler(this.bNumerosAcertados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bNumerosAcertados);
            this.Controls.Add(this.bIngresarNumeros);
            this.Controls.Add(this.bNumeroAleatorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNumeroAleatorio;
        private System.Windows.Forms.Button bIngresarNumeros;
        private System.Windows.Forms.Button bNumerosAcertados;
    }
}

