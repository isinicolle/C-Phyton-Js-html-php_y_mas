namespace CONEXIONBD
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
            this.btn_conectasr = new System.Windows.Forms.Button();
            this.btn_descoenctar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btn_carrera = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_conectasr
            // 
            this.btn_conectasr.Location = new System.Drawing.Point(32, 164);
            this.btn_conectasr.Name = "btn_conectasr";
            this.btn_conectasr.Size = new System.Drawing.Size(101, 21);
            this.btn_conectasr.TabIndex = 0;
            this.btn_conectasr.Text = "Abrir";
            this.btn_conectasr.UseVisualStyleBackColor = true;
            this.btn_conectasr.Click += new System.EventHandler(this.btn_conectasr_Click);
            // 
            // btn_descoenctar
            // 
            this.btn_descoenctar.Location = new System.Drawing.Point(32, 234);
            this.btn_descoenctar.Name = "btn_descoenctar";
            this.btn_descoenctar.Size = new System.Drawing.Size(101, 21);
            this.btn_descoenctar.TabIndex = 1;
            this.btn_descoenctar.Text = "Cerrar";
            this.btn_descoenctar.UseVisualStyleBackColor = true;
            this.btn_descoenctar.Click += new System.EventHandler(this.btn_descoenctar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // btn_carrera
            // 
            this.btn_carrera.Location = new System.Drawing.Point(93, 35);
            this.btn_carrera.Name = "btn_carrera";
            this.btn_carrera.Size = new System.Drawing.Size(75, 23);
            this.btn_carrera.TabIndex = 3;
            this.btn_carrera.Text = "Carrera";
            this.btn_carrera.UseVisualStyleBackColor = true;
            this.btn_carrera.Click += new System.EventHandler(this.btn_carrera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 275);
            this.Controls.Add(this.btn_carrera);
            this.Controls.Add(this.btn_descoenctar);
            this.Controls.Add(this.btn_conectasr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_conectasr;
        private System.Windows.Forms.Button btn_descoenctar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button btn_carrera;
    }
}

