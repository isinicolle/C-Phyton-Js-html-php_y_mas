namespace Examen_reposicion
{
    partial class Formulario_estudiantes
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_identidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_genero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_edad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_prom = new System.Windows.Forms.TextBox();
            this.textBox_n3 = new System.Windows.Forms.TextBox();
            this.textBox_n2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_n1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_estudiantes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_estudiante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Identidad:";
            // 
            // textBox_identidad
            // 
            this.textBox_identidad.Location = new System.Drawing.Point(88, 150);
            this.textBox_identidad.Name = "textBox_identidad";
            this.textBox_identidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_identidad.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Genero:";
            // 
            // textBox_genero
            // 
            this.textBox_genero.Location = new System.Drawing.Point(88, 111);
            this.textBox_genero.Name = "textBox_genero";
            this.textBox_genero.Size = new System.Drawing.Size(100, 20);
            this.textBox_genero.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido:";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(88, 69);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellido.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(88, 34);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 8;
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Location = new System.Drawing.Point(28, 184);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(71, 13);
            this.label_edad.TabIndex = 16;
            this.label_edad.Text = "label de edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Promedio:";
            // 
            // textBox_prom
            // 
            this.textBox_prom.Enabled = false;
            this.textBox_prom.Location = new System.Drawing.Point(353, 153);
            this.textBox_prom.Name = "textBox_prom";
            this.textBox_prom.Size = new System.Drawing.Size(100, 20);
            this.textBox_prom.TabIndex = 23;
            // 
            // textBox_n3
            // 
            this.textBox_n3.Location = new System.Drawing.Point(353, 114);
            this.textBox_n3.Name = "textBox_n3";
            this.textBox_n3.Size = new System.Drawing.Size(100, 20);
            this.textBox_n3.TabIndex = 21;
            // 
            // textBox_n2
            // 
            this.textBox_n2.Location = new System.Drawing.Point(353, 72);
            this.textBox_n2.Name = "textBox_n2";
            this.textBox_n2.Size = new System.Drawing.Size(100, 20);
            this.textBox_n2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nota 1:";
            // 
            // textBox_n1
            // 
            this.textBox_n1.Location = new System.Drawing.Point(353, 37);
            this.textBox_n1.Name = "textBox_n1";
            this.textBox_n1.Size = new System.Drawing.Size(100, 20);
            this.textBox_n1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nota 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nota 3:";
            // 
            // dgv_estudiantes
            // 
            this.dgv_estudiantes.AllowUserToAddRows = false;
            this.dgv_estudiantes.AllowUserToDeleteRows = false;
            this.dgv_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GEN,
            this.Nombre,
            this.Apellido,
            this.Nota1,
            this.N2,
            this.N3,
            this.Prom});
            this.dgv_estudiantes.Location = new System.Drawing.Point(31, 249);
            this.dgv_estudiantes.Name = "dgv_estudiantes";
            this.dgv_estudiantes.ReadOnly = true;
            this.dgv_estudiantes.RowHeadersVisible = false;
            this.dgv_estudiantes.Size = new System.Drawing.Size(521, 227);
            this.dgv_estudiantes.TabIndex = 27;
            this.dgv_estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estudiantes_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Identidad";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // GEN
            // 
            this.GEN.HeaderText = "Genero";
            this.GEN.Name = "GEN";
            this.GEN.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nota1
            // 
            this.Nota1.HeaderText = "Nota I";
            this.Nota1.Name = "Nota1";
            this.Nota1.ReadOnly = true;
            // 
            // N2
            // 
            this.N2.HeaderText = "Nota II";
            this.N2.Name = "N2";
            this.N2.ReadOnly = true;
            // 
            // N3
            // 
            this.N3.HeaderText = "Nota III";
            this.N3.Name = "N3";
            this.N3.ReadOnly = true;
            // 
            // Prom
            // 
            this.Prom.HeaderText = "Promedio";
            this.Prom.Name = "Prom";
            this.Prom.ReadOnly = true;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(88, 209);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 23);
            this.button_calcular.TabIndex = 29;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(279, 209);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 30;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 32;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_estudiante
            // 
            this.label_estudiante.AutoSize = true;
            this.label_estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estudiante.Location = new System.Drawing.Point(227, 4);
            this.label_estudiante.Name = "label_estudiante";
            this.label_estudiante.Size = new System.Drawing.Size(52, 18);
            this.label_estudiante.TabIndex = 33;
            this.label_estudiante.Text = "label9";
            // 
            // Formulario_estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 506);
            this.Controls.Add(this.label_estudiante);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_estudiantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_prom);
            this.Controls.Add(this.textBox_n3);
            this.Controls.Add(this.textBox_n2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_n1);
            this.Controls.Add(this.label_edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_identidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_genero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Name = "Formulario_estudiantes";
            this.Text = "Formulario_estudiantes";
            this.Load += new System.EventHandler(this.Formulario_estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_identidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_genero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_prom;
        private System.Windows.Forms.TextBox textBox_n3;
        private System.Windows.Forms.TextBox textBox_n2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_n1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_estudiantes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prom;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_estudiante;
    }
}