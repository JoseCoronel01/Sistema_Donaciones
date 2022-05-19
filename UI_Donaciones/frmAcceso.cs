using System;
using System.Windows.Forms;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;

namespace UI_Donaciones
{
    public partial class frmAcceso : Form
    {
        public bool Entrar { get; set; }
        public strUsuarioSistema Usuario { get; set; }

        int contador;

        static int intentos = 5;

        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            contador = 1;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPassword.Text != "")
            {
                strUsuarioSistema str = daoUsuariosSistema.GetIn(txtUsuario.Text, txtPassword.Text);

                if (str == null)
                {
                    if (contador != intentos)
                    {
                        MessageBox.Show("Intentos de entrar: " + contador + ", usuario o contraseña incorrectos. ",
                            "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtUsuario.Text = "";
                        txtPassword.Text = "";
                        txtUsuario.Focus();

                        contador++;
                    }
                    else
                    {
                        MessageBox.Show("Intentos de entrar: " + contador + " veces no recuerda la contraseña, " +
                            "por seguridad el sistema se cerrará " +
                            "favor de reportar al departamento de sistemas.",
                            "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.Entrar = false;
                        this.Close();
                    }
                }
                else
                {
                    contador = 1;

                    this.Entrar = true;

                    this.Usuario = daoUsuariosSistema.GetObject(str.Usuario);

                    this.Close();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}