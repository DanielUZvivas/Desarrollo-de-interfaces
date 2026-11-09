using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1//Icono. Otro boton raton.Sin PointToClient
{
    public partial class Form1 : Form
    {
        private string tituloOriginal;
        private const int FILAS = 4;
        private const int COLUMNAS = 5;

        public Form1()
        {
            InitializeComponent();
            tituloOriginal = this.Text;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;


            CrearBotones();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                this.Text = "x: " + (e.X + btn.Location.X) + "  y: " + (e.Y + btn.Location.Y);
            }
            else
            {
                this.Text = "x: " + e.X + "  y: " + e.Y;
            }
        }

        private void lblCords(object sender, EventArgs e)
        {

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {

            this.Text = "Mouse Tester";

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Blue;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = tituloOriginal;

            }
            else
            {
                this.Text = e.KeyCode.ToString();

            }


        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Red;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
            }
        }
        private void CrearBotones()
        {
            int ancho = 60;
            int alto = 40;
            int separacion = 10;
            int xInicio = 20;
            int yInicio = Math.Max(button1.Bottom, button2.Bottom) + 20;
            int numero = 1;

            for (int fila = 0; fila < FILAS; fila++)
            {
                for (int col = 0; col < COLUMNAS; col++)
                {
                    Button b = new Button();
                    b.Text = numero.ToString();
                    b.Size = new Size(ancho, alto);
                    b.Location = new Point(xInicio + col * (ancho + separacion), yInicio + fila * (alto + separacion));
                    b.ForeColor = Color.Black;
                    b.MouseDown += Boton_MouseDown;
                    b.MouseUp += Boton_MouseUp;
                    b.MouseMove += Boton_MouseMove;

                    this.Controls.Add(b);
                    numero++;
                }
            }
        }

        private void Boton_MouseDown(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Red;
        }

        private void Boton_MouseUp(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }

        private void Boton_MouseMove(object sender, MouseEventArgs e)
        {

            Button b = (Button)sender;
            this.Text = "x: " + (e.X + b.Location.X) + "  y: " + (e.Y + b.Location.Y);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
