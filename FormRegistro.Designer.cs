namespace Mishi_App_de_adopción
{
    partial class FormRegistro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            label2 = new Label();
            txtNombreCompleto = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtContrasena = new TextBox();
            chkMostrarContrasena = new CheckBox();
            btnRegistrar = new Button();
            btnIniciarSesion = new Button();
            btnvolver = new Button();
            lblCuenta = new Label();

            panelPrincipal.SuspendLayout();
            SuspendLayout();

            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Controls.Add(lblSubtitulo);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(txtNombreCompleto);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(txtCorreo);
            panelPrincipal.Controls.Add(label4);
            panelPrincipal.Controls.Add(txtContrasena);
            panelPrincipal.Controls.Add(chkMostrarContrasena);
            panelPrincipal.Controls.Add(btnRegistrar);
            panelPrincipal.Controls.Add(lblCuenta);
            panelPrincipal.Controls.Add(btnIniciarSesion);
            panelPrincipal.Controls.Add(btnvolver);
            panelPrincipal.Location = new Point(145, 40);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(560, 570);
            panelPrincipal.TabIndex = 0;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font(
                "Segoe UI",
                24F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            lblTitulo.ForeColor = Color.FromArgb(45, 45, 45);
            lblTitulo.Location = new Point(151, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crear cuenta";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            lblSubtitulo.ForeColor = Color.FromArgb(110, 110, 110);
            lblSubtitulo.Location = new Point(111, 85);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(337, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Únete a Mishi y encuentra a tu compañero";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            label2.ForeColor = Color.FromArgb(60, 60, 60);
            label2.Location = new Point(100, 135);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre completo";

            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            txtNombreCompleto.Location = new Point(100, 165);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.PlaceholderText = "Ingresa tu nombre";
            txtNombreCompleto.Size = new Size(360, 32);
            txtNombreCompleto.TabIndex = 0;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            label3.ForeColor = Color.FromArgb(60, 60, 60);
            label3.Location = new Point(100, 215);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 4;
            label3.Text = "Correo electrónico";

            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            txtCorreo.Location = new Point(100, 245);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "ejemplo@correo.com";
            txtCorreo.Size = new Size(360, 32);
            txtCorreo.TabIndex = 1;

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            label4.ForeColor = Color.FromArgb(60, 60, 60);
            label4.Location = new Point(100, 295);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";

            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            txtContrasena.Location = new Point(100, 325);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText =
                "Mínimo 6 caracteres";
            txtContrasena.Size = new Size(360, 32);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;

            // 
            // chkMostrarContrasena
            // 
            chkMostrarContrasena.AutoSize = true;
            chkMostrarContrasena.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            chkMostrarContrasena.ForeColor =
                Color.FromArgb(90, 90, 90);
            chkMostrarContrasena.Location =
                new Point(100, 370);
            chkMostrarContrasena.Name =
                "chkMostrarContrasena";
            chkMostrarContrasena.Size =
                new Size(170, 24);
            chkMostrarContrasena.TabIndex = 3;
            chkMostrarContrasena.Text =
                "Mostrar contraseña";
            chkMostrarContrasena.UseVisualStyleBackColor =
                true;
            chkMostrarContrasena.CheckedChanged +=
                chkMostrarContrasena_CheckedChanged;

            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor =
                Color.FromArgb(255, 120, 130);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(100, 410);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(360, 52);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "CREAR MI CUENTA";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;

            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            lblCuenta.ForeColor = Color.FromArgb(100, 100, 100);
            lblCuenta.Location = new Point(187, 475);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(187, 20);
            lblCuenta.TabIndex = 10;
            lblCuenta.Text = "¿Ya tienes una cuenta?";

            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.White;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderColor =
                Color.FromArgb(255, 120, 130);
            btnIniciarSesion.FlatAppearance.BorderSize = 1;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font(
                "Segoe UI",
                9.5F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            btnIniciarSesion.ForeColor =
                Color.FromArgb(255, 100, 115);
            btnIniciarSesion.Location =
                new Point(100, 505);
            btnIniciarSesion.Name =
                "btnIniciarSesion";
            btnIniciarSesion.Size =
                new Size(235, 42);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text =
                "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor =
                false;
            btnIniciarSesion.Click +=
                btnIniciarSesion_Click;

            // 
            // btnvolver
            // 
            btnvolver.BackColor = Color.White;
            btnvolver.Cursor = Cursors.Hand;
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.Font = new Font(
                "Segoe UI",
                9.5F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            btnvolver.ForeColor =
                Color.FromArgb(90, 90, 90);
            btnvolver.Location =
                new Point(345, 505);
            btnvolver.Name = "btnvolver";
            btnvolver.Size =
                new Size(115, 42);
            btnvolver.TabIndex = 6;
            btnvolver.Text = "← Volver";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnVolver_Click;

            // 
            // FormRegistro
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions =
                new SizeF(8F, 20F);
            AutoScaleMode =
                AutoScaleMode.Font;
            BackColor =
                Color.FromArgb(235, 247, 247);
            ClientSize =
                new Size(852, 650);
            Controls.Add(panelPrincipal);
            FormBorderStyle =
                FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRegistro";
            StartPosition =
                FormStartPosition.CenterScreen;
            Text = "Mishi - Crear cuenta";
            Load += FormRegistro_Load;

            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreCompleto;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private CheckBox chkMostrarContrasena;
        private Button btnRegistrar;
        private Button btnIniciarSesion;
        private Button btnvolver;
        private Label lblCuenta;
    }
}