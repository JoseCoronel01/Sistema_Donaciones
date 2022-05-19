using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PCL_Donaciones.dao;
using PCL_Donaciones.str;
using PCL_Donaciones.BusinessRules;
using System.Drawing;

namespace UI_Donaciones
{
    public partial class frmDonaciones : Form
    {
        strBuscador buscador = new strBuscador();

        List<strGridDonador> lista = new List<strGridDonador>();

        strGridDonador gridDonador = new strGridDonador();

        private int Id = 0;

        public frmDonaciones()
        {
            InitializeComponent();
        }

        private void frmDonaciones_Load(object sender, EventArgs e)
        {
            lista = gridDonador.GetGridList();

            gvDonadores.DataSource = lista;

            txtBuscar.Focus();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            gvDonadores.DataSource = buscador.BusquedaStrDonador(lista, txtBuscar.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool error = true;

            if (txtImporte.Text != "" && gvDonadores.SelectedRows.Count > 0)
            {
                if (decimal.Parse(txtImporte.Text) > 0)
                {
                    error = false;

                    strDonacion str = new strDonacion();

                    str.Donador = this.Id;

                    str.Fecha = dtpFecha.Value;

                    str.Monto = decimal.Parse(txtImporte.Text);

                    int save = daoDonaciones.Insert(str);

                    if (save > 0)
                        MessageBox.Show("Donación registrada correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (error)
                MessageBox.Show("Importe no es correcto o no se selecciono un donador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gboxCaja_Enter(object sender, EventArgs e)
        {
            gboxCaja.BackColor = Color.LightCyan;
        }

        private void gboxCaja_Leave(object sender, EventArgs e)
        {
            gboxCaja.BackColor = Color.Transparent;
        }

        private void gvDonadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Id = int.Parse(gvDonadores.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            var obj = daoDonadores.GetObject(this.Id);

            txtImporte.Text = obj.Importe.ToString();

            if (txtImporte.Text != "")
            {
                txtImporte.Focus();
            }
        }
    }
}