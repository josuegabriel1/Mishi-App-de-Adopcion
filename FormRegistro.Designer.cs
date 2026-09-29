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
            lblIcono = new Label();
            label1 = new Label();
            lblSubtitulo = new Label();
            label2 = new Label();
            txtNombreCompleto = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtContrasena = new TextBox();
            chkMostrarContrasena = new CheckBox();
            btnRegistrar = new Button();
            lblCuenta = new Label();
            btnIniciarSesion = new Button();
            btnvolver = new Button();

            panelPrincipal.SuspendLayout();
            SuspendLayout();

            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(lblIcono);
            panelPrincipal.Controls.Add(label1);
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
            panelPrincipal.Location = new Point(140, 35);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(570, 610);
            panelPrincipal.TabIndex = 0;

            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font(
                "Segoe UI Emoji",
                30F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            lblIcono.Location = new Point(245, 18);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(78, 67);
            lblIcono.TabIndex = 0;
            lblIcono.Text = "🐱";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font(
                "Segoe UI",
                24F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            label1.ForeColor = Color.FromArgb(40, 40, 45);
            label1.Location = new Point(155, 80);
            label1.Name = "label1";
            label1.Size = new Size(258, 54);
            label1.TabIndex = 1;
            label1.Text = "Crear cuenta";

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
            lblSubtitulo.ForeColor = Color.FromArgb(100, 100, 105);
            lblSubtitulo.Location = new Point(122, 138);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(326, 23);
            lblSubtitulo.TabIndex = 2;
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
            label2.ForeColor = Color.FromArgb(55, 55, 60);
            label2.Location = new Point(100, 185);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 3;
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
            txtNombreCompleto.Location = new Point(100, 215);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.PlaceholderText = "Escribe tu nombre";
            txtNombreCompleto.Size = new Size(370, 32);
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
            label3.ForeColor = Color.FromArgb(55, 55, 60);
            label3.Location = new Point(100, 265);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 5;
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
            txtCorreo.Location = new Point(100, 295);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "ejemplo@correo.com";
            txtCorreo.Size = new Size(370, 32);
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
            label4.ForeColor = Color.FromArgb(55, 55, 60);
            label4.Location = new Point(100, 345);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 7;
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
            txtContrasena.Location = new Point(100, 375);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Mínimo 6 caracteres";
            txtContrasena.Size = new Size(370, 32);
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
            chkMostrarContrasena.ForeColor = Color.FromArgb(95, 95, 100);
            chkMostrarContrasena.Location = new Point(100, 418);
            chkMostrarContrasena.Name = "chkMostrarContrasena";
            chkMostrarContrasena.Size = new Size(170, 24);
            chkMostrarContrasena.TabIndex = 3;
            chkMostrarContrasena.Text = "Mostrar contraseña";
            chkMostrarContrasena.UseVisualStyleBackColor = true;
            chkMostrarContrasena.CheckedChanged +=
                chkMostrarContrasena_CheckedChanged;

            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(255, 105, 120);
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
            btnRegistrar.Location = new Point(100, 455);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(370, 50);
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
            lblCuenta.ForeColor = Color.FromArgb(100, 100, 105);
            lblCuenta.Location = new Point(188, 515);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(190, 20);
            lblCuenta.TabIndex = 11;
            lblCuenta.Text = "¿Ya tienes una cuenta?";

            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.White;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderColor =
                Color.FromArgb(255, 105, 120);
            btnIniciarSesion.FlatAppearance.BorderSize = 1;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font(
                "Segoe UI",
                9.5F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            btnIniciarSesion.ForeColor = Color.FromArgb(255, 105, 120);
            btnIniciarSesion.Location = new Point(100, 540);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(240, 42);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;

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
            btnvolver.ForeColor = Color.FromArgb(80, 80, 85);
            btnvolver.Location = new Point(350, 540);
            btnvolver.Name = "btnvolver";
            btnvolver.Size = new Size(120, 42);
            btnvolver.TabIndex = 6;
            btnvolver.Text = "← Volver";
            btnvolver.UseVisualStyleBackColor = false;
            btnvolver.Click += btnVolver_Click;

            // 
            // FormRegistro
            // 
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 247, 247);
            ClientSize = new Size(852, 650);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mishi - Crear cuenta";
            Load += FormRegistro_Load;

            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label lblIcono;
        private Label label1;
        private Label lblSubtitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombreCompleto;
        private TextBox txtCorreo;
        private TextBox txtContrasena;
        private CheckBox chkMostrarContrasena;
        private Button btnRegistrar;
        private Label lblCuenta;
        private Button btnIniciarSesion;
        private Button btnvolver;
    }
}