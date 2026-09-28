using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Mishi_App_de_adopción
{
    public partial class FormLogin : Form
    {
        private readonly string connectionString =
            @"Server=.;Database=MishiDB;Integrated Security=True;TrustServerCertificate=True;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Ingresa el correo y la contraseña.",
                    "Datos requeridos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar formato básico de correo
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show(
                    "Ingresa un correo electrónico válido.",
                    "Correo inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCorreo.Focus();
                return;
            }

            // Convertir la contraseña al mismo SHA-256 usado en Registro
            string contrasenaHash = HashPassword(contrasena);

            string query = @"
                SELECT IdUsuario, NombreCompleto, Correo
                FROM Usuarios
                WHERE Correo = @Correo
                AND Contraseña = @Contrasena";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@Correo",
                            SqlDbType.NVarChar,
                            256
                        ).Value = correo;

                        cmd.Parameters.Add(
                            "@Contrasena",
                            SqlDbType.NVarChar,
                            256
                        ).Value = contrasenaHash;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Guardar datos del usuario conectado
                                SesionUsuario.IdUsuario =
                                    Convert.ToInt32(reader["IdUsuario"]);

                                SesionUsuario.NombreCompleto =
                                    reader["NombreCompleto"].ToString() ?? "";

                                SesionUsuario.Correo =
                                    reader["Correo"].ToString() ?? "";

                                MessageBox.Show(
                                    "¡Bienvenido de nuevo!",
                                    "Inicio de sesión correcto",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );

                                FormCatalogo catalogo = new FormCatalogo();
                                catalogo.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Correo o contraseña incorrectos.",
                                    "Error de autenticación",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                txtContrasena.Clear();
                                txtContrasena.Focus();
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
                        "Error al iniciar sesión:\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.Show();

            this.Hide();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();
            bienvenida.Show();

            this.Hide();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar =
                !chkMostrarContrasena.Checked;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }
    }
}