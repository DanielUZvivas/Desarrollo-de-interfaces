using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labels();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String texto = txtFrase.Text;
            if (!lb1.Items.Contains(texto))
            {
                lb1.Items.Add(texto);
            }
            labels();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                if (lb1.SelectedItems.Count > 0)
                {
                    for (int i = lb1.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        lb1.Items.Remove(lb1.SelectedItems[i]);
                    }
                }
            }
            else if (rbLista2.Checked)
            {
               
                        lb2.Items.Remove(lb2.SelectedItem);
                 

            }
            labels();

        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            if (rbTraspaso1.Checked)
            {
                if (lb1.SelectedItems.Count > 0)
                {
                    for (int i = lb1.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        lb2.Items.Add(lb1.SelectedItems[i]);
                        lb1.Items.Remove(lb1.SelectedItems[i]);
                    }
                }
            }
            else if (rbTraspaso2.Checked)
            {
                
                        lb1.Items.Add(lb2.SelectedItem);
                        lb2.Items.Remove(lb2.SelectedItem);
                 
            }
            labels();
        }

        private void labels()
        {
            lblNelements.Text = "" + lb1.Items.Count;
            lblIndicesSelected.Text = "";
            for (int i = 0; i < lb1.SelectedIndices.Count; i++)
            {
                lblIndicesSelected.Text += lb1.SelectedIndices[i] + " ";
            }
            toolTip1.SetToolTip(lb2,"Elementos: "+ lb2.Items.Count);
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labels();
        }
        private static string titulo = "Ejercicio 4";
        private static int longitud = titulo.Length;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string tituloFin = titulo.Substring(longitud);
            this.Text = tituloFin;
            longitud--;
            if(longitud < 0)
            {
                longitud = titulo.Length;
            }
            if(longitud %2  == 0)
            {
                this.Icon = Properties.Resources.bmw;
            }
            else
            {
                this.Icon = Properties.Resources.honda;
            }
        }

        private void rbLista1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLista1.Checked)
            {
                btnBorrar.Text = "Borrar de lista 1";
            }
            else
            {
                btnBorrar.Text = "Borrar de lista 2";
            }
        }

        private void rbTraspaso1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTraspaso1.Checked)
            {
                btnTraspasar.Text = "Traspasar de lista 1 a la 2";
            }
            else
            {
                btnTraspasar.Text = "Traspasar de lista 2 a la 1";
            }
        }
    }
}

