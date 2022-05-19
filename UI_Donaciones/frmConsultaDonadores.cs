using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PCL_Donaciones.BusinessRules;
using PCL_Comun.Utilidades;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;
using System.Drawing;

namespace UI_Donaciones
{
    public partial class frmConsultaDonadores : Form
    {
        private strBuscador strBuscador = new strBuscador();

        private List<strDonador> lista = new List<strDonador>();

        private strEstatusDonador estatusDonador = new strEstatusDonador();

        public int Id { get; set; }

        public frmConsultaDonadores()
        {
            InitializeComponent();
        }

        private void frmConsultaDonadores_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();

            gboxDatosPer.BackColor = Color.LightCyan;

            gboxDatosLocal.BackColor = Color.LightCyan;

            lista = daoDonadores.GetAll();

            CargaCombos();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                cbDonador.DataSource = new List<ElementoComboBox>();
                MostrarDatos(null);
                return;
            }

            List<ElementoComboBox> elem = strBuscador.Busqueda(lista, txtBuscar.Text);

            cbDonador.DataSource = elem;
        }

        private void cbDonador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDonador.SelectedIndex == -1)
            {
                MostrarDatos(null);
                return;
            }

            MostrarDatos(daoDonadores.GetObject(int.Parse(cbDonador.SelectedValue.ToString())));
        }

        private void MostrarDatos(strDonador str)
        {
            if (str != null)
            {
                this.Id = str.Id;

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
            else
            {
                this.Id = 0;

                txtApeMat.Text = "";
                txtApePat.Text = "";
                txtCorreo.Text = "";
                txtCorreoAlt.Text = "";
                txtCurp.Text = "";
                txtDireccion.Text = "";
                txtNombre.Text = "";
                txtOcupacion.Text = "";
                txtPerfil.Text = "";
                txtRfc.Text = "";
                txtTelefono.Text = "";
                txtTelCel.Text = "";
                txtTelOfi.Text = "";

                txtImporte.Text = "";

                dtpFechaNac.Value = DateTime.Now;
                txtEdad.Text = Util.CalcularEdad((DateTime)dtpFechaNac.Value).ToString();

                cbEstatus.SelectedIndex = -1;
                cbGenero.SelectedIndex = -1;
                cbTipoDonador.SelectedIndex = -1;
            }
        }

        private void CargaCombos()
        {
            cbTipoDonador.DataSource = daoTipoDonadores.GetAll();

            cbGenero.DataSource = Util.Genero();

            cbEstatus.DataSource = estatusDonador.CargarEstatus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.Id > 0)
            {
                frmAltaDonador frm = new frmAltaDonador();
                frm.ModoEdicion = true;
                frm.DonadorEditado = daoDonadores.GetObject(this.Id);
                frm.ShowDialog();
                if (!frm.ModoEdicion)
                    MostrarDatos(daoDonadores.GetObject(int.Parse(this.Id.ToString())));
            }
            else
            {
                MessageBox.Show("No has seleccionado un donador para editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}