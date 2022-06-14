namespace DataGridView_tipo_ESTUDIANTES
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
            this.ButtonUniversitarios = new System.Windows.Forms.Button();
            this.ButtonColegio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonUniversitarios
            // 
            this.ButtonUniversitarios.Location = new System.Drawing.Point(43, 24);
            this.ButtonUniversitarios.Name = "ButtonUniversitarios";
            this.ButtonUniversitarios.Size = new System.Drawing.Size(102, 46);
            this.ButtonUniversitarios.TabIndex = 0;
            this.ButtonUniversitarios.Text = "Universitarios";
            this.ButtonUniversitarios.UseVisualStyleBackColor = true;
            this.ButtonUniversitarios.Click += new System.EventHandler(this.ButtonUniversitarios_Click);
            // 
            // ButtonColegio
            // 
            this.ButtonColegio.Location = new System.Drawing.Point(43, 97);
            this.ButtonColegio.Name = "ButtonColegio";
            this.ButtonColegio.Size = new System.Drawing.Size(102, 46);
            this.ButtonColegio.TabIndex = 1;
            this.ButtonColegio.Text = "Colegio";
            this.ButtonColegio.UseVisualStyleBackColor = true;
            this.ButtonColegio.Click += new System.EventHandler(this.ButtonColegio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 173);
            this.Controls.Add(this.ButtonColegio);
            this.Controls.Add(this.ButtonUniversitarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonUniversitarios;
        private System.Windows.Forms.Button ButtonColegio;
    }
}

