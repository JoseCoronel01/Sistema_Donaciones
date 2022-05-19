using PCL_Donaciones.str;
using PCL_Donaciones.BusinessRules;
using PCL_Donaciones.dao;
using System;
using System.Windows.Forms;

namespace UI_Donaciones
{
    public partial class frmListadoCrudUsuariosSistema : Form
    {
        public bool ModoEdicion { get; set; }
        public bool Insert { get; set; }
        public strUsuarioSistema Usuario { get; set; }

        public frmListadoCrudUsuariosSistema()
        {
            InitializeComponent();
        }

        private void frmListadoCrudUsuariosSistema_Load(object sender, EventArgs e)
        {
            CargarComboTipo();

            if (this.Usuario != null)
                MostrarDatos();
        }

        public void CargarComboTipo()
        {
            cbTipo.DataSource = strBRUsuarioSistema.TiposUsuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPassword.Text != "" && cbTipo.SelectedIndex > -1)
            {
                if (this.Insert)
                {
                    this.Usuario = CargaObjeto(this.Usuario);

                    int save = daoUsuariosSistema.Insert(this.Usuario);

                    if (save > 0)
                    {
                        this.Insert = false;
                        MessageBox.Show("Usuario registrado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.ModoEdicion)
                {
                    this.Usuario = CargaObjeto(this.Usuario);

                    int save = daoUsuariosSistema.Update(this.Usuario);

                    if (save > 0)
                    {
                        this.ModoEdicion = false;
                        MessageBox.Show("Usuario modificado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay campos vacíos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarDatos()
        {
            txtUsuario.Text = this.Usuario.Usuario;
            txtPassword.Text = this.Usuario.Password;
            cbTipo.SelectedValue = this.Usuario.Tipo;
        }

        private strUsuarioSistema CargaObjeto(strUsuarioSistema usuario)
        {
            this.Usuario = new strUsuarioSistema();
            this.Usuario.Usuario = txtUsuario.Text;
            this.Usuario.Password = txtPassword.Text;
            this.Usuario.Tipo = (strUsuarioSistema.eTipo)cbTipo.SelectedValue;
            return this.Usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}