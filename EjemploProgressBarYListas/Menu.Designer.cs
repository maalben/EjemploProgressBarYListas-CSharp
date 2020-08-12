namespace EjemploProgressBarYListas
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnentrar1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barraprogreso1 = new System.Windows.Forms.ProgressBar();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnentrar2 = new System.Windows.Forms.Button();
            this.barraprogreso2 = new System.Windows.Forms.ProgressBar();
            this.lblporcentaje2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(240, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(55, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Llenar lista con números";
            // 
            // btnentrar1
            // 
            this.btnentrar1.Location = new System.Drawing.Point(362, 161);
            this.btnentrar1.Name = "btnentrar1";
            this.btnentrar1.Size = new System.Drawing.Size(75, 31);
            this.btnentrar1.TabIndex = 2;
            this.btnentrar1.Text = "Entrar";
            this.btnentrar1.UseVisualStyleBackColor = true;
            this.btnentrar1.Click += new System.EventHandler(this.btnentrar1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barraprogreso1
            // 
            this.barraprogreso1.Location = new System.Drawing.Point(443, 170);
            this.barraprogreso1.Name = "barraprogreso1";
            this.barraprogreso1.Size = new System.Drawing.Size(183, 12);
            this.barraprogreso1.TabIndex = 3;
            this.barraprogreso1.Visible = false;
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Location = new System.Drawing.Point(633, 169);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(21, 13);
            this.lblporcentaje.TabIndex = 4;
            this.lblporcentaje.Text = "0%";
            this.lblporcentaje.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(55, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "No hace nada";
            // 
            // btnentrar2
            // 
            this.btnentrar2.Location = new System.Drawing.Point(362, 217);
            this.btnentrar2.Name = "btnentrar2";
            this.btnentrar2.Size = new System.Drawing.Size(75, 31);
            this.btnentrar2.TabIndex = 6;
            this.btnentrar2.Text = "Entrar";
            this.btnentrar2.UseVisualStyleBackColor = true;
            this.btnentrar2.Click += new System.EventHandler(this.btnentrar2_Click);
            // 
            // barraprogreso2
            // 
            this.barraprogreso2.Location = new System.Drawing.Point(443, 227);
            this.barraprogreso2.Name = "barraprogreso2";
            this.barraprogreso2.Size = new System.Drawing.Size(183, 12);
            this.barraprogreso2.TabIndex = 7;
            this.barraprogreso2.Visible = false;
            // 
            // lblporcentaje2
            // 
            this.lblporcentaje2.AutoSize = true;
            this.lblporcentaje2.Location = new System.Drawing.Point(633, 227);
            this.lblporcentaje2.Name = "lblporcentaje2";
            this.lblporcentaje2.Size = new System.Drawing.Size(21, 13);
            this.lblporcentaje2.TabIndex = 8;
            this.lblporcentaje2.Text = "0%";
            this.lblporcentaje2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblporcentaje2);
            this.Controls.Add(this.barraprogreso2);
            this.Controls.Add(this.btnentrar2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.barraprogreso1);
            this.Controls.Add(this.btnentrar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnentrar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar barraprogreso1;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnentrar2;
        private System.Windows.Forms.ProgressBar barraprogreso2;
        private System.Windows.Forms.Label lblporcentaje2;
        private System.Windows.Forms.Timer timer2;
    }
}