using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            String texto = txt1.Text;
            if (!lb1.Items.Contains(texto))
            {
                lb1.Items.Add(texto);
            }
            txt1.Text = "";
            
        }

        private void añadirEnter(object sender, EventArgs e)
        {
            
        }
    }
}
