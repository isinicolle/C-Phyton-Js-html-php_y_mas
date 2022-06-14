namespace examen_hospital
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ape = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_persona = new System.Windows.Forms.GroupBox();
            this.radioButton_paciente = new System.Windows.Forms.RadioButton();
            this.radioButton_medico = new System.Windows.Forms.RadioButton();
            this.groupBox_consulta = new System.Windows.Forms.GroupBox();
            this.geriatria = new System.Windows.Forms.RadioButton();
            this.pediatria = new System.Windows.Forms.RadioButton();
            this.general = new System.Windows.Forms.RadioButton();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.groupBox_persona.SuspendLayout();
            this.groupBox_consulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identidad";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(78, 34);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(78, 70);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // textBox_ape
            // 
            this.textBox_ape.Location = new System.Drawing.Point(78, 114);
            this.textBox_ape.Name = "textBox_ape";
            this.textBox_ape.Size = new System.Drawing.Size(100, 20);
            this.textBox_ape.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido:";
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(78, 159);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(100, 20);
            this.textBox_tel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 199);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox_persona
            // 
            this.groupBox_persona.Controls.Add(this.radioButton_paciente);
            this.groupBox_persona.Controls.Add(this.radioButton_medico);
            this.groupBox_persona.Location = new System.Drawing.Point(240, 30);
            this.groupBox_persona.Name = "groupBox_persona";
            this.groupBox_persona.Size = new System.Drawing.Size(122, 115);
            this.groupBox_persona.TabIndex = 9;
            this.groupBox_persona.TabStop = false;
            this.groupBox_persona.Text = "Soy:";
            // 
            // radioButton_paciente
            // 
            this.radioButton_paciente.AutoSize = true;
            this.radioButton_paciente.Location = new System.Drawing.Point(17, 83);
            this.radioButton_paciente.Name = "radioButton_paciente";
            this.radioButton_paciente.Size = new System.Drawing.Size(67, 17);
            this.radioButton_paciente.TabIndex = 1;
            this.radioButton_paciente.TabStop = true;
            this.radioButton_paciente.Text = "Paciente";
            this.radioButton_paciente.UseVisualStyleBackColor = true;
            this.radioButton_paciente.CheckedChanged += new System.EventHandler(this.radioButton_paciente_CheckedChanged);
            // 
            // radioButton_medico
            // 
            this.radioButton_medico.AutoSize = true;
            this.radioButton_medico.Location = new System.Drawing.Point(17, 39);
            this.radioButton_medico.Name = "radioButton_medico";
            this.radioButton_medico.Size = new System.Drawing.Size(60, 17);
            this.radioButton_medico.TabIndex = 0;
            this.radioButton_medico.TabStop = true;
            this.radioButton_medico.Text = "Medico";
            this.radioButton_medico.UseVisualStyleBackColor = true;
            this.radioButton_medico.CheckedChanged += new System.EventHandler(this.radioButton_medico_CheckedChanged);
            // 
            // groupBox_consulta
            // 
            this.groupBox_consulta.Controls.Add(this.geriatria);
            this.groupBox_consulta.Controls.Add(this.pediatria);
            this.groupBox_consulta.Controls.Add(this.general);
            this.groupBox_consulta.Location = new System.Drawing.Point(240, 178);
            this.groupBox_consulta.Name = "groupBox_consulta";
            this.groupBox_consulta.Size = new System.Drawing.Size(122, 115);
            this.groupBox_consulta.TabIndex = 10;
            this.groupBox_consulta.TabStop = false;
            this.groupBox_consulta.Text = "Consulta:";
            // 
            // geriatria
            // 
            this.geriatria.AutoSize = true;
            this.geriatria.Location = new System.Drawing.Point(16, 71);
            this.geriatria.Name = "geriatria";
            this.geriatria.Size = new System.Drawing.Size(98, 17);
            this.geriatria.TabIndex = 2;
            this.geriatria.TabStop = true;
            this.geriatria.Text = "Geriatria 800lps";
            this.geriatria.UseVisualStyleBackColor = true;
            // 
            // pediatria
            // 
            this.pediatria.AutoSize = true;
            this.pediatria.Location = new System.Drawing.Point(17, 48);
            this.pediatria.Name = "pediatria";
            this.pediatria.Size = new System.Drawing.Size(100, 17);
            this.pediatria.TabIndex = 1;
            this.pediatria.TabStop = true;
            this.pediatria.Text = "Pediatria 650lps";
            this.pediatria.UseVisualStyleBackColor = true;
            // 
            // general
            // 
            this.general.AutoSize = true;
            this.general.Location = new System.Drawing.Point(17, 25);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(96, 17);
            this.general.TabIndex = 0;
            this.general.TabStop = true;
            this.general.Text = "General 500lps";
            this.general.UseVisualStyleBackColor = true;
            // 
            // button_siguiente
            // 
            this.button_siguiente.Location = new System.Drawing.Point(406, 295);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(75, 23);
            this.button_siguiente.TabIndex = 11;
            this.button_siguiente.Text = "Siguiente";
            this.button_siguiente.UseVisualStyleBackColor = true;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 332);
            this.Controls.Add(this.button_siguiente);
            this.Controls.Add(this.groupBox_consulta);
            this.Controls.Add(this.groupBox_persona);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ape);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_persona.ResumeLayout(false);
            this.groupBox_persona.PerformLayout();
            this.groupBox_consulta.ResumeLayout(false);
            this.groupBox_consulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox_persona;
        private System.Windows.Forms.RadioButton radioButton_paciente;
        private System.Windows.Forms.RadioButton radioButton_medico;
        private System.Windows.Forms.GroupBox groupBox_consulta;
        private System.Windows.Forms.RadioButton pediatria;
        private System.Windows.Forms.RadioButton general;
        private System.Windows.Forms.RadioButton geriatria;
        private System.Windows.Forms.Button button_siguiente;
    }
}

