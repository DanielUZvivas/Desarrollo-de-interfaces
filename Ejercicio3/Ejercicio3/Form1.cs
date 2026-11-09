using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private int min = 0;
        private int seg = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Visor de imágenes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNewImg_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog(this);
            Form2 f2 = new Form2(fileDialog.FileName);
            if (chkModal.Checked) 
            { 
                
                f2.ShowDialog();
            }
            else
            {
                f2.Show();
            }
        }

        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModal.Checked) 
            {
                chkModal.Tag = chkModal.ForeColor;
                chkModal.ForeColor = Color.Red;
            }
            else
            {
                chkModal.ForeColor = (Color)chkModal.Tag;
            }
            
        }

        private void timerTitulo_Tick(object sender, EventArgs e)
        {
            if (seg > 60)
            {
                seg = 0;
                min += 1;
            }
            this.Text = $"Visor de imágenes - {min:d2}:{seg:d2}";
            seg++;
        }
    }
}
