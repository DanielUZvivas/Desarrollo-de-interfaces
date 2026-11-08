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
                if (lb2.SelectedItems.Count > 0)
                {
                    for (int i = lb2.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        lb2.Items.Remove(lb2.SelectedItems[i]);
                    }
                }

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
                if (lb2.SelectedItems.Count > 0)
                {
                    for (int i = lb2.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        lb1.Items.Add(lb2.SelectedItems[i]);
                        lb2.Items.Remove(lb2.SelectedItems[i]);
                    }
                }
            }
            labels();
        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNelements_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAceptar, "Boton para añadir el texto en la lista");
            toolTip1.SetToolTip(btnBorrar, "Boton para borrar los elementos seleccionados");
            toolTip1.SetToolTip(btnTraspasar, "Boton para traspasar los seleccioandos de una lista a otra");
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
    }
}

