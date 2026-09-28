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
        private string connectionString =
            @"Server=.;Database=MishiDB;Integrated Security=True;TrustServerCertificate=True;";

        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCompleto.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
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

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string checkQuery =
                        "SELECT COUNT(1) FROM Usuarios WHERE Correo = @correo";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.Add(
                            "@correo",
                            SqlDbType.NVarChar,
                            256
                        ).Value = correo;

                        int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(
                                "Este correo electrónico ya está registrado.",
                                "Cuenta existente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            txtCorreo.Focus();
                            return;
                        }
                    }

                    string query = @"
                        INSERT INTO Usuarios
                        (NombreCompleto, Correo, Contraseña)
                        VALUES
                        (@Nombre, @Correo, @Contraseña)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@Nombre",
                            SqlDbType.NVarChar,
                            100
                        ).Value = nombre;

                        cmd.Parameters.Add(
                            "@Correo",
                            SqlDbType.NVarChar,
                            256
                        ).Value = correo;

                        cmd.Parameters.Add(
                            "@Contraseña",
                            SqlDbType.NVarChar,
                            256
                        ).Value = contrasenaHash;

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show(
                                "¡Cuenta creada correctamente!\n\nAhora puedes iniciar sesión.",
                                "Bienvenido a Mishi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            FormLogin login = new FormLogin();
                            login.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al registrar el usuario:\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
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

        private void FormRegistro_Load(object sender, EventArgs e)
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
