    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace CSharp_Poo_Puzle
    {
    public partial class Form1 : Form
    {

        static JuegoPuzzle juego;

        private void dgv_puzlee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() == "-1")
            {
                e.Value = "";  // Mostrar celda vacía
                e.FormattingApplied = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            juego = new JuegoPuzzle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_puzlee.BorderStyle = BorderStyle.FixedSingle;
            juego.puntuacion = 0;
            Lbl_Puntuacion.Text = juego.puntuacion.ToString();
            juego.gestorArchivos = new GestorDeArchivos(juego.rutaArchivoJugadores);
            juego.jugadores = juego.gestorArchivos.CargarDesdeArchivo();
            dgv_puzlee.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_puzlee_CellFormatting);


        }


        //Botones
        private void btn_jugar_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de ingreso de nombre
            FrmNombre formNombre = new FrmNombre();
            if (formNombre.ShowDialog() == DialogResult.OK)
            {
                string nombreJugador = formNombre.NombreJugador;
                juego.puntuacion = 0;
                juego.NombreJugadorActual = nombreJugador;
                juego.Jugar(Lbl_Puntuacion, numupdow_filas, numupdow_filas, dgv_puzlee);
                btnResultado.Visible = true;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                juego.Mostrar_Solucion(dgv_puzlee);
            }
            catch
            {

            }
        }

        //Evento Para Teclas
        private void dgv_puzlee_KeyDown(object sender, KeyEventArgs e)
        {
            juego.MoverCelda(dgv_puzlee, Lbl_Puntuacion, sender, e, dgvRanking);
        }

        private void Btn_Ranking_Click(object sender, EventArgs e)
        {
            juego.MostrarRanking(dgvRanking);
        }

        private void dgv_puzlee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numupdow_filas_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
