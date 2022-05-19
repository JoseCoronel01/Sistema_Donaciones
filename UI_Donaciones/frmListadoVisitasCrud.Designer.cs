namespace UI_Donaciones
{
    partial class frmListadoVisitasCrud
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDonador = new System.Windows.Forms.ComboBox();
            this.cbVisita = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMotivo = new TextBoxEx.CtrlTextBox();
            this.txtObservaciones = new TextBoxEx.CtrlTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Donador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Motivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Observaciones";
            // 
            // cbDonador
            // 
            this.cbDonador.DisplayMember = "text";
            this.cbDonador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonador.FormattingEnabled = true;
            this.cbDonador.Location = new System.Drawing.Point(168, 36);
            this.cbDonador.Name = "cbDonador";
            this.cbDonador.Size = new System.Drawing.Size(543, 21);
            this.cbDonador.TabIndex = 6;
            this.cbDonador.ValueMember = "value";
            this.cbDonador.SelectedIndexChanged += new System.EventHandler(this.cbDonador_SelectedIndexChanged);
            // 
            // cbVisita
            // 
            this.cbVisita.DisplayMember = "text";
            this.cbVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisita.FormattingEnabled = true;
            this.cbVisita.Location = new System.Drawing.Point(168, 77);
            this.cbVisita.Name = "cbVisita";
            this.cbVisita.Size = new System.Drawing.Size(543, 21);
            this.cbVisita.TabIndex = 7;
            this.cbVisita.ValueMember = "value";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(168, 120);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(104, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // txtMotivo
            // 
            this.txtMotivo.AplicarColorFoco = true;
            this.txtMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotivo.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtMotivo.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtMotivo.Location = new System.Drawing.Point(168, 160);
            this.txtMotivo.MaxLength = 30;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(293, 20);
            this.txtMotivo.TabIndex = 9;
            this.txtMotivo.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.AplicarColorFoco = true;
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtObservaciones.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtObservaciones.Location = new System.Drawing.Point(168, 205);
            this.txtObservaciones.MaxLength = 1000;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(293, 91);
            this.txtObservaciones.TabIndex = 10;
            this.txtObservaciones.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(290, 302);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(371, 302);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(375, 120);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(108, 20);
            this.dtpHora.TabIndex = 14;
            // 
            // frmListadoVisitasCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 335);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbVisita);
            this.Controls.Add(this.cbDonador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoVisitasCrud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmListadoVisitasCrud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDonador;
        private System.Windows.Forms.ComboBox cbVisita;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private TextBoxEx.CtrlTextBox txtMotivo;
        private TextBoxEx.CtrlTextBox txtObservaciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}