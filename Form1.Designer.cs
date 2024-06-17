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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label3 = new Label();
            Lbl_Puntuacion = new Label();
            numupdow_filas = new NumericUpDown();
            dgv_puzlee = new DataGridView();
            dgvRanking = new DataGridView();
            btn_jugar = new Button();
            btnResultado = new Button();
            Btn_Ranking = new Button();
            ((System.ComponentModel.ISupportInitialize)numupdow_filas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_puzlee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Tamaño:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(540, 20);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 2;
            label3.Text = "Puntuacion:";
            label3.Click += label3_Click;
            // 
            // Lbl_Puntuacion
            // 
            Lbl_Puntuacion.AutoSize = true;
            Lbl_Puntuacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Puntuacion.Location = new Point(634, 20);
            Lbl_Puntuacion.Name = "Lbl_Puntuacion";
            Lbl_Puntuacion.Size = new Size(12, 17);
            Lbl_Puntuacion.TabIndex = 3;
            Lbl_Puntuacion.Text = " ";
            // 
            // numupdow_filas
            // 
            numupdow_filas.Location = new Point(109, 20);
            numupdow_filas.Margin = new Padding(3, 2, 3, 2);
            numupdow_filas.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numupdow_filas.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            numupdow_filas.Name = "numupdow_filas";
            numupdow_filas.ReadOnly = true;
            numupdow_filas.Size = new Size(75, 23);
            numupdow_filas.TabIndex = 4;
            numupdow_filas.Value = new decimal(new int[] { 4, 0, 0, 0 });
            numupdow_filas.ValueChanged += numupdow_filas_ValueChanged;
            // 
            // dgv_puzlee
            // 
            dgv_puzlee.BackgroundColor = Color.WhiteSmoke;
            dgv_puzlee.BorderStyle = BorderStyle.None;
            dgv_puzlee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_puzlee.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_puzlee.Location = new Point(42, 81);
            dgv_puzlee.Margin = new Padding(3, 2, 3, 2);
            dgv_puzlee.Name = "dgv_puzlee";
            dgv_puzlee.ReadOnly = true;
            dgv_puzlee.RowHeadersWidth = 51;
            dgv_puzlee.Size = new Size(262, 141);
            dgv_puzlee.TabIndex = 6;
            dgv_puzlee.CellContentClick += dgv_puzlee_CellContentClick;
            dgv_puzlee.KeyDown += dgv_puzlee_KeyDown;
            // 
            // dgvRanking
            // 
            dgvRanking.BackgroundColor = Color.WhiteSmoke;
            dgvRanking.BorderStyle = BorderStyle.None;
            dgvRanking.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRanking.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRanking.EnableHeadersVisualStyles = false;
            dgvRanking.GridColor = Color.Teal;
            dgvRanking.Location = new Point(546, 120);
            dgvRanking.Margin = new Padding(3, 2, 3, 2);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.ReadOnly = true;
            dgvRanking.RowHeadersVisible = false;
            dgvRanking.RowHeadersWidth = 51;
            dgvRanking.Size = new Size(264, 187);
            dgvRanking.TabIndex = 7;
            // 
            // btn_jugar
            // 
            btn_jugar.BackColor = Color.Teal;
            btn_jugar.FlatStyle = FlatStyle.Flat;
            btn_jugar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_jugar.ForeColor = SystemColors.Window;
            btn_jugar.Location = new Point(540, 68);
            btn_jugar.Margin = new Padding(3, 2, 3, 2);
            btn_jugar.Name = "btn_jugar";
            btn_jugar.Size = new Size(92, 32);
            btn_jugar.TabIndex = 8;
            btn_jugar.Text = "Jugar";
            btn_jugar.UseVisualStyleBackColor = false;
            btn_jugar.Click += btn_jugar_Click;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.Teal;
            btnResultado.FlatStyle = FlatStyle.Flat;
            btnResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.ForeColor = SystemColors.Window;
            btnResultado.Location = new Point(640, 68);
            btnResultado.Margin = new Padding(3, 2, 3, 2);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(92, 32);
            btnResultado.TabIndex = 9;
            btnResultado.Text = "Solucion";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Visible = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // Btn_Ranking
            // 
            Btn_Ranking.BackColor = Color.Teal;
            Btn_Ranking.FlatStyle = FlatStyle.Flat;
            Btn_Ranking.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Ranking.ForeColor = SystemColors.Window;
            Btn_Ranking.Location = new Point(740, 68);
            Btn_Ranking.Margin = new Padding(3, 2, 3, 2);
            Btn_Ranking.Name = "Btn_Ranking";
            Btn_Ranking.Size = new Size(92, 32);
            Btn_Ranking.TabIndex = 10;
            Btn_Ranking.Text = "Ranking";
            Btn_Ranking.UseVisualStyleBackColor = false;
            Btn_Ranking.Click += Btn_Ranking_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1003, 524);
            Controls.Add(Btn_Ranking);
            Controls.Add(btnResultado);
            Controls.Add(btn_jugar);
            Controls.Add(dgvRanking);
            Controls.Add(dgv_puzlee);
            Controls.Add(numupdow_filas);
            Controls.Add(Lbl_Puntuacion);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Puzle";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numupdow_filas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_puzlee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRanking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label Lbl_Puntuacion;
        private NumericUpDown numupdow_filas;
        private DataGridView dgv_puzlee;
        private Button btn_jugar;
        private Button btnResultado;
        public DataGridView dgvRanking;
        private Button Btn_Ranking;
    }
}