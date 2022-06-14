namespace Examen_reposicion
{
    partial class Formulario_Profesores
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
            this.dgb_docentes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_sueldo = new System.Windows.Forms.TextBox();
            this.textBox_pxh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_edad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_identidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_genero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.horastrabajadas = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_calcular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pxh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_docentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horastrabajadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_docentes
            // 
            this.dgb_docentes.AllowUserToAddRows = false;
            this.dgb_docentes.AllowUserToDeleteRows = false;
            this.dgb_docentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_docentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.gen,
            this.Nombre,
            this.Apellido,
            this.HorasT,
            this.pxh,
            this.sueldo});
            this.dgb_docentes.Location = new System.Drawing.Point(19, 258);
            this.dgb_docentes.Name = "dgb_docentes";
            this.dgb_docentes.ReadOnly = true;
            this.dgb_docentes.RowHeadersVisible = false;
            this.dgb_docentes.Size = new System.Drawing.Size(524, 219);
            this.dgb_docentes.TabIndex = 45;
            this.dgb_docentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgb_docentes_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Pago por hora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Sueldo:";
            // 
            // textBox_sueldo
            // 
            this.textBox_sueldo.Enabled = false;
            this.textBox_sueldo.Location = new System.Drawing.Point(341, 109);
            this.textBox_sueldo.Name = "textBox_sueldo";
            this.textBox_sueldo.Size = new System.Drawing.Size(100, 20);
            this.textBox_sueldo.TabIndex = 41;
            // 
            // textBox_pxh
            // 
            this.textBox_pxh.Location = new System.Drawing.Point(341, 70);
            this.textBox_pxh.Name = "textBox_pxh";
            this.textBox_pxh.Size = new System.Drawing.Size(100, 20);
            this.textBox_pxh.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Horas trabajadas:";
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Location = new System.Drawing.Point(16, 182);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(71, 13);
            this.label_edad.TabIndex = 36;
            this.label_edad.Text = "label de edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Identidad:";
            // 
            // textBox_identidad
            // 
            this.textBox_identidad.Location = new System.Drawing.Point(76, 148);
            this.textBox_identidad.Name = "textBox_identidad";
            this.textBox_identidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_identidad.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Genero:";
            // 
            // textBox_genero
            // 
            this.textBox_genero.Location = new System.Drawing.Point(76, 109);
            this.textBox_genero.Name = "textBox_genero";
            this.textBox_genero.Size = new System.Drawing.Size(100, 20);
            this.textBox_genero.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Apellido:";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(76, 67);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellido.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(76, 32);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 28;
            // 
            // horastrabajadas
            // 
            this.horastrabajadas.Location = new System.Drawing.Point(341, 40);
            this.horastrabajadas.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.horastrabajadas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.horastrabajadas.Name = "horastrabajadas";
            this.horastrabajadas.Size = new System.Drawing.Size(100, 20);
            this.horastrabajadas.TabIndex = 46;
            this.horastrabajadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.horastrabajadas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(275, 213);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 49;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(84, 213);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 23);
            this.button_calcular.TabIndex = 48;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "label7";
            // 
            // Id
            // 
            this.Id.HeaderText = "Identidad";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // gen
            // 
            this.gen.HeaderText = "Genero";
            this.gen.Name = "gen";
            this.gen.ReadOnly = true;
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
            // HorasT
            // 
            this.HorasT.HeaderText = "Horas Trabajadas";
            this.HorasT.Name = "HorasT";
            this.HorasT.ReadOnly = true;
            // 
            // pxh
            // 
            this.pxh.HeaderText = "Pago por hora";
            this.pxh.Name = "pxh";
            this.pxh.ReadOnly = true;
            // 
            // sueldo
            // 
            this.sueldo.HeaderText = "Sueldo";
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            // 
            // Formulario_Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 479);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horastrabajadas);
            this.Controls.Add(this.dgb_docentes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_sueldo);
            this.Controls.Add(this.textBox_pxh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_identidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_genero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.Name = "Formulario_Profesores";
            this.Text = "Formulario_Profesores";
            this.Load += new System.EventHandler(this.Formulario_Profesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_docentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horastrabajadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_docentes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_sueldo;
        private System.Windows.Forms.TextBox textBox_pxh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_identidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_genero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.NumericUpDown horastrabajadas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasT;
        private System.Windows.Forms.DataGridViewTextBoxColumn pxh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
    }
}