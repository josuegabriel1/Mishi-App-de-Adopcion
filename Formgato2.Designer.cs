namespace Mishi_App_de_adopción
{
    partial class Formgato2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgato2));
            button1 = new Button();
            btnVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(453, 169);
            button1.Name = "button1";
            button1.Size = new Size(302, 263);
            button1.TabIndex = 0;
            button1.Text = "VACUNAS\r\n\r\nVacunas                     Estatus\r\nVacunas inflenden     Estatus\r\nProtetocidas              Estatus";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 192, 192);
            btnVolver.Location = new Point(352, 491);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(135, 69);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Humble boys demo", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(453, 64);
            label1.Name = "label1";
            label1.Size = new Size(212, 102);
            label1.TabIndex = 3;
            label1.Text = "Capuchino\r\n\r\nHistorial Médico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Humble boys demo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 88);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 4;
            label2.Text = "Ficha de Gato";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(111, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(308, 281);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Formgato2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(821, 621);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(button1);
            Name = "Formgato2";
            Text = "Formgato2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnVolver;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}