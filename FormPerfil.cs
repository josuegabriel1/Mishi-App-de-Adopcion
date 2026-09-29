using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mishi_App_de_adopción
{
    public partial class FormPerfil : Form
    {
        private readonly string connectionString =
            @"Server=.;Database=MishiDB;Integrated Security=True;TrustServerCertificate=True;";

        public FormPerfil()
        {
            InitializeComponent();
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            txtNombreCompletoPerfil.Text = SesionUsuario.NombreCompleto;
            txtCorreoPerfil.Text = SesionUsuario.Correo;
        }

        private void btnGuardarPerfil_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNombreCompletoPerfil.Text.Trim();
            string nuevoCorreo = txtCorreoPerfil.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoNombre) ||
                string.IsNullOrWhiteSpace(nuevoCorreo))
            {
                MessageBox.Show(
                    "Por favor, completa todos los campos.",
                    "Campos requeridos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!nuevoCorreo.Contains("@") || !nuevoCorreo.Contains("."))
            {
                MessageBox.Show(
                    "Ingresa un correo electrónico válido.",
                    "Correo inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCorreoPerfil.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                        UPDATE Usuarios
                        SET NombreCompleto = @Nombre,
                            Correo = @Correo
                        WHERE IdUsuario = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@Nombre",
                            SqlDbType.NVarChar,
                            100
                        ).Value = nuevoNombre;

                        cmd.Parameters.Add(
                            "@Correo",
                            SqlDbType.NVarChar,
                            256
                        ).Value = nuevoCorreo;

                        cmd.Parameters.Add(
                            "@Id",
                            SqlDbType.Int
                        ).Value = SesionUsuario.IdUsuario;

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            SesionUsuario.NombreCompleto = nuevoNombre;
                            SesionUsuario.Correo = nuevoCorreo;

                            MessageBox.Show(
                                "Perfil actualizado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se encontró el usuario para actualizar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error de SQL Server:\n\n" + ex.Message,
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el perfil:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}