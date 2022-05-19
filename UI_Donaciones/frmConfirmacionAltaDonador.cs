using PCL_Donaciones.str;
using PCL_Donaciones.dao;
using PCL_Comun.Utilidades;
using PCL_Donaciones.BusinessRules;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Donaciones
{
    public partial class frmConfirmacionAltaDonador : Form
    {
        private strBuscador strBuscador = new strBuscador();

        private strGeneraMatricula strGeneraMatricula = new strGeneraMatricula();

        private List<strDonador> lista2 = null;

        public strDonador Donador { get; set; }

        public bool Salir { get; set; }

        public frmConfirmacionAltaDonador()
        {
            InitializeComponent();
        }

        private void frmConfirmacionAltaDonador_Load(object sender, EventArgs e)
        {
            this.Salir = false;

            lista2 = daoDonadores.GetAll();

            if (Donador.TipoDonador == "LID")
            {
                txtBuscar.ReadOnly = true;

                cbDonador.Enabled = false;

                txtMatricula.Text = strGeneraMatricula.CrearMatricula(Donador);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (lista2 == null) return;

            List<ElementoComboBox> elem = strBuscador.Busqueda(lista2, txtBuscar.Text);

            cbDonador.DataSource = elem;
        }

        private void cbDonador_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMatricula.Text = strGeneraMatricula.CrearMatricula(Donador, ((ElementoComboBox)cbDonador.SelectedItem).value.ToString());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (daoDonadores.GetObject(Donador.Curp) == null)
            {
                Donador.Matricula = txtMatricula.Text;

                int save = daoDonadores.Insert(Donador);

                if (save > 0)
                {
                    if (Donador.TipoDonador != "LID")
                    {
                        strRelacion_Donador str = new strRelacion_Donador();

                        str.Donador_Padre = int.Parse(cbDonador.SelectedValue.ToString());

                        str.Donador_Hijo = Donador.Id;

                        daoRelacion_Donadores.Insert(str);
                    }

                    MessageBox.Show("Donador agregado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Salir = true;

                    this.Close();
                }
                else
                    MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("La curp ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}