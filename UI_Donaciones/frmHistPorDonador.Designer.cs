namespace UI_Donaciones
{
    partial class frmHistPorDonador
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
            this.btnPreliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new TextBoxEx.CtrlTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donador";
            // 
            // cbDonador
            // 
            this.cbDonador.DisplayMember = "text";
            this.cbDonador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonador.FormattingEnabled = true;
            this.cbDonador.Location = new System.Drawing.Point(104, 41);
            this.cbDonador.Name = "cbDonador";
            this.cbDonador.Size = new System.Drawing.Size(342, 21);
            this.cbDonador.TabIndex = 2;
            this.cbDonador.ValueMember = "value";
            // 
            // btnPreliminar
            // 
            this.btnPreliminar.Location = new System.Drawing.Point(288, 103);
            this.btnPreliminar.Name = "btnPreliminar";
            this.btnPreliminar.Size = new System.Drawing.Size(158, 23);
            this.btnPreliminar.TabIndex = 3;
            this.btnPreliminar.Text = "Preliminar";
            this.btnPreliminar.UseVisualStyleBackColor = true;
            this.btnPreliminar.Click += new System.EventHandler(this.btnPreliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.AplicarColorFoco = true;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtBuscar.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtBuscar.Location = new System.Drawing.Point(104, 11);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(342, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar";
            // 
            // frmHistPorDonador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 138);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnPreliminar);
            this.Controls.Add(this.cbDonador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistPorDonador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de donaciones";
            this.Load += new System.EventHandler(this.frmHistPorDonador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDonador;
        private System.Windows.Forms.Button btnPreliminar;
        private TextBoxEx.CtrlTextBox txtBuscar;
        private System.Windows.Forms.Label label2;
    }
}