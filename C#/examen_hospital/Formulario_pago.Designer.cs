namespace examen_hospital
{
    partial class Formulario_pago
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
            this.groupBox_sm = new System.Windows.Forms.GroupBox();
            this.sinseguro = new System.Windows.Forms.RadioButton();
            this.PALIC = new System.Windows.Forms.RadioButton();
            this.MAPFRE = new System.Windows.Forms.RadioButton();
            this.atlantida = new System.Windows.Forms.RadioButton();
            this.groupBox_pago = new System.Windows.Forms.GroupBox();
            this.Tarjeta = new System.Windows.Forms.RadioButton();
            this.Efectivo = new System.Windows.Forms.RadioButton();
            this.boton_facturar = new System.Windows.Forms.Button();
            this.groupBox_sm.SuspendLayout();
            this.groupBox_pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_sm
            // 
            this.groupBox_sm.Controls.Add(this.sinseguro);
            this.groupBox_sm.Controls.Add(this.PALIC);
            this.groupBox_sm.Controls.Add(this.MAPFRE);
            this.groupBox_sm.Controls.Add(this.atlantida);
            this.groupBox_sm.Location = new System.Drawing.Point(33, 25);
            this.groupBox_sm.Name = "groupBox_sm";
            this.groupBox_sm.Size = new System.Drawing.Size(122, 115);
            this.groupBox_sm.TabIndex = 11;
            this.groupBox_sm.TabStop = false;
            this.groupBox_sm.Text = "Seguro Medico:";
//            this.groupBox_sm.Enter += new System.EventHandler(this.groupBox_sm_Enter);
            // 
            // sinseguro
            // 
            this.sinseguro.AutoSize = true;
            this.sinseguro.Location = new System.Drawing.Point(17, 92);
            this.sinseguro.Name = "sinseguro";
            this.sinseguro.Size = new System.Drawing.Size(75, 17);
            this.sinseguro.TabIndex = 3;
            this.sinseguro.TabStop = true;
            this.sinseguro.Text = "Sin seguro";
            this.sinseguro.UseVisualStyleBackColor = true;
            // 
            // PALIC
            // 
            this.PALIC.AutoSize = true;
            this.PALIC.Location = new System.Drawing.Point(16, 71);
            this.PALIC.Name = "PALIC";
            this.PALIC.Size = new System.Drawing.Size(55, 17);
            this.PALIC.TabIndex = 2;
            this.PALIC.TabStop = true;
            this.PALIC.Text = "PALIC";
            this.PALIC.UseVisualStyleBackColor = true;
            // 
            // MAPFRE
            // 
            this.MAPFRE.AutoSize = true;
            this.MAPFRE.Location = new System.Drawing.Point(17, 48);
            this.MAPFRE.Name = "MAPFRE";
            this.MAPFRE.Size = new System.Drawing.Size(69, 17);
            this.MAPFRE.TabIndex = 1;
            this.MAPFRE.TabStop = true;
            this.MAPFRE.Text = "MAPFRE";
            this.MAPFRE.UseVisualStyleBackColor = true;
            // 
            // atlantida
            // 
            this.atlantida.AutoSize = true;
            this.atlantida.Location = new System.Drawing.Point(17, 25);
            this.atlantida.Name = "atlantida";
            this.atlantida.Size = new System.Drawing.Size(66, 17);
            this.atlantida.TabIndex = 0;
            this.atlantida.TabStop = true;
            this.atlantida.Text = "Atlantida";
            this.atlantida.UseVisualStyleBackColor = true;
            // 
            // groupBox_pago
            // 
            this.groupBox_pago.Controls.Add(this.Tarjeta);
            this.groupBox_pago.Controls.Add(this.Efectivo);
            this.groupBox_pago.Location = new System.Drawing.Point(214, 25);
            this.groupBox_pago.Name = "groupBox_pago";
            this.groupBox_pago.Size = new System.Drawing.Size(140, 115);
            this.groupBox_pago.TabIndex = 11;
            this.groupBox_pago.TabStop = false;
            this.groupBox_pago.Text = "Pago:";
            // 
            // Tarjeta
            // 
            this.Tarjeta.AutoSize = true;
            this.Tarjeta.Location = new System.Drawing.Point(17, 62);
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Size = new System.Drawing.Size(108, 17);
            this.Tarjeta.TabIndex = 1;
            this.Tarjeta.TabStop = true;
            this.Tarjeta.Text = "Tarjeta de credito";
            this.Tarjeta.UseVisualStyleBackColor = true;
            // 
            // Efectivo
            // 
            this.Efectivo.AutoSize = true;
            this.Efectivo.Location = new System.Drawing.Point(17, 25);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Size = new System.Drawing.Size(64, 17);
            this.Efectivo.TabIndex = 0;
            this.Efectivo.TabStop = true;
            this.Efectivo.Text = "Efectivo";
            this.Efectivo.UseVisualStyleBackColor = true;
            // 
            // boton_facturar
            // 
            this.boton_facturar.Location = new System.Drawing.Point(264, 146);
            this.boton_facturar.Name = "boton_facturar";
            this.boton_facturar.Size = new System.Drawing.Size(75, 23);
            this.boton_facturar.TabIndex = 12;
            this.boton_facturar.Text = "Facturar";
            this.boton_facturar.UseVisualStyleBackColor = true;
            this.boton_facturar.Click += new System.EventHandler(this.boton_facturar_Click);
            // 
            // Formulario_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 180);
            this.Controls.Add(this.boton_facturar);
            this.Controls.Add(this.groupBox_pago);
            this.Controls.Add(this.groupBox_sm);
            this.Name = "Formulario_pago";
            this.Text = "Formulario_pago";
            this.Load += new System.EventHandler(this.Formulario_pago_Load);
            this.groupBox_sm.ResumeLayout(false);
            this.groupBox_sm.PerformLayout();
            this.groupBox_pago.ResumeLayout(false);
            this.groupBox_pago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_sm;
        private System.Windows.Forms.RadioButton PALIC;
        private System.Windows.Forms.RadioButton MAPFRE;
        private System.Windows.Forms.RadioButton atlantida;
        private System.Windows.Forms.GroupBox groupBox_pago;
        private System.Windows.Forms.RadioButton Tarjeta;
        private System.Windows.Forms.RadioButton Efectivo;
        private System.Windows.Forms.RadioButton sinseguro;
        private System.Windows.Forms.Button boton_facturar;
    }
}