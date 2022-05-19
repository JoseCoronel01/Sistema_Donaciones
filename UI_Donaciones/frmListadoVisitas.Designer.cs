namespace UI_Donaciones
{
    partial class frmListadoVisitas
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gvVisitas = new System.Windows.Forms.DataGridView();
            this.lbDonador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDataDonador = new System.Windows.Forms.Label();
            this.lbDataVisita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvVisitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(547, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(547, 171);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(547, 142);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gvVisitas
            // 
            this.gvVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVisitas.Location = new System.Drawing.Point(12, 142);
            this.gvVisitas.MultiSelect = false;
            this.gvVisitas.Name = "gvVisitas";
            this.gvVisitas.ReadOnly = true;
            this.gvVisitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvVisitas.Size = new System.Drawing.Size(529, 146);
            this.gvVisitas.TabIndex = 4;
            this.gvVisitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVisitas_CellClick);
            // 
            // lbDonador
            // 
            this.lbDonador.AutoSize = true;
            this.lbDonador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonador.Location = new System.Drawing.Point(12, 12);
            this.lbDonador.Name = "lbDonador";
            this.lbDonador.Size = new System.Drawing.Size(90, 25);
            this.lbDonador.TabIndex = 8;
            this.lbDonador.Text = "Donador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Visita:";
            // 
            // lbDataDonador
            // 
            this.lbDataDonador.AutoSize = true;
            this.lbDataDonador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDonador.Location = new System.Drawing.Point(12, 37);
            this.lbDataDonador.Name = "lbDataDonador";
            this.lbDataDonador.Size = new System.Drawing.Size(15, 20);
            this.lbDataDonador.TabIndex = 10;
            this.lbDataDonador.Text = "*";
            // 
            // lbDataVisita
            // 
            this.lbDataVisita.AutoSize = true;
            this.lbDataVisita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataVisita.Location = new System.Drawing.Point(12, 87);
            this.lbDataVisita.Name = "lbDataVisita";
            this.lbDataVisita.Size = new System.Drawing.Size(15, 20);
            this.lbDataVisita.TabIndex = 11;
            this.lbDataVisita.Text = "*";
            // 
            // frmListadoVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 300);
            this.Controls.Add(this.lbDataVisita);
            this.Controls.Add(this.lbDataDonador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDonador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gvVisitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoVisitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitas";
            this.Load += new System.EventHandler(this.frmListadoVisitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvVisitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView gvVisitas;
        private System.Windows.Forms.Label lbDonador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDataDonador;
        private System.Windows.Forms.Label lbDataVisita;
    }
}