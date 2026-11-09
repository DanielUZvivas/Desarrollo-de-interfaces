using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ejercicio2";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Mi Aplicacion", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            bool valido = true;
            TextBox[] cajas = { txtRed, txtGreen, txtBlue };
            int numero;
            foreach (TextBox caja in cajas)
            {
                if(!int.TryParse(caja.Text,out numero) || numero < 0 || numero > 255)
                {
                    valido = false;
                    
                }
            }

            if(valido)
            {
                
                lblErrorColor.Text = "";
                this.BackColor = Color.FromArgb(int.Parse(txtRed.Text),int.Parse(txtGreen.Text),int.Parse(txtBlue.Text));
            }
            else
            {
                lblErrorColor.Text = "Los numeros tienen que estar entre 0 y 255";
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("La ruta especificada no existe");
                return;
            }

            try
            {
                picbxImagen.Image = Image.FromFile(path);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ese archivo no es una imagen");
            }
        }

        private void txtRed_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnColor;
        }

        private void txtPath_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnImagen;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(Control t in this.Controls)
            {
                if (t.GetType() == typeof(TextBox))
                {
                    if (t.Name == txtPath.Name)
                    {
                        t.Text = "";
                    }
                    else
                    {
                        t.Text = "0";
                    }
                }
            }
            
            picbxImagen.Image = null;
            this.BackColor = SystemColors.Control;
        }

        private void btnCambioColorEnter(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.Tag = boton.BackColor;
            boton.BackColor = Color.SkyBlue;
        }

        private void btnCambioColorLeave(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.WhiteSmoke;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
