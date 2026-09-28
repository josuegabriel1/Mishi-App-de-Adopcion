namespace Mishi_App_de_adopción
{
    partial class FormBienvenida
    {
        /// <summary>
        /// Variable requerida por el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">
        /// true si los recursos administrados deben ser eliminados;
        /// de lo contrario, false.
        /// </param>
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
            label1 = new Label();
            lblSubtitulo = new Label();
            pictureBox1 = new PictureBox();
            btnIniciarSesion = new Button();
            btnCrearCuenta = new Button();
            lblPie = new Label();

            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.White;
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(lblSubtitulo);
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(btnIniciarSesion);
            panelPrincipal.Controls.Add(btnCrearCuenta);
            panelPrincipal.Controls.Add(lblPie);
            panelPrincipal.Location = new Point(131, 50);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(555, 540);
            panelPrincipal.TabIndex = 0;

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
            label1.ForeColor = Color.FromArgb(45, 45, 45);
            label1.Location = new Point(96, 25);
            label1.Name = "label1";
            label1.Size = new Size(363, 54);
            label1.TabIndex = 0;
            label1.Text = "¡Bienvenido a Mishi!";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular,
                GraphicsUnit.Point
            );
            lblSubtitulo.ForeColor = Color.FromArgb(100, 100, 100);
            lblSubtitulo.Location = new Point(108, 88);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(339, 25);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Encuentra un hogar para cada michi";

            // 
            // pictureBox1
            // 
            pictureBox1.Image =
                Properties.Resources._8a6d2295008258fa649a2a0fc843aa6f_removebg_preview;

            pictureBox1.Location = new Point(140, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;

            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(255, 120, 130);
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
            btnIniciarSesion.Location = new Point(110, 365);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(335, 55);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;

            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.White;
            btnCrearCuenta.Cursor = Cursors.Hand;
            btnCrearCuenta.FlatAppearance.BorderColor =
                Color.FromArgb(255, 120, 130);
            btnCrearCuenta.FlatAppearance.BorderSize = 2;
            btnCrearCuenta.FlatStyle = FlatStyle.Flat;
            btnCrearCuenta.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Bold,
                GraphicsUnit.Point
            );
            btnCrearCuenta.ForeColor = Color.FromArgb(255, 100, 115);
            btnCrearCuenta.Location = new Point(110, 435);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(335, 55);
            btnCrearCuenta.TabIndex = 4;
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
            lblPie.ForeColor = Color.FromArgb(130, 130, 130);
            lblPie.Location = new Point(166, 505);
            lblPie.Name = "lblPie";
            lblPie.Size = new Size(223, 20);
            lblPie.TabIndex = 5;
            lblPie.Text = "Adopta, cuida y cambia una vida";

            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 247, 247);
            ClientSize = new Size(817, 640);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mishi - Bienvenida";

            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label label1;
        private Label lblSubtitulo;
        private PictureBox pictureBox1;
        private Button btnIniciarSesion;
        private Button btnCrearCuenta;
        private Label lblPie;
    }
}