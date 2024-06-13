using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Poo_Puzle
{
    public partial class FrmNombre : Form
    {
        public string NombreJugador { get; private set; }
        public FrmNombre()
        {
            InitializeComponent();
        }

        private void FrmNombre_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            NombreJugador = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(NombreJugador))
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
