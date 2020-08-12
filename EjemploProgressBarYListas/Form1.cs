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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;

            if (progreso.Value < 100)
            {
                progreso.Value = progreso.Value + 1;
                label1.Text = progreso.Value.ToString() + "%";
            }
            else {
                timer1.Stop();
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
        }
    }
}
