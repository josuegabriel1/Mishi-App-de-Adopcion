namespace Mishi_App_de_adopción
{
    partial class FormBuscar
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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            cmbFiltrarRazas = new ComboBox();
            btnVolver = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(66, 155);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(255, 192, 192);
            btnBuscar.Location = new Point(595, 140);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(165, 54);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbFiltrarRazas
            // 
            cmbFiltrarRazas.FormattingEnabled = true;
            cmbFiltrarRazas.Location = new Point(224, 154);
            cmbFiltrarRazas.Name = "cmbFiltrarRazas";
            cmbFiltrarRazas.Size = new Size(266, 28);
            cmbFiltrarRazas.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 192, 192);
            btnVolver.Location = new Point(336, 494);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(154, 74);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(106, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(600, 221);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Humble boys demo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 78);
            label1.Name = "label1";
            label1.Size = new Size(172, 30);
            label1.TabIndex = 5;
            label1.Text = "Buscar gatitos";
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(839, 614);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnVolver);
            Controls.Add(cmbFiltrarRazas);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Name = "FormBuscar";
            Text = "FormBuscar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnBuscar;
        private ComboBox cmbFiltrarRazas;
        private Button btnVolver;
        private DataGridView dataGridView1;
        private Label label1;
    }
}