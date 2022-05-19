using System;
using System.Windows.Forms;
using System.Collections.Generic;
using PCL_Comun.Utilidades;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;
using PCL_Donaciones.BusinessRules;

namespace UI_Donaciones
{
    public partial class frmHistPorDonador : Form
    {
        strBuscador strBuscador = new strBuscador();

        List<strDonador> donadors = null;

        public frmHistPorDonador()
        {
            InitializeComponent();
        }

        private void btnPreliminar_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (cbDonador.SelectedValue == null)
            {
                MessageBox.Show("No ha seleccionado al donador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuscar.Focus();
                return;
            }
            bool si = int.TryParse(cbDonador.SelectedValue.ToString(), out id);
            if (si)
            {
                frmReportes frm = new frmReportes("HistorialPorDonador", id);
                frm.Show();
            }
            else
                MessageBox.Show("No ha seleccionado al donador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmHistPorDonador_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            donadors = daoDonadores.GetAll();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            List<ElementoComboBox> list = strBuscador.Busqueda(donadors, txtBuscar.Text);
            cbDonador.DataSource = list;
        }
    }
}