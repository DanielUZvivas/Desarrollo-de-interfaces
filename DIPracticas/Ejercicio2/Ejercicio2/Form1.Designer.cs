namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnSalir = new Button();
            TxtRojo = new TextBox();
            TxtVerde = new TextBox();
            TxtAzul = new TextBox();
            btnColor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(701, 390);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(87, 48);
            BtnSalir.TabIndex = 0;
            BtnSalir.Text = "salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // TxtRojo
            // 
            TxtRojo.Location = new Point(27, 30);
            TxtRojo.Name = "TxtRojo";
            TxtRojo.Size = new Size(100, 23);
            TxtRojo.TabIndex = 1;
            // 
            // TxtVerde
            // 
            TxtVerde.Location = new Point(159, 30);
            TxtVerde.Name = "TxtVerde";
            TxtVerde.Size = new Size(100, 23);
            TxtVerde.TabIndex = 2;
            // 
            // TxtAzul
            // 
            TxtAzul.Location = new Point(292, 30);
            TxtAzul.Name = "TxtAzul";
            TxtAzul.Size = new Size(100, 23);
            TxtAzul.TabIndex = 3;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(436, 19);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(103, 42);
            btnColor.TabIndex = 4;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Rojo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 9);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Verde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 9);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Azul";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnSalir;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnColor);
            Controls.Add(TxtAzul);
            Controls.Add(TxtVerde);
            Controls.Add(TxtRojo);
            Controls.Add(BtnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalir;
        private TextBox TxtRojo;
        private TextBox TxtVerde;
        private TextBox TxtAzul;
        private Button btnColor;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
