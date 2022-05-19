namespace UI_Donaciones
{
    partial class frmConfirmacionAltaDonador
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
            this.cbDonador = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new TextBoxEx.CtrlTextBox();
            this.txtMatricula = new TextBoxEx.CtrlTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar donador:";
            // 
            // cbDonador
            // 
            this.cbDonador.DisplayMember = "text";
            this.cbDonador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonador.FormattingEnabled = true;
            this.cbDonador.Location = new System.Drawing.Point(134, 54);
            this.cbDonador.Name = "cbDonador";
            this.cbDonador.Size = new System.Drawing.Size(556, 21);
            this.cbDonador.TabIndex = 2;
            this.cbDonador.ValueMember = "value";
            this.cbDonador.SelectedIndexChanged += new System.EventHandler(this.cbDonador_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AplicarColorFoco = true;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtBuscar.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtBuscar.Location = new System.Drawing.Point(134, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(345, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // txtMatricula
            // 
            this.txtMatricula.AplicarColorFoco = true;
            this.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatricula.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtMatricula.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtMatricula.Location = new System.Drawing.Point(134, 105);
            this.txtMatricula.MaxLength = 30;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(345, 20);
            this.txtMatricula.TabIndex = 4;
            this.txtMatricula.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(134, 131);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(345, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Matrícula";
            // 
            // frmConfirmacionAltaDonador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbDonador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmacionAltaDonador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfirmacionAltaDonador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDonador;
        private TextBoxEx.CtrlTextBox txtBuscar;
        private TextBoxEx.CtrlTextBox txtMatricula;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
    }
}