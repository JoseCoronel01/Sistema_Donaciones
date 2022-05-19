using System;
using System.Windows.Forms;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;

namespace UI_Donaciones
{
    public partial class Form1 : Form
    {
        strUsuarioSistema strUsuario = new strUsuarioSistema();

        public Form1()
        {
            InitializeComponent();
        }

        private void mnuDonadorNuevo_Click(object sender, EventArgs e)
        {
            if (this.strUsuario.Tipo == strUsuarioSistema.eTipo.SUPERVISOR)
            {
                frmAltaDonador frm = new frmAltaDonador();
                frm.ModoEdicion = false;
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Acceso no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuconsultar_Click(object sender, EventArgs e)
        {
            if (this.strUsuario.Tipo == strUsuarioSistema.eTipo.SUPERVISOR)
            {
                frmConsultaDonadores frm = new frmConsultaDonadores();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Acceso no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuUsuariosSistema_Click(object sender, EventArgs e)
        {
            if (this.strUsuario.Tipo == strUsuarioSistema.eTipo.SUPERVISOR)
            {
                frmListadoUsuariosSistema frm = new frmListadoUsuariosSistema();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Acceso no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuDatosEmpresa_Click(object sender, EventArgs e)
        {
            if (strUsuario.Tipo == strUsuarioSistema.eTipo.SUPERVISOR)
            {
                frmDatosEmpresa frm = new frmDatosEmpresa();
                frm.ShowDialog();
                imagenFondo.ImageLocation = frm.Fondo;
            }
            else
                MessageBox.Show("Acceso no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuVisitas_Click(object sender, EventArgs e)
        {
            if (strUsuario.Tipo == strUsuarioSistema.eTipo.OPERADOR)
            {
                frmListadoVisitas frm = new frmListadoVisitas();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Acceso no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmAcceso frm = new frmAcceso();
            frm.ShowDialog();
            if (!frm.Entrar)
            {
                this.Close();
            }
            else
            {
                this.strUsuario = frm.Usuario;

                mnuUsuario.Text = "HOLA " + this.strUsuario.Usuario.ToUpper() + " - MODO " + this.strUsuario.Tipo.ToString();

                var obj = daoDatosEmpresa.GetObject();
                if (obj != null)
                    imagenFondo.ImageLocation = obj.RutaDirectorio;
            }
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNuevaDonacion_Click(object sender, EventArgs e)
        {
            if (this.strUsuario.Tipo == strUsuarioSistema.eTipo.OPERADOR)
            {
                frmDonaciones frm = new frmDonaciones();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Acceso no permitido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuListadoDeDonaciones_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes("Donaciones");
            frm.Show();
        }

        private void mnuDonacinesFecha_Click(object sender, EventArgs e)
        {
            frmGraficaDonaciones frm = new frmGraficaDonaciones();
            frm.Show();
        }

        private void historialPorDonadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ListadoDeDonadores
            frmReportes frm = new frmReportes("Donadores");
            frm.Show();
        }

        private void historialDeDonacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Historia de donaciones
            frmHistPorDonador frm = new frmHistPorDonador();
            frm.ShowDialog();
        }
    }
}