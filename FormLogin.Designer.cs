namespace Mishi_App_de_adopción
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();

            txtCorreo = new TextBox();
            txtContrasena = new TextBox();

            chkMostrarContrasena = new CheckBox();

            btnIngresar = new Button();
            btnRegistro = new Button();
            btnvolver = new Button();

            SuspendLayout();

            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font(
                "Segoe UI",
                24F,
                FontStyle.Bold
            );
            label1.ForeColor = Color.FromArgb(40, 40, 45);
            label1.Location = new Point(285, 80);
            label1.Name = "label1";
            label1.Size = new Size(276, 54);
            label1.Text = "Iniciar sesión";

            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );
            label2.ForeColor = Color.FromArgb(55, 55, 60);
            label2.Location = new Point(245, 180);
            label2.Name = "label2";
            label2.Size = new Size(163, 23);
            label2.Text = "Correo electrónico";

            //
            // txtCorreo
            //
            txtCorreo.Font = new Font(
                "Segoe UI",
                11F
            );
            txtCorreo.Location = new Point(245, 210);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "ejemplo@correo.com";
            txtCorreo.Size = new Size(355, 32);
            txtCorreo.TabIndex = 0;

            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );
            label3.ForeColor = Color.FromArgb(55, 55, 60);
            label3.Location = new Point(245, 270);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.Text = "Contraseña";

            //
            // txtContrasena
            //
            txtContrasena.Font = new Font(
                "Segoe UI",
                11F
            );
            txtContrasena.Location = new Point(245, 300);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText =
                "Escribe tu contraseña";
            txtContrasena.Size = new Size(355, 32);
            txtContrasena.TabIndex = 1;
            txtContrasena.UseSystemPasswordChar = true;

            //
            // chkMostrarContrasena
            //
            chkMostrarContrasena.AutoSize = true;
            chkMostrarContrasena.Font = new Font(
                "Segoe UI",
                9F
            );
            chkMostrarContrasena.ForeColor =
                Color.FromArgb(90, 90, 95);
            chkMostrarContrasena.Location =
                new Point(245, 345);
            chkMostrarContrasena.Name =
                "chkMostrarContrasena";
            chkMostrarContrasena.Size =
                new Size(170, 24);
            chkMostrarContrasena.TabIndex = 2;
            chkMostrarContrasena.Text =
                "Mostrar contraseña";
            chkMostrarContrasena.UseVisualStyleBackColor =
                true;

            chkMostrarContrasena.CheckedChanged +=
                chkMostrarContrasena_CheckedChanged;

            //
            // btnIngresar
            //
            btnIngresar.BackColor =
                Color.FromArgb(255, 105, 120);
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold
            );
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location =
                new Point(245, 400);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size =
                new Size(355, 55);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "INICIAR SESIÓN";
            btnIngresar.UseVisualStyleBackColor = false;

            btnIngresar.Click +=
                BtnIngresar_Click;

            //
            // btnRegistro
            //
            btnRegistro.BackColor = Color.White;
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatAppearance.BorderColor =
                Color.FromArgb(255, 105, 120);
            btnRegistro.FlatAppearance.BorderSize = 2;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold
            );
            btnRegistro.ForeColor =
                Color.FromArgb(255, 105, 120);
            btnRegistro.Location =
                new Point(245, 485);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size =
                new Size(355, 50);
            btnRegistro.TabIndex = 4;
            btnRegistro.Text =
                "CREAR UNA CUENTA";
            btnRegistro.UseVisualStyleBackColor = false;

            btnRegistro.Click +=
                BtnRegistro_Click;

            //
            // btnvolver
            //
            btnvolver.BackColor = Color.Transparent;
            btnvolver.Cursor = Cursors.Hand;
            btnvolver.FlatAppearance.BorderSize = 0;
            btnvolver.FlatStyle = FlatStyle.Flat;
            btnvolver.Font = new Font(
                "Segoe UI",
                10F
            );
            btnvolver.ForeColor =
                Color.FromArgb(80, 80, 85);
            btnvolver.Location =
                new Point(335, 565);
            btnvolver.Name = "btnvolver";
            btnvolver.Size =
                new Size(175, 45);
            btnvolver.TabIndex = 5;
            btnvolver.Text = "← Volver";
            btnvolver.UseVisualStyleBackColor = false;

            btnvolver.Click +=
                BtnVolver_Click;

            //
            // FormLogin
            //
            AcceptButton = btnIngresar;

            AutoScaleDimensions =
                new SizeF(8F, 20F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(234, 247, 247);

            ClientSize =
                new Size(846, 680);

            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label3);
            Controls.Add(txtContrasena);
            Controls.Add(chkMostrarContrasena);
            Controls.Add(btnIngresar);
            Controls.Add(btnRegistro);
            Controls.Add(btnvolver);

            FormBorderStyle =
                FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            Name = "FormLogin";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text = "Mishi - Iniciar sesión";

            Load += FormLogin_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;

        private TextBox txtCorreo;
        private TextBox txtContrasena;

        private CheckBox chkMostrarContrasena;

        private Button btnIngresar;
        private Button btnRegistro;
        private Button btnvolver;
    }
}