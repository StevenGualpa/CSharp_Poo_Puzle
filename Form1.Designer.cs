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
            label1.Location = new Point(48, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "Tamaño:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(617, 27);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 2;
            label3.Text = "Puntuacion:";
            label3.Click += label3_Click;
            // 
            // Lbl_Puntuacion
            // 
            Lbl_Puntuacion.AutoSize = true;
            Lbl_Puntuacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Puntuacion.Location = new Point(724, 27);
            Lbl_Puntuacion.Name = "Lbl_Puntuacion";
            Lbl_Puntuacion.Size = new Size(15, 23);
            Lbl_Puntuacion.TabIndex = 3;
            Lbl_Puntuacion.Text = " ";
            // 
            // numupdow_filas
            // 
            numupdow_filas.Location = new Point(125, 27);
            numupdow_filas.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numupdow_filas.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numupdow_filas.Name = "numupdow_filas";
            numupdow_filas.ReadOnly = true;
            numupdow_filas.Size = new Size(86, 27);
            numupdow_filas.TabIndex = 4;
            numupdow_filas.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // dgv_puzlee
            // 
            dgv_puzlee.BackgroundColor = Color.WhiteSmoke;
            dgv_puzlee.BorderStyle = BorderStyle.None;
            dgv_puzlee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_puzlee.Location = new Point(48, 108);
            dgv_puzlee.Name = "dgv_puzlee";
            dgv_puzlee.RowHeadersWidth = 51;
            dgv_puzlee.Size = new Size(299, 188);
            dgv_puzlee.TabIndex = 6;
            dgv_puzlee.CellContentClick += dgv_puzlee_CellContentClick;
            dgv_puzlee.KeyDown += dgv_puzlee_KeyDown;
            // 
            // dgvRanking
            // 
            dgvRanking.BackgroundColor = Color.WhiteSmoke;
            dgvRanking.BorderStyle = BorderStyle.None;
            dgvRanking.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRanking.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRanking.EnableHeadersVisualStyles = false;
            dgvRanking.GridColor = Color.Teal;
            dgvRanking.Location = new Point(624, 160);
            dgvRanking.Name = "dgvRanking";
            dgvRanking.ReadOnly = true;
            dgvRanking.RowHeadersVisible = false;
            dgvRanking.RowHeadersWidth = 51;
            dgvRanking.Size = new Size(302, 249);
            dgvRanking.TabIndex = 7;
            // 
            // btn_jugar
            // 
            btn_jugar.BackColor = Color.Teal;
            btn_jugar.FlatStyle = FlatStyle.Flat;
            btn_jugar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_jugar.ForeColor = SystemColors.Window;
            btn_jugar.Location = new Point(617, 91);
            btn_jugar.Name = "btn_jugar";
            btn_jugar.Size = new Size(105, 43);
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
            btnResultado.Location = new Point(731, 91);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(105, 43);
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
            Btn_Ranking.Location = new Point(846, 91);
            Btn_Ranking.Name = "Btn_Ranking";
            Btn_Ranking.Size = new Size(105, 43);
            Btn_Ranking.TabIndex = 10;
            Btn_Ranking.Text = "Ranking";
            Btn_Ranking.UseVisualStyleBackColor = false;
            Btn_Ranking.Click += Btn_Ranking_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1146, 539);
            Controls.Add(Btn_Ranking);
            Controls.Add(btnResultado);
            Controls.Add(btn_jugar);
            Controls.Add(dgvRanking);
            Controls.Add(dgv_puzlee);
            Controls.Add(numupdow_filas);
            Controls.Add(Lbl_Puntuacion);
            Controls.Add(label3);
            Controls.Add(label1);
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