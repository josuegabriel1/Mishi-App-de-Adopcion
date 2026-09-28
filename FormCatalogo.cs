using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mishi_App_de_adopción
{
    public partial class FormCatalogo : Form
    {
        private string connectionString = @"Server=.\SQLEXPRESS;Database=MishiDB;Integrated Security=True;TrustServerCertificate=True;";
        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
            CargarGatosDesdeBD();
        }

        private void CargarGatosDesdeBD()
        {
            string query = @"SELECT G.id_gato, G.Nombre, G.Edad, R.Nombre AS NombreRaza
                             FROM Gatos G
                             LEFT JOIN Raza R ON G.id_raza = R.id_raza
                             WHERE G.Estado = 'En adopción'";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using SqlDataReader reader = cmd.ExecuteReader();

                    int ordId = reader.GetOrdinal("id_gato");
                    int ordNombre = reader.GetOrdinal("Nombre");
                    int ordEdad = reader.GetOrdinal("Edad");
                    int ordRaza = reader.GetOrdinal("NombreRaza");

                    while (reader.Read())
                    {
                        int id = !reader.IsDBNull(ordId) ? reader.GetInt32(ordId) : 0;
                        string nombre = !reader.IsDBNull(ordNombre) ? reader.GetString(ordNombre) : string.Empty;

                        // Si Edad es numérica en la BD:
                        int? edad = !reader.IsDBNull(ordEdad) ? reader.GetInt32(ordEdad) : (int?)null;
                        string edadStr = edad.HasValue ? edad.Value.ToString() : string.Empty;

                        // Si Edad fuera cadena, usar:
                        // string edadStr = !reader.IsDBNull(ordEdad) ? reader.GetString(ordEdad) : string.Empty;

                        string raza = !reader.IsDBNull(ordRaza) ? reader.GetString(ordRaza) : string.Empty;

                        // Aquí mostrar o añadir los datos a controles del formulario
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con MishiDB: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();
            this.Hide();
        }
    }
}
