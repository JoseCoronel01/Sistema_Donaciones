using System;
using System.Windows.Forms;
using System.Collections.Generic;
using PCL_Donaciones.str;
using PCL_Donaciones.dao;

namespace UI_Donaciones
{
    public partial class frmListadoVisitas : Form
    {
        strVisita str = new strVisita();
        private bool Check;

        public frmListadoVisitas()
        {
            InitializeComponent();
        }

        private void frmListadoVisitas_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            List<strVisita> lista = daoVisitas.GetAll();

            if (lista != null)
            {
                gvVisitas.DataSource = lista;
                gvVisitas.Columns["Donador"].Visible = false;
                gvVisitas.Columns["Donador_Vistante"].Visible = false;
                CargaInterfaz(0);
            }
            else
            {
                gvVisitas.DataSource = new List<strVisita>();
                lbDataDonador.Text = "";
                lbDataVisita.Text = "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmListadoVisitasCrud frm = new frmListadoVisitasCrud();
            frm.ModoEdicion = false;
            frm.Insert = true;
            frm.ShowDialog();
            if (!frm.Insert)
                CargarGrid();
            Check = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmListadoVisitasCrud frm = new frmListadoVisitasCrud();
            frm.ModoEdicion = true;
            frm.Insert = false;
            frm.Visita = str;
            frm.CargaCombo();
            frm.MostrarDatos();
            frm.ShowDialog();
            if (!frm.ModoEdicion)
                CargarGrid();
            Check = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Check)
                {
                    int delete = daoVisitas.Delete(str.Donador, str.Fecha);

                    if (delete > 0)
                    {
                        CargarGrid();
                        MessageBox.Show("Registro eliminado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No se ha seleccionado un usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarStr(strVisita str, int RowIndex)
        {
            str.Donador = int.Parse(gvVisitas.Rows[RowIndex].Cells["Donador"].Value.ToString());
            str.Donador_Vistante = (gvVisitas.Rows[RowIndex].Cells["Donador_Vistante"].Value != DBNull.Value) ? int.Parse(gvVisitas.Rows[RowIndex].Cells["Donador_Vistante"].Value.ToString()) : 0;
            str.Fecha = DateTime.Parse(gvVisitas.Rows[RowIndex].Cells["Fecha"].Value.ToString());
            str.Motivo = gvVisitas.Rows[RowIndex].Cells["Motivo"].Value.ToString();
            str.Observaciones = gvVisitas.Rows[RowIndex].Cells["Observaciones"].Value.ToString();
        }

        private void gvVisitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaInterfaz(e.RowIndex);
        }

        private void CargaInterfaz(int RowIndex)
        {
            CargarStr(str, RowIndex);

            Check = true;

            lbDataDonador.Text = daoDonadores.GetObject(str.Donador).ToString();

            lbDataVisita.Text = daoDonadores.GetObject((int)str.Donador_Vistante).ToString();
        }
    }
}