namespace UI_Donaciones
{
    partial class frmConsultaDonadores
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
            this.gboxDatosPer = new System.Windows.Forms.GroupBox();
            this.cbTipoDonador = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbEstatus = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtImporte = new TextBoxEx.CtrlTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPerfil = new TextBoxEx.CtrlTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOcupacion = new TextBoxEx.CtrlTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRfc = new TextBoxEx.CtrlTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurp = new TextBoxEx.CtrlTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new TextBoxEx.CtrlTextBox();
            this.txtApeMat = new TextBoxEx.CtrlTextBox();
            this.txtApePat = new TextBoxEx.CtrlTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxDatosLocal = new System.Windows.Forms.GroupBox();
            this.txtCorreoAlt = new TextBoxEx.CtrlTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCorreo = new TextBoxEx.CtrlTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelOfi = new TextBoxEx.CtrlTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelCel = new TextBoxEx.CtrlTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new TextBoxEx.CtrlTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccion = new TextBoxEx.CtrlTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscar = new TextBoxEx.CtrlTextBox();
            this.cbDonador = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gboxDatosPer.SuspendLayout();
            this.gboxDatosLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDatosPer
            // 
            this.gboxDatosPer.Controls.Add(this.cbTipoDonador);
            this.gboxDatosPer.Controls.Add(this.label18);
            this.gboxDatosPer.Controls.Add(this.cbEstatus);
            this.gboxDatosPer.Controls.Add(this.label17);
            this.gboxDatosPer.Controls.Add(this.txtImporte);
            this.gboxDatosPer.Controls.Add(this.label16);
            this.gboxDatosPer.Controls.Add(this.txtPerfil);
            this.gboxDatosPer.Controls.Add(this.label15);
            this.gboxDatosPer.Controls.Add(this.txtOcupacion);
            this.gboxDatosPer.Controls.Add(this.label14);
            this.gboxDatosPer.Controls.Add(this.txtRfc);
            this.gboxDatosPer.Controls.Add(this.label7);
            this.gboxDatosPer.Controls.Add(this.txtCurp);
            this.gboxDatosPer.Controls.Add(this.label6);
            this.gboxDatosPer.Controls.Add(this.cbGenero);
            this.gboxDatosPer.Controls.Add(this.label5);
            this.gboxDatosPer.Controls.Add(this.txtEdad);
            this.gboxDatosPer.Controls.Add(this.dtpFechaNac);
            this.gboxDatosPer.Controls.Add(this.label4);
            this.gboxDatosPer.Controls.Add(this.txtNombre);
            this.gboxDatosPer.Controls.Add(this.txtApeMat);
            this.gboxDatosPer.Controls.Add(this.txtApePat);
            this.gboxDatosPer.Controls.Add(this.label3);
            this.gboxDatosPer.Controls.Add(this.label2);
            this.gboxDatosPer.Controls.Add(this.label1);
            this.gboxDatosPer.Location = new System.Drawing.Point(12, 41);
            this.gboxDatosPer.Name = "gboxDatosPer";
            this.gboxDatosPer.Size = new System.Drawing.Size(862, 254);
            this.gboxDatosPer.TabIndex = 4;
            this.gboxDatosPer.TabStop = false;
            this.gboxDatosPer.Text = "Datos personales";
            // 
            // cbTipoDonador
            // 
            this.cbTipoDonador.DisplayMember = "Nombre";
            this.cbTipoDonador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDonador.Enabled = false;
            this.cbTipoDonador.FormattingEnabled = true;
            this.cbTipoDonador.Location = new System.Drawing.Point(368, 225);
            this.cbTipoDonador.Name = "cbTipoDonador";
            this.cbTipoDonador.Size = new System.Drawing.Size(214, 21);
            this.cbTipoDonador.TabIndex = 27;
            this.cbTipoDonador.ValueMember = "Clave";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(364, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 20);
            this.label18.TabIndex = 26;
            this.label18.Text = "Tipo donador";
            // 
            // cbEstatus
            // 
            this.cbEstatus.DisplayMember = "text";
            this.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstatus.Enabled = false;
            this.cbEstatus.FormattingEnabled = true;
            this.cbEstatus.Location = new System.Drawing.Point(204, 225);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(143, 21);
            this.cbEstatus.TabIndex = 25;
            this.cbEstatus.ValueMember = "value";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(200, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Estatus";
            // 
            // txtImporte
            // 
            this.txtImporte.AplicarColorFoco = true;
            this.txtImporte.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtImporte.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtImporte.Location = new System.Drawing.Point(10, 226);
            this.txtImporte.MaxLength = 10;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(182, 20);
            this.txtImporte.TabIndex = 23;
            this.txtImporte.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Importe";
            // 
            // txtPerfil
            // 
            this.txtPerfil.AplicarColorFoco = true;
            this.txtPerfil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPerfil.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtPerfil.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtPerfil.Location = new System.Drawing.Point(368, 169);
            this.txtPerfil.MaxLength = 100;
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.ReadOnly = true;
            this.txtPerfil.Size = new System.Drawing.Size(370, 20);
            this.txtPerfil.TabIndex = 21;
            this.txtPerfil.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(364, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Perfil";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.AplicarColorFoco = true;
            this.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOcupacion.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtOcupacion.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtOcupacion.Location = new System.Drawing.Point(10, 169);
            this.txtOcupacion.MaxLength = 35;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.ReadOnly = true;
            this.txtOcupacion.Size = new System.Drawing.Size(337, 20);
            this.txtOcupacion.TabIndex = 19;
            this.txtOcupacion.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ocupación";
            // 
            // txtRfc
            // 
            this.txtRfc.AplicarColorFoco = true;
            this.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRfc.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtRfc.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtRfc.Location = new System.Drawing.Point(607, 110);
            this.txtRfc.MaxLength = 13;
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.ReadOnly = true;
            this.txtRfc.Size = new System.Drawing.Size(236, 20);
            this.txtRfc.TabIndex = 17;
            this.txtRfc.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(603, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rfc";
            // 
            // txtCurp
            // 
            this.txtCurp.AplicarColorFoco = true;
            this.txtCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurp.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtCurp.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtCurp.Location = new System.Drawing.Point(368, 110);
            this.txtCurp.MaxLength = 16;
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.ReadOnly = true;
            this.txtCurp.Size = new System.Drawing.Size(214, 20);
            this.txtCurp.TabIndex = 14;
            this.txtCurp.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Curp";
            // 
            // cbGenero
            // 
            this.cbGenero.DisplayMember = "text";
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Enabled = false;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(222, 110);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(125, 21);
            this.cbGenero.TabIndex = 10;
            this.cbGenero.ValueMember = "value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genero";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(124, 111);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(76, 20);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Enabled = false;
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(10, 111);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(108, 20);
            this.dtpFechaNac.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha nacimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.AplicarColorFoco = true;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtNombre.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtNombre.Location = new System.Drawing.Point(596, 49);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(247, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtApeMat
            // 
            this.txtApeMat.AplicarColorFoco = true;
            this.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMat.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtApeMat.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtApeMat.Location = new System.Drawing.Point(299, 49);
            this.txtApeMat.MaxLength = 30;
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.ReadOnly = true;
            this.txtApeMat.Size = new System.Drawing.Size(257, 20);
            this.txtApeMat.TabIndex = 3;
            this.txtApeMat.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // txtApePat
            // 
            this.txtApePat.AplicarColorFoco = true;
            this.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePat.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtApePat.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtApePat.Location = new System.Drawing.Point(10, 49);
            this.txtApePat.MaxLength = 30;
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.ReadOnly = true;
            this.txtApePat.Size = new System.Drawing.Size(257, 20);
            this.txtApePat.TabIndex = 1;
            this.txtApePat.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido materno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido paterno";
            // 
            // gboxDatosLocal
            // 
            this.gboxDatosLocal.Controls.Add(this.txtCorreoAlt);
            this.gboxDatosLocal.Controls.Add(this.label13);
            this.gboxDatosLocal.Controls.Add(this.txtCorreo);
            this.gboxDatosLocal.Controls.Add(this.label12);
            this.gboxDatosLocal.Controls.Add(this.txtTelOfi);
            this.gboxDatosLocal.Controls.Add(this.label11);
            this.gboxDatosLocal.Controls.Add(this.txtTelCel);
            this.gboxDatosLocal.Controls.Add(this.label10);
            this.gboxDatosLocal.Controls.Add(this.txtTelefono);
            this.gboxDatosLocal.Controls.Add(this.label9);
            this.gboxDatosLocal.Controls.Add(this.txtDireccion);
            this.gboxDatosLocal.Controls.Add(this.label8);
            this.gboxDatosLocal.Location = new System.Drawing.Point(12, 301);
            this.gboxDatosLocal.Name = "gboxDatosLocal";
            this.gboxDatosLocal.Size = new System.Drawing.Size(862, 206);
            this.gboxDatosLocal.TabIndex = 5;
            this.gboxDatosLocal.TabStop = false;
            this.gboxDatosLocal.Text = "Datos de contacto";
            // 
            // txtCorreoAlt
            // 
            this.txtCorreoAlt.AplicarColorFoco = true;
            this.txtCorreoAlt.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtCorreoAlt.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtCorreoAlt.Location = new System.Drawing.Point(10, 172);
            this.txtCorreoAlt.MaxLength = 35;
            this.txtCorreoAlt.Name = "txtCorreoAlt";
            this.txtCorreoAlt.ReadOnly = true;
            this.txtCorreoAlt.Size = new System.Drawing.Size(275, 20);
            this.txtCorreoAlt.TabIndex = 11;
            this.txtCorreoAlt.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Correo alternativo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AplicarColorFoco = true;
            this.txtCorreo.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtCorreo.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtCorreo.Location = new System.Drawing.Point(430, 110);
            this.txtCorreo.MaxLength = 35;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(275, 20);
            this.txtCorreo.TabIndex = 9;
            this.txtCorreo.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(426, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Correo";
            // 
            // txtTelOfi
            // 
            this.txtTelOfi.AplicarColorFoco = true;
            this.txtTelOfi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelOfi.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtTelOfi.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtTelOfi.Location = new System.Drawing.Point(222, 110);
            this.txtTelOfi.MaxLength = 10;
            this.txtTelOfi.Name = "txtTelOfi";
            this.txtTelOfi.ReadOnly = true;
            this.txtTelOfi.Size = new System.Drawing.Size(182, 20);
            this.txtTelOfi.TabIndex = 7;
            this.txtTelOfi.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Teléfono oficina";
            // 
            // txtTelCel
            // 
            this.txtTelCel.AplicarColorFoco = true;
            this.txtTelCel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelCel.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtTelCel.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtTelCel.Location = new System.Drawing.Point(10, 110);
            this.txtTelCel.MaxLength = 10;
            this.txtTelCel.Name = "txtTelCel";
            this.txtTelCel.ReadOnly = true;
            this.txtTelCel.Size = new System.Drawing.Size(182, 20);
            this.txtTelCel.TabIndex = 5;
            this.txtTelCel.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Teléfono celular";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AplicarColorFoco = true;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtTelefono.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtTelefono.Location = new System.Drawing.Point(661, 51);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(182, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.Tecleado = TextBoxEx.CtrlTextBox.Validar.Numeros;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(657, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AplicarColorFoco = true;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtDireccion.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtDireccion.Location = new System.Drawing.Point(10, 51);
            this.txtDireccion.MaxLength = 500;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(630, 20);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dirección";
            // 
            // txtBuscar
            // 
            this.txtBuscar.AplicarColorFoco = true;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.ColorControlDesenfocado = System.Drawing.Color.White;
            this.txtBuscar.ColorControlEnfocado = System.Drawing.Color.LightCyan;
            this.txtBuscar.Location = new System.Drawing.Point(140, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(139, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Tecleado = TextBoxEx.CtrlTextBox.Validar.Normal;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // cbDonador
            // 
            this.cbDonador.DisplayMember = "text";
            this.cbDonador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDonador.FormattingEnabled = true;
            this.cbDonador.Location = new System.Drawing.Point(285, 8);
            this.cbDonador.Name = "cbDonador";
            this.cbDonador.Size = new System.Drawing.Size(465, 21);
            this.cbDonador.TabIndex = 2;
            this.cbDonador.ValueMember = "value";
            this.cbDonador.SelectedIndexChanged += new System.EventHandler(this.cbDonador_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "Buscar donador:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(780, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmConsultaDonadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 519);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbDonador);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.gboxDatosLocal);
            this.Controls.Add(this.gboxDatosPer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaDonadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsultaDonadores_Load);
            this.gboxDatosPer.ResumeLayout(false);
            this.gboxDatosPer.PerformLayout();
            this.gboxDatosLocal.ResumeLayout(false);
            this.gboxDatosLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDatosPer;
        private System.Windows.Forms.ComboBox cbTipoDonador;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbEstatus;
        private System.Windows.Forms.Label label17;
        private TextBoxEx.CtrlTextBox txtImporte;
        private System.Windows.Forms.Label label16;
        private TextBoxEx.CtrlTextBox txtPerfil;
        private System.Windows.Forms.Label label15;
        private TextBoxEx.CtrlTextBox txtOcupacion;
        private System.Windows.Forms.Label label14;
        private TextBoxEx.CtrlTextBox txtRfc;
        private System.Windows.Forms.Label label7;
        private TextBoxEx.CtrlTextBox txtCurp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label4;
        private TextBoxEx.CtrlTextBox txtNombre;
        private TextBoxEx.CtrlTextBox txtApeMat;
        private TextBoxEx.CtrlTextBox txtApePat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gboxDatosLocal;
        private TextBoxEx.CtrlTextBox txtCorreoAlt;
        private System.Windows.Forms.Label label13;
        private TextBoxEx.CtrlTextBox txtCorreo;
        private System.Windows.Forms.Label label12;
        private TextBoxEx.CtrlTextBox txtTelOfi;
        private System.Windows.Forms.Label label11;
        private TextBoxEx.CtrlTextBox txtTelCel;
        private System.Windows.Forms.Label label10;
        private TextBoxEx.CtrlTextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private TextBoxEx.CtrlTextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private TextBoxEx.CtrlTextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbDonador;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnEditar;
    }
}