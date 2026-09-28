namespace Mishi_App_de_adopción
{
    partial class FormPerfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreCompletoPerfil = new TextBox();
            txtCorreoPerfil = new TextBox();
            btnGuardarPerfil = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Humble boys demo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 77);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 0;
            label1.Text = "Perfil Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 166);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 236);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // txtNombreCompletoPerfil
            // 
            txtNombreCompletoPerfil.Location = new Point(296, 163);
            txtNombreCompletoPerfil.Name = "txtNombreCompletoPerfil";
            txtNombreCompletoPerfil.Size = new Size(307, 27);
            txtNombreCompletoPerfil.TabIndex = 3;
            // 
            // txtCorreoPerfil
            // 
            txtCorreoPerfil.Location = new Point(296, 229);
            txtCorreoPerfil.Name = "txtCorreoPerfil";
            txtCorreoPerfil.Size = new Size(304, 27);
            txtCorreoPerfil.TabIndex = 4;
            // 
            // btnGuardarPerfil
            // 
            btnGuardarPerfil.BackColor = Color.FromArgb(255, 192, 192);
            btnGuardarPerfil.Location = new Point(347, 341);
            btnGuardarPerfil.Name = "btnGuardarPerfil";
            btnGuardarPerfil.Size = new Size(145, 57);
            btnGuardarPerfil.TabIndex = 5;
            btnGuardarPerfil.Text = "Guardar Cambios";
            btnGuardarPerfil.UseVisualStyleBackColor = false;
            btnGuardarPerfil.Click += btnGuardarPerfil_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 192, 192);
            btnVolver.Location = new Point(347, 416);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(145, 69);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
      
            // 
            // FormPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._8a6d2295008258fa649a2a0fc843aa6f_removebg_preview;
            ClientSize = new Size(827, 644);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardarPerfil);
            Controls.Add(txtCorreoPerfil);
            Controls.Add(txtNombreCompletoPerfil);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPerfil";
            Text = "FormPerfil";
            Load += FormPerfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreCompletoPerfil;
        private TextBox txtCorreoPerfil;
        private Button btnGuardarPerfil;
        private Button btnVolver;
    }
}