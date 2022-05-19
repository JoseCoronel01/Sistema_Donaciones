using System;
using System.Windows.Forms;
using PCL_Donaciones.dao;

namespace UI_Donaciones
{
    public partial class frmSelecEstado : Form
    {
        public string Clave { get; set; }

        public frmSelecEstado()
        {
            InitializeComponent();
        }

        private void frmSelecEstado_Load(object sender, EventArgs e)
        {
            cbEstados.DataSource = daoEstados.GetAll();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbEstados.SelectedValue != null)
            {
                this.Clave = cbEstados.SelectedValue.ToString();
            }
            this.Close();
        }
    }
}