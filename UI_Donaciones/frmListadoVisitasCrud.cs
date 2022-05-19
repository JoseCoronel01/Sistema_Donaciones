using PCL_Donaciones.str;
using PCL_Donaciones.dao;
using PCL_Comun.Utilidades;
using PCL_Donaciones.BusinessRules;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace UI_Donaciones
{
    public partial class frmListadoVisitasCrud : Form
    {
        strBRVisitas strBRVisitas = new strBRVisitas();

        public bool ModoEdicion { get; set; }
        public bool Insert { get; set; }
        public strVisita Visita { get; set; }

        public frmListadoVisitasCrud()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            cbDonador.SelectedValue = Visita.Donador;
            cbVisita.SelectedValue = Visita.Donador_Vistante;
            if (Visita.Fecha.Date > DateTime.MinValue)
                dtpFecha.Value = Visita.Fecha.Date;
            dtpHora.Text = Visita.Fecha.ToShortTimeString();
            txtMotivo.Text = Visita.Motivo;
            txtObservaciones.Text = Visita.Observaciones;
        }

        public void CargaCombo()
        {
            cbDonador.DataSource = strBRVisitas.DonadoresPadre();
        }

        private void frmListadoVisitasCrud_Load(object sender, EventArgs e)
        {
            CargaCombo();

            if (this.Visita != null)
                MostrarDatos();
        }

        private void cbDonador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDonador.SelectedIndex > -1)
            {
                int id = int.Parse(cbDonador.SelectedValue.ToString());

                var obj = daoDonadores.GetObject(id);

                if (obj == null) return;

                switch (obj.TipoDonador)
                {
                    case "LID":
                        {
                            cbVisita.DataSource = strBRVisitas.DonadoresHijos(id, "ARC");
                            break;
                        }
                    case "ARC":
                        {
                            cbVisita.DataSource = strBRVisitas.DonadoresHijos(id, "ANG");
                            break;
                        }
                    case "ANG":
                        {
                            cbVisita.DataSource = new List<ElementoComboBox>();
                            break;
                        }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbDonador.SelectedIndex > -1 && cbVisita.SelectedIndex > -1 && dtpFecha.Value != null && 
                txtMotivo.Text != "" && txtObservaciones.Text != "")
            {
                if (this.Insert)
                {
                    this.Visita = CargaObjeto(this.Visita);

                    int save = daoVisitas.Insert(this.Visita);

                    if (save > 0)
                    {
                        this.Insert = false;
                        MessageBox.Show("Visita registrada correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.ModoEdicion)
                {
                    this.Visita = CargaObjeto(this.Visita);

                    int save = daoVisitas.Update(this.Visita);

                    if (save > 0)
                    {
                        this.ModoEdicion = false;
                        MessageBox.Show("Visita modificada correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Error! la fecha y hora no se modifica", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Hay campos vacíos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private strVisita CargaObjeto(strVisita visita)
        {
            visita = new strVisita();
            visita.Donador = int.Parse(cbDonador.SelectedValue.ToString());
            visita.Donador_Vistante = (cbVisita.SelectedValue.ToString() != "") ? int.Parse(cbVisita.SelectedValue.ToString()) : 0;
            visita.Fecha = ObtenerFechaHora();
            visita.Motivo = txtMotivo.Text;
            visita.Observaciones = txtObservaciones.Text;
            return visita;
        }

        private DateTime ObtenerFechaHora()
        {
            return new DateTime(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day, 
                dtpHora.Value.Hour, dtpHora.Value.Minute, dtpHora.Value.Second);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}