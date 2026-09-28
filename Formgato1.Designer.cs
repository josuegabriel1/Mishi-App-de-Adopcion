namespace Mishi_App_de_adopción
{
    partial class Formgato1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgato1));
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Humble boys demo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 108);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 5;
            label2.Text = "Ficha de Gato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Humble boys demo", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(461, 83);
            label1.Name = "label1";
            label1.Size = new Size(207, 102);
            label1.TabIndex = 6;
            label1.Text = "Raúl\r\n\r\nHistoria Médica";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(461, 188);
            button1.Name = "button1";
            button1.Size = new Size(302, 263);
            button1.TabIndex = 7;
            button1.Text = "VACUNAS\r\n\r\nVacunas                     Estatus\r\nVacunas inflenden     Estatus\r\nProtetocidas              Estatus";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 192, 192);
            btnVolver.Location = new Point(334, 484);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(133, 70);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Formgato1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(822, 603);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Formgato1";
            Text = "Formgato1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private Button btnVolver;
        private PictureBox pictureBox1;
    }
}