namespace Mishi_App_de_adopción
{
    partial class Formgato3
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnVolver = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8a6d2295008258fa649a2a0fc843aa6f_removebg_preview;
            pictureBox1.Location = new Point(101, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Humble boys demo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(471, 62);
            label1.Name = "label1";
            label1.Size = new Size(188, 90);
            label1.TabIndex = 1;
            label1.Text = "Luna\r\n\r\nHistorial Médico";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 192, 192);
            btnVolver.Location = new Point(357, 551);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 60);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(471, 165);
            button2.Name = "button2";
            button2.Size = new Size(340, 302);
            button2.TabIndex = 3;
            button2.Text = "VACUNAS\r\nVacunas                          Estatus\r\nVacunas influenden       Estatus\r\nVacunas Protetocidas    Estatus";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Humble boys demo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 86);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 4;
            label2.Text = "Ficha de Gato";
            // 
            // Formgato3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(836, 661);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Formgato3";
            Text = "Formgato3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnVolver;
        private Button button2;
        private Label label2;
    }
}