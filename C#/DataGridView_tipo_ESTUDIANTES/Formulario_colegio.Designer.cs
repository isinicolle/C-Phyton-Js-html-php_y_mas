namespace DataGridView_tipo_ESTUDIANTES
{
    partial class Formulario_colegio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.dgv_colegio = new System.Windows.Forms.DataGridView();
            this.TipoEstudiante = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxCUENTA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxnOMBRE = new System.Windows.Forms.TextBox();
            this.labelestadoAsignatura = new System.Windows.Forms.Label();
            this.labelpromedio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxN4 = new System.Windows.Forms.TextBox();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colegio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.buttonCalcular);
            this.groupBox1.Location = new System.Drawing.Point(619, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 137);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(38, 98);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(38, 57);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(38, 19);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 0;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // dgv_colegio
            // 
            this.dgv_colegio.AllowUserToAddRows = false;
            this.dgv_colegio.AllowUserToDeleteRows = false;
            this.dgv_colegio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_colegio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Nombre,
            this.N1,
            this.N2,
            this.N3,
            this.n4,
            this.prom,
            this.estado});
            this.dgv_colegio.Location = new System.Drawing.Point(97, 228);
            this.dgv_colegio.Name = "dgv_colegio";
            this.dgv_colegio.ReadOnly = true;
            this.dgv_colegio.Size = new System.Drawing.Size(604, 220);
            this.dgv_colegio.TabIndex = 28;
            // 
            // TipoEstudiante
            // 
            this.TipoEstudiante.AutoSize = true;
            this.TipoEstudiante.Location = new System.Drawing.Point(306, 9);
            this.TipoEstudiante.Name = "TipoEstudiante";
            this.TipoEstudiante.Size = new System.Drawing.Size(35, 13);
            this.TipoEstudiante.TabIndex = 27;
            this.TipoEstudiante.Text = "label4";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(260, 53);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 13);
            this.label.TabIndex = 26;
            this.label.Text = "CUENTA:";
            // 
            // textBoxCUENTA
            // 
            this.textBoxCUENTA.Location = new System.Drawing.Point(260, 72);
            this.textBoxCUENTA.Name = "textBoxCUENTA";
            this.textBoxCUENTA.Size = new System.Drawing.Size(100, 20);
            this.textBoxCUENTA.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "NOMBRE:";
            // 
            // textBoxnOMBRE
            // 
            this.textBoxnOMBRE.Location = new System.Drawing.Point(87, 72);
            this.textBoxnOMBRE.Name = "textBoxnOMBRE";
            this.textBoxnOMBRE.Size = new System.Drawing.Size(100, 20);
            this.textBoxnOMBRE.TabIndex = 23;
            // 
            // labelestadoAsignatura
            // 
            this.labelestadoAsignatura.AutoSize = true;
            this.labelestadoAsignatura.Location = new System.Drawing.Point(316, 174);
            this.labelestadoAsignatura.Name = "labelestadoAsignatura";
            this.labelestadoAsignatura.Size = new System.Drawing.Size(35, 13);
            this.labelestadoAsignatura.TabIndex = 22;
            this.labelestadoAsignatura.Text = "label5";
            // 
            // labelpromedio
            // 
            this.labelpromedio.AutoSize = true;
            this.labelpromedio.Location = new System.Drawing.Point(85, 174);
            this.labelpromedio.Name = "labelpromedio";
            this.labelpromedio.Size = new System.Drawing.Size(35, 13);
            this.labelpromedio.TabIndex = 21;
            this.labelpromedio.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nota 3:";
            // 
            // textBoxN3
            // 
            this.textBoxN3.Location = new System.Drawing.Point(337, 129);
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.Size = new System.Drawing.Size(100, 20);
            this.textBoxN3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nota 2:";
            // 
            // textBoxN2
            // 
            this.textBoxN2.Location = new System.Drawing.Point(186, 129);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 20);
            this.textBoxN2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nota 1:";
            // 
            // textBoxN1
            // 
            this.textBoxN1.Location = new System.Drawing.Point(27, 129);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 20);
            this.textBoxN1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nota 4:";
            // 
            // textBoxN4
            // 
            this.textBoxN4.Location = new System.Drawing.Point(481, 129);
            this.textBoxN4.Name = "textBoxN4";
            this.textBoxN4.Size = new System.Drawing.Size(100, 20);
            this.textBoxN4.TabIndex = 30;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "No. Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // N1
            // 
            this.N1.HeaderText = "Nota 1";
            this.N1.Name = "N1";
            this.N1.ReadOnly = true;
            // 
            // N2
            // 
            this.N2.HeaderText = "Nota 2";
            this.N2.Name = "N2";
            this.N2.ReadOnly = true;
            // 
            // N3
            // 
            this.N3.HeaderText = "Nota 3";
            this.N3.Name = "N3";
            this.N3.ReadOnly = true;
            // 
            // n4
            // 
            this.n4.HeaderText = "Nota 4";
            this.n4.Name = "n4";
            this.n4.ReadOnly = true;
            // 
            // prom
            // 
            this.prom.HeaderText = "Promedio";
            this.prom.Name = "prom";
            this.prom.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Formulario_colegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxN4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_colegio);
            this.Controls.Add(this.TipoEstudiante);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxCUENTA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnOMBRE);
            this.Controls.Add(this.labelestadoAsignatura);
            this.Controls.Add(this.labelpromedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxN3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxN1);
            this.Name = "Formulario_colegio";
            this.Text = "Formulario_colegio";
            this.Load += new System.EventHandler(this.Formulario_colegio_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colegio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.DataGridView dgv_colegio;
        private System.Windows.Forms.Label TipoEstudiante;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxCUENTA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxnOMBRE;
        private System.Windows.Forms.Label labelestadoAsignatura;
        private System.Windows.Forms.Label labelpromedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxN4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N3;
        private System.Windows.Forms.DataGridViewTextBoxColumn n4;
        private System.Windows.Forms.DataGridViewTextBoxColumn prom;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}