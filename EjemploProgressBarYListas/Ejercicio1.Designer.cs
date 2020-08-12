namespace EjemploProgressBarYListas
{
    partial class Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.lbnumeros = new System.Windows.Forms.ListBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F);
            this.label1.Location = new System.Drawing.Point(47, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número no mayor a 101";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(32, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Llenar lista con números";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.txtnumero.Location = new System.Drawing.Point(516, 120);
            this.txtnumero.MaxLength = 3;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 60);
            this.txtnumero.TabIndex = 3;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(53, 212);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(227, 55);
            this.btnprocesar.TabIndex = 4;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // lbnumeros
            // 
            this.lbnumeros.FormattingEnabled = true;
            this.lbnumeros.Location = new System.Drawing.Point(714, 12);
            this.lbnumeros.Name = "lbnumeros";
            this.lbnumeros.Size = new System.Drawing.Size(53, 420);
            this.lbnumeros.TabIndex = 5;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(389, 212);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(227, 55);
            this.btnvolver.TabIndex = 6;
            this.btnvolver.Text = "Volver al menú";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lbnumeros);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.ListBox lbnumeros;
        private System.Windows.Forms.Button btnvolver;
    }
}