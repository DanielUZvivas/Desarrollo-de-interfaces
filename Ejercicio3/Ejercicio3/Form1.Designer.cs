namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNewImg = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chkModal = new System.Windows.Forms.CheckBox();
            this.timerTitulo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnNewImg
            // 
            this.btnNewImg.Location = new System.Drawing.Point(13, 13);
            this.btnNewImg.Name = "btnNewImg";
            this.btnNewImg.Size = new System.Drawing.Size(94, 23);
            this.btnNewImg.TabIndex = 0;
            this.btnNewImg.Text = "Nueva Imagen";
            this.btnNewImg.UseVisualStyleBackColor = true;
            this.btnNewImg.Click += new System.EventHandler(this.btnNewImg_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            this.fileDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Todos los archivos (*.*)|*.*";
            // 
            // chkModal
            // 
            this.chkModal.AutoSize = true;
            this.chkModal.Location = new System.Drawing.Point(13, 43);
            this.chkModal.Name = "chkModal";
            this.chkModal.Size = new System.Drawing.Size(55, 17);
            this.chkModal.TabIndex = 1;
            this.chkModal.Text = "Modal";
            this.chkModal.UseVisualStyleBackColor = true;
            this.chkModal.CheckedChanged += new System.EventHandler(this.chkModal_CheckedChanged);
            // 
            // timerTitulo
            // 
            this.timerTitulo.Enabled = true;
            this.timerTitulo.Interval = 1000;
            this.timerTitulo.Tick += new System.EventHandler(this.timerTitulo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkModal);
            this.Controls.Add(this.btnNewImg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewImg;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.CheckBox chkModal;
        private System.Windows.Forms.Timer timerTitulo;
    }
}

