using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProgressBarYListas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barraprogreso1.Visible = true;
            lblporcentaje.Visible = true;

            if (barraprogreso1.Value < 100)
            {
                barraprogreso1.Value = barraprogreso1.Value + 1;
                lblporcentaje.Text = barraprogreso1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Ejercicio1 ejercicio1 = new Ejercicio1();
                ejercicio1.Show();
                this.Dispose();
            }

        }

        private void btnentrar1_Click(object sender, EventArgs e)
        {
            btnentrar1.Enabled = false;
            this.timer1.Start();
        }

        private void btnentrar2_Click(object sender, EventArgs e)
        {
            btnentrar2.Enabled = false;
            this.timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            barraprogreso2.Visible = true;
            lblporcentaje2.Visible = true;

            if (barraprogreso2.Value < 100)
            {
                barraprogreso2.Value = barraprogreso2.Value + 1;
                lblporcentaje2.Text = barraprogreso2.Value.ToString() + "%";
            }
            else
            {
                timer2.Stop();
                Ejercicio2 ejercicio2 = new Ejercicio2();
                ejercicio2.Show();
                this.Dispose();
            }
        }
    }
}
