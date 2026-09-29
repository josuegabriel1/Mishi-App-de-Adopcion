using System;
using System.Windows.Forms;

namespace Mishi_App_de_adopción
{
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
            // Por ahora no cargamos gatos desde SQL Server.
            // Así evitamos el error mientras no exista la tabla Gatos.
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();

            bienvenida.StartPosition = FormStartPosition.CenterScreen;
            bienvenida.Show();

            this.Hide();
        }
    }
}