using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Mishi_App_de_adopción
{
    public partial class FormRegistro : Form
    {
        private readonly string connectionString =
            @"Server=.;Database=MishiDB;Integrated Security=True;TrustServerCertificate=True;";

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreCompleto.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text;

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(nombreUsuario) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Por favor, completa todos los campos.",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar correo
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

            // Validar contraseña
            if (contrasena.Length < 6)
            {
                MessageBox.Show(
                    "La contraseña debe tener al menos 6 caracteres.",
                    "Contraseña muy corta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtContrasena.Focus();
                return;
            }

            string contrasenaHash = HashPassword(contrasena);

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Verificar si el correo ya existe
                    string checkQuery =
                        "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.Add(
                            "@Correo",
                            SqlDbType.NVarChar,
                            256
                        ).Value = correo;

                        int existe =
                            Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "Este correo ya tiene una cuenta.\n\nTe llevaré al inicio de sesión.",
                                "Cuenta existente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            AbrirLogin();
                            return;
                        }
                    }

                    // Crear el usuario
                    string query = @"
                        INSERT INTO Usuarios
                        (NombreCompleto, Correo, Contraseña)
                        VALUES
                        (@Nombre, @Correo, @Contrasena)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@Nombre",
                            SqlDbType.NVarChar,
                            100
                        ).Value = nombreUsuario;

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

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show(
                                "¡Cuenta creada correctamente!\n\nAhora inicia sesión.",
                                "Bienvenido a Mishi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            AbrirLogin();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se pudo crear la cuenta.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error de SQL Server:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Abrir Login sin cerrar toda la aplicación
        private void AbrirLogin()
        {
            FormLogin login = new FormLogin();

            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();

            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            AbrirLogin();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormBienvenida bienvenida = new FormBienvenida();

            bienvenida.StartPosition = FormStartPosition.CenterScreen;
            bienvenida.Show();

            this.Hide();
        }

        private void chkMostrarContrasena_CheckedChanged(
            object sender,
            EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar =
                !chkMostrarContrasena.Checked;
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
        }

        private static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return string.Empty;
            }

            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);

                return Convert.ToBase64String(hash);
            }
        }
    }
}