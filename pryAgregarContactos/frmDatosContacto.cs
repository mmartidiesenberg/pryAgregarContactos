using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgregarContactos
{
    public partial class frmDatosContacto : Form
    {
        public frmDatosContacto()
        {
            InitializeComponent();
        }

        private void lstListadoDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // declaracion variables
        string vContacto;
        string vNumeroTelefono;
        int vContador = 0;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumeroTelefono = txtNumero.Text;

            string vResultado = vContador + "----" + vContacto + "----" + vNumeroTelefono;
            lstListadoDatos.Items.Add(vResultado);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
