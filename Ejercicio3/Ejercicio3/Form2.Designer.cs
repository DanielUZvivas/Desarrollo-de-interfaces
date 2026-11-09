namespace Ejercicio3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seDeformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noSeDeformaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImagen
            // 
            this.picImagen.ContextMenuStrip = this.contextMenuStrip1;
            this.picImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagen.Location = new System.Drawing.Point(0, 0);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(800, 450);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeformaToolStripMenuItem,
            this.noSeDeformaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // seDeformaToolStripMenuItem
            // 
            this.seDeformaToolStripMenuItem.Name = "seDeformaToolStripMenuItem";
            this.seDeformaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.seDeformaToolStripMenuItem.Text = "Se deforma";
            this.seDeformaToolStripMenuItem.Click += new System.EventHandler(this.seDeformaToolStripMenuItem_Click);
            // 
            // noSeDeformaToolStripMenuItem
            // 
            this.noSeDeformaToolStripMenuItem.Name = "noSeDeformaToolStripMenuItem";
            this.noSeDeformaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noSeDeformaToolStripMenuItem.Text = "No se deforma";
            this.noSeDeformaToolStripMenuItem.Click += new System.EventHandler(this.noSeDeformaToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImagen);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seDeformaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noSeDeformaToolStripMenuItem;
    }
}