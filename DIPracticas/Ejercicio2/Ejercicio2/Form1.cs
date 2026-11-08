namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Seguro que quieres salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo;
            int verde;
            int azul;
            bool valido = true;
            if (!int.TryParse(TxtRojo.Text,out rojo)|| rojo < 0 || rojo > 255)
            {
                valido = false;
            }
            if (!int.TryParse(TxtVerde.Text, out verde) || verde < 0 || verde > 255)
            {
                valido = false;
            }
            if (!int.TryParse(TxtAzul.Text, out azul) || azul < 0 || azul > 255)
            {
                valido = false;
            }
            if (valido)
            {
              this.BackColor = Color.FromArgb(rojo,verde,azul);
            }
            else
            {
                MessageBox.Show("Los valores no son validos debe de estar entre 0 y 255");
            }


        }
    }
}
