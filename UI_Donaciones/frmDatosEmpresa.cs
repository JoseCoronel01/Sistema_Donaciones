using System;
using System.Windows.Forms;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;

namespace UI_Donaciones
{
    public partial class frmDatosEmpresa : Form
    {
        strDatoEmpresa str = new strDatoEmpresa();

        public string Fondo { get; private set; }

        public frmDatosEmpresa()
        {
            InitializeComponent();
        }

        private void frmDatosEmpresa_Load(object sender, EventArgs e)
        {
            str = daoDatosEmpresa.GetObject();

            MostrarDatos();
        }

        private void MostrarDatos()
        {
            if (str != null)
            {
                txtCiudad.Text = str.Ciudad;
                txtCP.Text = str.CP;
                txtDireccion.Text = str.Direccion;
                txtNombre.Text = str.Nombre;
                txtRFC.Text = str.RFC;
                txtRuta.Text = str.RutaDirectorio;
                this.Fondo = str.RutaDirectorio;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (str == null)
                {
                    str = CargaObjeto(str);

                    int save = daoDatosEmpresa.Insert(str);

                    if (save > 0)
                    {
                        this.Fondo = str.RutaDirectorio;
                        MessageBox.Show("Datos guardados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    str = CargaObjeto(str);

                    int save = daoDatosEmpresa.Update(str);

                    if (save > 0)
                    {
                        this.Fondo = str.RutaDirectorio;
                        MessageBox.Show("Datos actualizados correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Close();
            }
            else
                MessageBox.Show("campo nombre es requerido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private strDatoEmpresa CargaObjeto(strDatoEmpresa str)
        {
            str = new strDatoEmpresa();
            str.Ciudad = txtCiudad.Text;
            str.CP = txtCP.Text;
            str.Direccion = txtDireccion.Text;
            str.Nombre = txtNombre.Text;
            str.RFC = txtRFC.Text;
            str.RutaDirectorio = txtRuta.Text;
            return str;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Multiselect = false;

            if (open.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = open.FileName;
            }
        }
    }
}