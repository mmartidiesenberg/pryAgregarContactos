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
        //variables globales
        string vContacto = "";
        string vNumeroTelefono = "";
        int vContador;
        int indice = 0;

        // arrays   -   vectores
        string[] vecContacto = new string[4];
        string[] vecNumeroTelefono = new string[4];

        public frmDatosContacto()
        {
            InitializeComponent();
        }

        private void lstListadoDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumeroTelefono = txtNumero.Text;
            vContador++;

            string vResultado = vContador + "----" + vContacto + "----" + vNumeroTelefono;
            lstListadoDatos.Items.Add(vResultado);

            vecContacto[indice] = vContacto;
            vecNumeroTelefono[indice] = vNumeroTelefono;
            indice++;
            txtContacto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmDatosContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
