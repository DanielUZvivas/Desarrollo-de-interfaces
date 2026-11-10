namespace Ejercicio44
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnTraspasar = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblNelements = new System.Windows.Forms.Label();
            this.lblIndicesSelected = new System.Windows.Forms.Label();
            this.rbLista1 = new System.Windows.Forms.RadioButton();
            this.rbLista2 = new System.Windows.Forms.RadioButton();
            this.rbTraspaso1 = new System.Windows.Forms.RadioButton();
            this.rbTraspaso2 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Eliminar = new System.Windows.Forms.GroupBox();
            this.Traspasar = new System.Windows.Forms.GroupBox();
            this.Eliminar.SuspendLayout();
            this.Traspasar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(36, 31);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb1.Size = new System.Drawing.Size(186, 82);
            this.lb1.TabIndex = 0;
            this.lb1.SelectedIndexChanged += new System.EventHandler(this.lb1_SelectedIndexChanged);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(36, 125);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(186, 82);
            this.lb2.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(240, 31);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.toolTip1.SetToolTip(this.btnAceptar, "Boton para añadir el texto en la lista");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(321, 31);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(105, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar de lista 1";
            this.toolTip1.SetToolTip(this.btnBorrar, "Boton para borrar los elementos seleccionados");
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnTraspasar
            // 
            this.btnTraspasar.Location = new System.Drawing.Point(430, 31);
            this.btnTraspasar.Name = "btnTraspasar";
            this.btnTraspasar.Size = new System.Drawing.Size(143, 23);
            this.btnTraspasar.TabIndex = 4;
            this.btnTraspasar.Text = "Traspasar de lista 1 a la 2";
            this.toolTip1.SetToolTip(this.btnTraspasar, "Boton para traspasar los seleccioandos de una lista a otra");
            this.btnTraspasar.UseVisualStyleBackColor = true;
            this.btnTraspasar.Click += new System.EventHandler(this.btnTraspasar_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(240, 60);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(333, 20);
            this.txtFrase.TabIndex = 5;
            // 
            // lblNelements
            // 
            this.lblNelements.AutoSize = true;
            this.lblNelements.Location = new System.Drawing.Point(237, 89);
            this.lblNelements.Name = "lblNelements";
            this.lblNelements.Size = new System.Drawing.Size(35, 13);
            this.lblNelements.TabIndex = 6;
            this.lblNelements.Text = "label1";
            // 
            // lblIndicesSelected
            // 
            this.lblIndicesSelected.AutoSize = true;
            this.lblIndicesSelected.Location = new System.Drawing.Point(237, 109);
            this.lblIndicesSelected.Name = "lblIndicesSelected";
            this.lblIndicesSelected.Size = new System.Drawing.Size(35, 13);
            this.lblIndicesSelected.TabIndex = 7;
            this.lblIndicesSelected.Text = "label2";
            // 
            // rbLista1
            // 
            this.rbLista1.AutoSize = true;
            this.rbLista1.Checked = true;
            this.rbLista1.Location = new System.Drawing.Point(0, 24);
            this.rbLista1.Name = "rbLista1";
            this.rbLista1.Size = new System.Drawing.Size(186, 17);
            this.rbLista1.TabIndex = 8;
            this.rbLista1.TabStop = true;
            this.rbLista1.Text = "Borrar Seleccionados en la Lista 1";
            this.rbLista1.UseVisualStyleBackColor = true;
            this.rbLista1.CheckedChanged += new System.EventHandler(this.rbLista1_CheckedChanged);
            // 
            // rbLista2
            // 
            this.rbLista2.AutoSize = true;
            this.rbLista2.Location = new System.Drawing.Point(0, 47);
            this.rbLista2.Name = "rbLista2";
            this.rbLista2.Size = new System.Drawing.Size(186, 17);
            this.rbLista2.TabIndex = 9;
            this.rbLista2.Text = "Borrar Seleccionados en la Lista 2";
            this.rbLista2.UseVisualStyleBackColor = true;
            this.rbLista2.CheckedChanged += new System.EventHandler(this.rbLista1_CheckedChanged);
            // 
            // rbTraspaso1
            // 
            this.rbTraspaso1.AutoSize = true;
            this.rbTraspaso1.Checked = true;
            this.rbTraspaso1.Location = new System.Drawing.Point(0, 19);
            this.rbTraspaso1.Name = "rbTraspaso1";
            this.rbTraspaso1.Size = new System.Drawing.Size(217, 17);
            this.rbTraspaso1.TabIndex = 10;
            this.rbTraspaso1.TabStop = true;
            this.rbTraspaso1.Text = "Traspasar Seleccionado Lista 1 a Lista 2";
            this.rbTraspaso1.UseVisualStyleBackColor = true;
            this.rbTraspaso1.CheckedChanged += new System.EventHandler(this.rbTraspaso1_CheckedChanged);
            // 
            // rbTraspaso2
            // 
            this.rbTraspaso2.AutoSize = true;
            this.rbTraspaso2.Location = new System.Drawing.Point(0, 42);
            this.rbTraspaso2.Name = "rbTraspaso2";
            this.rbTraspaso2.Size = new System.Drawing.Size(213, 17);
            this.rbTraspaso2.TabIndex = 11;
            this.rbTraspaso2.Text = "Traspasar Seleccionado Lista 2 a lista 1";
            this.rbTraspaso2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.rbLista1);
            this.Eliminar.Controls.Add(this.rbLista2);
            this.Eliminar.Location = new System.Drawing.Point(240, 125);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(200, 100);
            this.Eliminar.TabIndex = 12;
            this.Eliminar.TabStop = false;
            this.Eliminar.Text = "Eliminar";
            // 
            // Traspasar
            // 
            this.Traspasar.Controls.Add(this.rbTraspaso1);
            this.Traspasar.Controls.Add(this.rbTraspaso2);
            this.Traspasar.Location = new System.Drawing.Point(460, 125);
            this.Traspasar.Name = "Traspasar";
            this.Traspasar.Size = new System.Drawing.Size(240, 100);
            this.Traspasar.TabIndex = 13;
            this.Traspasar.TabStop = false;
            this.Traspasar.Text = "Traspasr";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Traspasar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.lblIndicesSelected);
            this.Controls.Add(this.lblNelements);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.btnTraspasar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            this.Traspasar.ResumeLayout(false);
            this.Traspasar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnTraspasar;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblNelements;
        private System.Windows.Forms.Label lblIndicesSelected;
        private System.Windows.Forms.RadioButton rbLista1;
        private System.Windows.Forms.RadioButton rbLista2;
        private System.Windows.Forms.RadioButton rbTraspaso1;
        private System.Windows.Forms.RadioButton rbTraspaso2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox Eliminar;
        private System.Windows.Forms.GroupBox Traspasar;
    }
}

