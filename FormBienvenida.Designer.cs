namespace Mishi_App_de_adopción
{
    partial class FormBienvenida
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
            lblDescripcion = new Label();
            btnIniciarSesion = new Button();
            btnCrearCuenta = new Button();
            lblPie = new Label();

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
            panelPrincipal.Controls.Add(lblDescripcion);
            panelPrincipal.Controls.Add(btnIniciarSesion);
            panelPrincipal.Controls.Add(btnCrearCuenta);
            panelPrincipal.Controls.Add(lblPie);
            panelPrincipal.Location = new Point(125, 55);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(565, 520);
            panelPrincipal.TabIndex = 0;

            // 
            // lblIcono
            // 
            lblIcono.AutoSize = true;
            lblIcono.Font = new Font(
                "Segoe UI Emoji",
                42F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            lblIcono.Location = new Point(230, 35);
            lblIcono.Name = "lblIcono";
            lblIcono.Size = new Size(101, 75);
            lblIcono.TabIndex = 0;
            lblIcono.Text = "🐱";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font(
                "Segoe UI",
                25F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            label1.ForeColor = Color.FromArgb(40, 40, 45);
            label1.Location = new Point(112, 120);
            label1.Name = "label1";
            label1.Size = new Size(340, 57);
            label1.TabIndex = 1;
            label1.Text = "¡Bienvenido a Mishi!";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font(
                "Segoe UI",
                13F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            lblSubtitulo.ForeColor = Color.FromArgb(255, 105, 120);
            lblSubtitulo.Location = new Point(208, 185);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(148, 30);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "ADOPTA AMOR";

            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font(
                "Segoe UI",
                10.5F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            lblDescripcion.ForeColor = Color.FromArgb(100, 100, 105);
            lblDescripcion.Location = new Point(75, 225);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(415, 70);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text =
                "Encuentra a tu nuevo compañero y dale\n" +
                "un hogar lleno de cariño, cuidado y felicidad.";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(255, 105, 120);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(100, 320);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(365, 58);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;

            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.White;
            btnCrearCuenta.Cursor = Cursors.Hand;
            btnCrearCuenta.FlatAppearance.BorderColor =
                Color.FromArgb(255, 105, 120);
            btnCrearCuenta.FlatAppearance.BorderSize = 2;
            btnCrearCuenta.FlatStyle = FlatStyle.Flat;
            btnCrearCuenta.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            btnCrearCuenta.ForeColor = Color.FromArgb(255, 105, 120);
            btnCrearCuenta.Location = new Point(100, 395);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(365, 58);
            btnCrearCuenta.TabIndex = 5;
            btnCrearCuenta.Text = "CREAR CUENTA";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += BtnCrearCuenta_Click;

            // 
            // lblPie
            // 
            lblPie.AutoSize = true;
            lblPie.Font = new Font(
                "Segoe UI",
                8.5F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            lblPie.ForeColor = Color.FromArgb(145, 145, 150);
            lblPie.Location = new Point(160, 480);
            lblPie.Name = "lblPie";
            lblPie.Size = new Size(245, 20);
            lblPie.TabIndex = 6;
            lblPie.Text = "Adopta • Cuida • Comparte • Ama";

            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 247, 247);
            ClientSize = new Size(817, 640);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mishi - Bienvenida";

            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label lblIcono;
        private Label label1;
        private Label lblSubtitulo;
        private Label lblDescripcion;
        private Button btnIniciarSesion;
        private Button btnCrearCuenta;
        private Label lblPie;
    }
}