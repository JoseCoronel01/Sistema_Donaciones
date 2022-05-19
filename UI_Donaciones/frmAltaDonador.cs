using System;
using System.Drawing;
using System.Windows.Forms;
using PCL_Comun.Utilidades;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;
using PCL_Donaciones.BusinessRules;

namespace UI_Donaciones
{
    public partial class frmAltaDonador : Form
    {
        public string ClaveEstado { get; set; }

        public bool ModoEdicion { get; set; }
        public strDonador DonadorEditado { get; set; }

        strDonador str = new strDonador();

        strEstatusDonador estatusDonador = new strEstatusDonador();

        public frmAltaDonador()
        {
            InitializeComponent();
        }

        private void frmAltaDonador_Load(object sender, EventArgs e)
        {
            gboxDatosPer.BackColor = Color.LightCyan;

            txtApePat.Focus();

            txtEdad.Text = Util.CalcularEdad(dtpFechaNac.Value).ToString();

            CargaCombos();

            if (this.ModoEdicion)
            {
                cbTipoDonador.Enabled = false;
                MostrarDatos(DonadorEditado);
            }
        }

        private void gboxDatosPer_Enter(object sender, EventArgs e)
        {
            gboxDatosPer.BackColor = Color.LightCyan;
        }

        private void gboxDatosPer_Leave(object sender, EventArgs e)
        {
            gboxDatosPer.BackColor = Color.Transparent;
        }

        private void gboxDatosLocal_Enter(object sender, EventArgs e)
        {
            gboxDatosLocal.BackColor = Color.LightCyan;
        }

        private void gboxDatosLocal_Leave(object sender, EventArgs e)
        {
            gboxDatosLocal.BackColor = Color.Transparent;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = Util.CalcularEdad(dtpFechaNac.Value).ToString();
        }

        private void btnGenerarCurp_Click(object sender, EventArgs e)
        {
            txtCurp.Text = Util.GeneraCurp(txtApePat.Text, txtApeMat.Text, txtNombre.Text, 
                dtpFechaNac.Value, cbGenero.SelectedValue.ToString(), this.ClaveEstado);
        }

        private void btnGenerarRfc_Click(object sender, EventArgs e)
        {
            txtRfc.Text = Util.GeneraRfc(txtApePat.Text, txtApeMat.Text, txtNombre.Text,
                dtpFechaNac.Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ModoEdicion)
            {
                str = CargaObjeto(DonadorEditado);

                int save = daoDonadores.Update(str);

                if (save > 0)
                {
                    this.ModoEdicion = false;
                    this.Close();
                }
                else
                    MessageBox.Show("Error! No se pudo editar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtCurp.Text != "" && txtRfc.Text != "")
                {
                    str = CargaObjeto(str);

                    frmConfirmacionAltaDonador frm = new frmConfirmacionAltaDonador();

                    frm.Donador = str;

                    frm.ShowDialog();

                    if (frm.Salir)
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Hay campos vacíos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private strDonador CargaObjeto(strDonador str)
        {
            if (!this.ModoEdicion)
            {
                str.Id = daoDonadores.CreateId();
                str.FechaReg = DateTime.Now;
            }
            else
                str.Id = DonadorEditado.Id;

            str.ApellidoMat = txtApeMat.Text;
            str.ApellidoPat = txtApePat.Text;
            str.Correo = txtCorreo.Text;
            str.CorreoAlt = txtCorreoAlt.Text;
            str.Curp = txtCurp.Text;
            str.Direccion = txtDireccion.Text;
            str.Estatus = (strDonador.eEstatus)cbEstatus.SelectedValue;
            str.FechaNac = dtpFechaNac.Value;
            str.Importe = double.Parse(txtImporte.Text);
            str.Nombre = txtNombre.Text;
            str.Ocupacion = txtOcupacion.Text;
            str.Perfil = txtPerfil.Text;
            str.RFC = txtRfc.Text;
            str.Sexo = cbGenero.SelectedValue.ToString();
            str.Telefono = txtTelefono.Text;
            str.TelefonoCel = txtTelCel.Text;
            str.TelefonoOfi = txtTelOfi.Text;
            str.TipoDonador = cbTipoDonador.SelectedValue.ToString();
            return str;
        }

        private void MostrarDatos(strDonador str)
        {
            if (str != null)
            {
                txtApeMat.Text = str.ApellidoMat;
                txtApePat.Text = str.ApellidoPat;
                txtCorreo.Text = str.Correo;
                txtCorreoAlt.Text = str.CorreoAlt;
                txtCurp.Text = str.Curp;
                txtDireccion.Text = str.Direccion;
                txtNombre.Text = str.Nombre;
                txtOcupacion.Text = str.Ocupacion;
                txtPerfil.Text = str.Perfil;
                txtRfc.Text = str.RFC;
                txtTelefono.Text = str.Telefono;
                txtTelCel.Text = str.TelefonoCel;
                txtTelOfi.Text = str.TelefonoOfi;

                txtImporte.Text = str.Importe.ToString();

                dtpFechaNac.Value = str.FechaNac.Value;
                txtEdad.Text = Util.CalcularEdad((DateTime)dtpFechaNac.Value).ToString();

                cbEstatus.SelectedValue = str.Estatus;
                cbGenero.SelectedValue = str.Sexo;
                cbTipoDonador.SelectedValue = str.TipoDonador;
            }
        }

        private void CargaCombos()
        {
            cbTipoDonador.DataSource = daoTipoDonadores.GetAll();

            cbGenero.DataSource = Util.Genero();

            cbEstatus.DataSource = estatusDonador.CargarEstatus();
        }

        private void btnSelecEstado_Click(object sender, EventArgs e)
        {
            frmSelecEstado frm = new frmSelecEstado();

            frm.ShowDialog();

            this.ClaveEstado = frm.Clave;
        }
    }
}