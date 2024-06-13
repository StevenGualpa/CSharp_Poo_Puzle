namespace CSharp_Poo_Puzle
{
    partial class Form1
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
            Lbl_Puntuacion = new Label();
            numupdow_filas = new NumericUpDown();
            numupdow_columnas = new NumericUpDown();
            dgv_puzlee = new DataGridView();
            dgvRanking = new DataGridView();
            btn_jugar = new Button();
            btnResultado = new Button();
            ((System.ComponentModel.ISupportInitialize)numupdow_filas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numupdow_columnas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_puzlee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 2);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 29);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // Lbl_Puntuacion
            // 
            Lbl_Puntuacion.AutoSize = true;
            Lbl_Puntuacion.Location = new Point(656, 49);
            Lbl_Puntuacion.Name = "Lbl_Puntuacion";
            Lbl_Puntuacion.Size = new Size(50, 20);
            Lbl_Puntuacion.TabIndex = 3;
            Lbl_Puntuacion.Text = "label4";
            // 
            // numupdow_filas
            // 
            numupdow_filas.Location = new Point(142, 2);
            numupdow_filas.Name = "numupdow_filas";
            numupdow_filas.Size = new Size(150, 27);
            numupdow_filas.TabIndex = 4;
            // 
            // numupdow_columnas
            // 
            numupdow_columnas.Location = new Point(380, 0);
            numupdow_columnas.Name = "numupdow_columnas";
            numupdow_columnas.Size = new Size(150, 27);
            numupdow_columnas.TabIndex = 5;
            // 
            // dgv_puzlee
            // 
            dgv_puzlee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_puzlee.Location = new Point(32, 113);
            dgv_puzlee.Name = "dgv_puzlee";
            dgv_puzlee.RowHeadersWidth = 51;
            dgv_puzlee.Size = new Size(300, 188);
            dgv_puzlee.TabIndex = 6;
            dgv_puzlee.KeyDown += dgv_puzlee_KeyDown;
            // 
            // dgvRanking
            // 
            dgvRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRanking.Location = new Point(451, 160);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.RowHeadersWidth = 51;
            dgvRanking.Size = new Size(300, 188);
            dgvRanking.TabIndex = 7;
            // 
            // btn_jugar
            // 
            btn_jugar.Location = new Point(483, 71);
            btn_jugar.Name = "btn_jugar";
            btn_jugar.Size = new Size(94, 29);
            btn_jugar.TabIndex = 8;
            btn_jugar.Text = "button1";
            btn_jugar.UseVisualStyleBackColor = true;
            btn_jugar.Click += btn_jugar_Click;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(656, 97);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(94, 29);
            btnResultado.TabIndex = 9;
            btnResultado.Text = "button1";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResultado);
            Controls.Add(btn_jugar);
            Controls.Add(dgvRanking);
            Controls.Add(dgv_puzlee);
            Controls.Add(numupdow_columnas);
            Controls.Add(numupdow_filas);
            Controls.Add(Lbl_Puntuacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numupdow_filas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numupdow_columnas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_puzlee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label Lbl_Puntuacion;
        private NumericUpDown numupdow_filas;
        private NumericUpDown numupdow_columnas;
        private DataGridView dgv_puzlee;
        private DataGridView dgvRanking;
        private Button btn_jugar;
        private Button btnResultado;
    }
}