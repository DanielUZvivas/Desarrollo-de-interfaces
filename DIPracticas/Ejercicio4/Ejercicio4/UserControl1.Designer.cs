namespace Ejercicio4
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(29, 22);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb1.Size = new System.Drawing.Size(208, 82);
            this.lb1.TabIndex = 0;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(29, 124);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(208, 82);
            this.lb2.TabIndex = 1;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(243, 22);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(324, 22);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(405, 22);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(75, 23);
            this.btnTraspasar.TabIndex = 4;
            this.btnTraspasar.Text = "Traspasar";
            this.btnTraspasar.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(244, 52);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(236, 20);
            this.txt1.TabIndex = 5;
            this.txt1.Enter += new System.EventHandler(this.añadirEnter);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnTraspasar;
        private System.Windows.Forms.TextBox txt1;
    }
}
