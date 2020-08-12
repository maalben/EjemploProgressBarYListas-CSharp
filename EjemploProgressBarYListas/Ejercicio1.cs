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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            lbnumeros.Items.Clear();
            int numero;

            if (txtnumero.Text == "") {
                MessageBox.Show("Debes ingresar un valor");
                txtnumero.Focus();
            }
            else {


                numero = int.Parse(txtnumero.Text);
                if (numero > 100)
                {
                    MessageBox.Show("El número supera el tope máximo permitido");
                    txtnumero.Text = String.Empty;
                    txtnumero.Focus();
                }
                else
                {
                    for (int i = 0; i < numero; i++)
                    {
                        lbnumeros.Items.Add(i + 1);
                    }
                }


            }




             

      

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
