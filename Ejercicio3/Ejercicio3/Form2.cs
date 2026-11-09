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

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2(string ruta)
        {
            InitializeComponent();
            try
            {
                picImagen.Image = Image.FromFile(ruta);
                this.Text = Path.GetFileName(ruta);

            }
            catch (Exception ex) 
            {
                
            }
        }

        private void seDeformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void noSeDeformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
