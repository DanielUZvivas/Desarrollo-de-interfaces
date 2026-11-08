using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (sender is Button boton)
            {
                x += boton.Location.X;
                y += boton.Location.Y;
            }

            Text = String.Format("X: {0,5} , Y: {1,5}", x, y);
        }
    }
}
