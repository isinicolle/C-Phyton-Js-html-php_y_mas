namespace Examen_reposicion
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
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_genero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_identidad = new System.Windows.Forms.TextBox();
            this.dateTimePicker_edad = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_elegir = new System.Windows.Forms.GroupBox();
            this.radioButton_estudiante = new System.Windows.Forms.RadioButton();
            this.radioButton_docente = new System.Windows.Forms.RadioButton();
            this.groupBox_elegir.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(158, 25);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(158, 60);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellido.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genero:";
            // 
            // textBox_genero
            // 
            this.textBox_genero.Location = new System.Drawing.Point(158, 102);
            this.textBox_genero.Name = "textBox_genero";
            this.textBox_genero.Size = new System.Drawing.Size(100, 20);
            this.textBox_genero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Identidad:";
            // 
            // textBox_identidad
            // 
            this.textBox_identidad.Location = new System.Drawing.Point(158, 141);
            this.textBox_identidad.Name = "textBox_identidad";
            this.textBox_identidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_identidad.TabIndex = 6;
            // 
            // dateTimePicker_edad
            // 
            this.dateTimePicker_edad.Location = new System.Drawing.Point(85, 188);
            this.dateTimePicker_edad.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_edad.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_edad.Name = "dateTimePicker_edad";
            this.dateTimePicker_edad.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_edad.TabIndex = 8;
            this.dateTimePicker_edad.ValueChanged += new System.EventHandler(this.dateTimePicker_edad_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Siguiente:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_elegir
            // 
            this.groupBox_elegir.Controls.Add(this.radioButton_estudiante);
            this.groupBox_elegir.Controls.Add(this.radioButton_docente);
            this.groupBox_elegir.Location = new System.Drawing.Point(284, 57);
            this.groupBox_elegir.Name = "groupBox_elegir";
            this.groupBox_elegir.Size = new System.Drawing.Size(104, 104);
            this.groupBox_elegir.TabIndex = 10;
            this.groupBox_elegir.TabStop = false;
            this.groupBox_elegir.Text = "Elegir";
            // 
            // radioButton_estudiante
            // 
            this.radioButton_estudiante.AutoSize = true;
            this.radioButton_estudiante.Location = new System.Drawing.Point(19, 63);
            this.radioButton_estudiante.Name = "radioButton_estudiante";
            this.radioButton_estudiante.Size = new System.Drawing.Size(75, 17);
            this.radioButton_estudiante.TabIndex = 1;
            this.radioButton_estudiante.TabStop = true;
            this.radioButton_estudiante.Text = "Estudiante";
            this.radioButton_estudiante.UseVisualStyleBackColor = true;
            // 
            // radioButton_docente
            // 
            this.radioButton_docente.AutoSize = true;
            this.radioButton_docente.Location = new System.Drawing.Point(19, 20);
            this.radioButton_docente.Name = "radioButton_docente";
            this.radioButton_docente.Size = new System.Drawing.Size(66, 17);
            this.radioButton_docente.TabIndex = 0;
            this.radioButton_docente.TabStop = true;
            this.radioButton_docente.Text = "Docente";
            this.radioButton_docente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 259);
            this.Controls.Add(this.groupBox_elegir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker_edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_identidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_genero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_elegir.ResumeLayout(false);
            this.groupBox_elegir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_genero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_identidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker_edad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox_elegir;
        private System.Windows.Forms.RadioButton radioButton_estudiante;
        private System.Windows.Forms.RadioButton radioButton_docente;
    }
}

