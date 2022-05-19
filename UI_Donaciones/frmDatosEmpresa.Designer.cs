namespace UI_Donaciones
{
    partial class frmDatosEmpresa
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new TextBoxEx.CtrlTextBox();
            this.txtDireccion = new TextBoxEx.CtrlTextBox();
            this.txtRFC = new TextBoxEx.CtrlTextBox();
            this.txtCiudad = new TextBoxEx.CtrlTextBox();
            this.txtCP = new TextBoxEx.CtrlTextBox();
            this.txtRuta = new TextBoxEx.CtrlTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "RFC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "CP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ruta directorio";
            // 
            // txtNombre
            // 
            this.txtNombre.AplicarColorFoco = true;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtNombre.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtNombre.Location = new System.Drawing.Point(164, 29);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtDireccion
            // 
            this.txtDireccion.AplicarColorFoco = true;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtDireccion.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtDireccion.Location = new System.Drawing.Point(164, 76);
            this.txtDireccion.MaxLength = 500;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(265, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtRFC
            // 
            this.txtRFC.AplicarColorFoco = true;
            this.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRFC.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtRFC.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtRFC.Location = new System.Drawing.Point(164, 125);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(265, 20);
            this.txtRFC.TabIndex = 8;
            this.txtRFC.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtCiudad
            // 
            this.txtCiudad.AplicarColorFoco = true;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtCiudad.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtCiudad.Location = new System.Drawing.Point(164, 171);
            this.txtCiudad.MaxLength = 40;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(265, 20);
            this.txtCiudad.TabIndex = 9;
            this.txtCiudad.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtCP
            // 
            this.txtCP.AplicarColorFoco = true;
            this.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCP.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtCP.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtCP.Location = new System.Drawing.Point(164, 217);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(265, 20);
            this.txtCP.TabIndex = 10;
            this.txtCP.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            // 
            // txtRuta
            // 
            this.txtRuta.AplicarColorFoco = true;
            this.txtRuta.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtRuta.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtRuta.Location = new System.Drawing.Point(164, 266);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(265, 20);
            this.txtRuta.TabIndex = 11;
            this.txtRuta.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(288, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar y Salir";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(435, 263);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(97, 23);
            this.btnAbrir.TabIndex = 13;
            this.btnAbrir.Text = "Cargar imagen";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmDatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 355);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la empresa";
            this.Load += new System.EventHandler(this.frmDatosEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private TextBoxEx.CtrlTextBox txtNombre;
        private TextBoxEx.CtrlTextBox txtDireccion;
        private TextBoxEx.CtrlTextBox txtRFC;
        private TextBoxEx.CtrlTextBox txtCiudad;
        private TextBoxEx.CtrlTextBox txtCP;
        private TextBoxEx.CtrlTextBox txtRuta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAbrir;
    }
}