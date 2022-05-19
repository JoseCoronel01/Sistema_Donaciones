namespace UI_Donaciones
{
    partial class frmDonaciones
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
            this.txtBuscar = new TextBoxEx.CtrlTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.gvDonadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporte = new TextBoxEx.CtrlTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboxCaja = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonadores)).BeginInit();
            this.gboxCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.AplicarColorFoco = true;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtBuscar.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtBuscar.Location = new System.Drawing.Point(130, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(243, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(8, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Buscar donador:";
            // 
            // gvDonadores
            // 
            this.gvDonadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDonadores.Location = new System.Drawing.Point(12, 38);
            this.gvDonadores.MultiSelect = false;
            this.gvDonadores.Name = "gvDonadores";
            this.gvDonadores.ReadOnly = true;
            this.gvDonadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDonadores.Size = new System.Drawing.Size(1136, 187);
            this.gvDonadores.TabIndex = 2;
            this.gvDonadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDonadores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe";
            // 
            // txtImporte
            // 
            this.txtImporte.AplicarColorFoco = true;
            this.txtImporte.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtImporte.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtImporte.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(90, 68);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(178, 35);
            this.txtImporte.TabIndex = 3;
            this.txtImporte.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(90, 33);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(107, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(11, 109);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(257, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboxCaja
            // 
            this.gboxCaja.Controls.Add(this.label1);
            this.gboxCaja.Controls.Add(this.btnGuardar);
            this.gboxCaja.Controls.Add(this.label2);
            this.gboxCaja.Controls.Add(this.dtpFecha);
            this.gboxCaja.Controls.Add(this.txtImporte);
            this.gboxCaja.Location = new System.Drawing.Point(866, 231);
            this.gboxCaja.Name = "gboxCaja";
            this.gboxCaja.Size = new System.Drawing.Size(282, 140);
            this.gboxCaja.TabIndex = 3;
            this.gboxCaja.TabStop = false;
            this.gboxCaja.Text = "Donar";
            this.gboxCaja.Enter += new System.EventHandler(this.gboxCaja_Enter);
            this.gboxCaja.Leave += new System.EventHandler(this.gboxCaja_Leave);
            // 
            // frmDonaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 379);
            this.Controls.Add(this.gboxCaja);
            this.Controls.Add(this.gvDonadores);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDonaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones";
            this.Load += new System.EventHandler(this.frmDonaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDonadores)).EndInit();
            this.gboxCaja.ResumeLayout(false);
            this.gboxCaja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxEx.CtrlTextBox txtBuscar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView gvDonadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBoxEx.CtrlTextBox txtImporte;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboxCaja;
    }
}