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
        int f = 0;
        int c = 0;
        int num_fila = 0;
        int num_columnas = 0;
        int[,] Trozos;
        int[,] Aletorio;
        int Blanco = -1;
        int puntuacion = 0; // Variable para almacenar la puntuación

        private List<Jugador> jugadores = new List<Jugador>();
        private GestorDeArchivos gestorArchivos;
        private const string rutaArchivoJugadores = "jugadores.txt";


        private void MostrarRanking()
        {
            List<Jugador> jugadores = gestorArchivos.CargarDesdeArchivo();

            // Crear un DataTable para el DataGridView
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Puntuacion", typeof(int));

            // Agregar datos al DataTable
            foreach (var jugador in jugadores)
            {
                DataRow row = dt.NewRow();
                row["Nombre"] = jugador.Nombre;
                row["Puntuacion"] = jugador.Puntuacion;
                dt.Rows.Add(row);
            }

            // Configurar el DataGridView para mostrar el DataTable
            dgvRanking.DataSource = dt;

            // Opcional: Formatear el DataGridView
            dgvRanking.Columns["Nombre"].HeaderText = "Nombre del Jugador";
            dgvRanking.Columns["Puntuacion"].HeaderText = "Puntuación";
            dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GuardarJugador(string nombre, int puntuacion)
        {
            jugadores.Add(new Jugador(nombre, puntuacion));
            jugadores = jugadores.OrderByDescending(j => j.Puntuacion).ToList(); // Ordenar por puntuación
            gestorArchivos.GuardarEnArchivo(jugadores);
            MostrarRanking();
        }

        //Procedimiento que mostrara la Solucion
        void Mostrar_Solucion()
        {
            for (int i = 0; i < num_fila; i++)
            {
                for (int j = 0; j < num_columnas; j++)
                {
                    dgv_puzlee[j, i].Value = Trozos[i, j] == Blanco ? -1 : Convert.ToInt32(Trozos[i, j]);
                    dgv_puzlee.Rows[i].Height = 50;
                    dgv_puzlee.Columns[j].Width = 50;
                }
            }
            dgv_puzlee.Width = (50 * num_columnas) + 5;
            dgv_puzlee.Height = (50 * num_fila) + 5;
        }

        //Procedimiento Para Crear Columnas y Filas en el Dgv
        void Generar_Columnas_Filas_Imagenes()
        {
            DataGridViewTextBoxColumn colnum;
            string nam = "C";
            if (dgv_puzlee.ColumnCount == 0)
            {
                dgv_puzlee.RowCount = num_fila;
                for (int i = 0; i < num_columnas; i++)
                {
                    colnum = new DataGridViewTextBoxColumn();
                    colnum.Name = (nam + i.ToString());
                    dgv_puzlee.Columns.Add(colnum);
                }
            }
            else
            {
                Limpiar_Dgv();
                dgv_puzlee.RowCount = num_fila;
                for (int i = 0; i < num_columnas; i++)
                {
                    colnum = new DataGridViewTextBoxColumn();
                    colnum.Name = (nam + i.ToString());
                    dgv_puzlee.Columns.Add(colnum);
                }
            }
            dgv_puzlee.Columns.RemoveAt(0);
            dgv_puzlee.ColumnHeadersVisible = false;
            dgv_puzlee.RowHeadersVisible = false;
        }
        //Procedimiento Para Generar El Puzlle
        void Generar_Puzlee()
        {
            Random aleto = new Random();
            int[] res_vec = new int[num_fila * num_columnas];
            int n = 0;
            // Matriz a Vector
            for (int i = 0; i < num_fila; i++)
            {
                for (int j = 0; j < num_columnas; j++)
                {
                    res_vec[n] = Trozos[i, j];
                    n++;
                }
            }
            // Vector Aleatorio
            int ultimo = res_vec[res_vec.Length - 1];
            int[] vec_ale = new int[num_fila * num_columnas];
            n = 0;
            int ele = 0;
            int banderita = 0;
            while (n < res_vec.Length - 1)
            {
                banderita = 0;
                ele = aleto.Next(0, vec_ale.Length - 1);
                vec_ale[n] = res_vec[ele];
                for (int k = 0; k <= n; k++)
                {
                    if (vec_ale[n] == vec_ale[k])
                    {
                        banderita++;
                    }
                }
                if (banderita > 1)
                {
                    n--;
                }
                else
                {
                    n++;
                }
            }
            n = 0;
            vec_ale[res_vec.Length - 1] = ultimo; // Último elemento en Blanco
            for (int i = 0; i < num_fila; i++)
            {
                for (int j = 0; j < num_columnas; j++)
                {
                    Aletorio[i, j] = vec_ale[n];
                    n++;
                }
            }
        }
        //Procedimiento Para Mostrar Puzlee
        void Mostrar_Puzlee()
        {
            for (int i = 0; i < num_fila; i++)
            {
                for (int j = 0; j < num_columnas; j++)
                {
                    dgv_puzlee[j, i].Value = Aletorio[i, j] == Blanco ? -1 : Convert.ToInt32(Aletorio[i, j]);
                    dgv_puzlee.Rows[i].Height = 50;
                    dgv_puzlee.Columns[j].Width = 50;
                }
            }
            dgv_puzlee.Width = (50 * num_columnas) + 5;
            dgv_puzlee.Height = (50 * num_fila) + 5;
        }

        //Procedimiento Para Limpiar Dgv
        void Limpiar_Dgv()
        {
            int numcl = num_columnas;
            for (int i = 0; i < numcl; i++)
            {
                dgv_puzlee.Columns.RemoveAt(0);
            }
            dgv_puzlee.Rows.Clear();
        }
        bool Gano()
        {
            for (int i = 0; i < num_fila; i++)
            {
                for (int j = 0; j < num_columnas; j++)
                {
                    // Verifica si el valor es igual a -1 para representar el Blanco
                    if (Convert.ToInt32(dgv_puzlee[j, i].Value) != Convert.ToInt32(Trozos[i, j]))
                    {
                        // Si hay al menos una diferencia, el puzzle no ha sido resuelto
                        return false;
                    }
                }
            }
            // Si no se encontraron diferencias, el puzzle ha sido resuelto
            return true;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_puzlee.BorderStyle = BorderStyle.FixedSingle;
            puntuacion = 0;
            Lbl_Puntuacion.Text = puntuacion.ToString();
            gestorArchivos = new GestorDeArchivos(rutaArchivoJugadores);
            jugadores = gestorArchivos.CargarDesdeArchivo();
            MostrarRanking();
        }


        //Botones
        private void btn_jugar_Click(object sender, EventArgs e)
        {
            bool ban = false;
            puntuacion = 0;
            Lbl_Puntuacion.Text = puntuacion.ToString();

            num_fila = Convert.ToInt32(numupdow_filas.Value);
            num_columnas = Convert.ToInt32(numupdow_columnas.Value);
            f = num_fila - 1;
            c = num_columnas - 1;
            try
            {
                Generar_Columnas_Filas_Imagenes();
                Trozos = new int[num_fila, num_columnas];
                Aletorio = new int[num_fila, num_columnas];
                int n = 1;
                for (int i = 0; i < num_fila; i++)
                {
                    for (int j = 0; j < num_columnas; j++)
                    {
                        Trozos[i, j] = n++;
                    }
                }
                Trozos[num_fila - 1, num_columnas - 1] = Blanco; // Última celda en Blanco
                Generar_Puzlee();
            }
            catch
            {
                ban = true;
            }
            if (!ban)
            {
                Mostrar_Puzlee();
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                Mostrar_Solucion();
            }
            catch
            {

            }
        }

        //Evento Para Teclas
        private void dgv_puzlee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!Gano())
                {
                    int respaldo;
                    if (e.KeyCode == Keys.Up)//Tecla Arriba===>Blanco Arriba===>Pieza Abajo
                    {
                        if (f > 0)
                        {
                            if (Convert.ToInt32(dgv_puzlee[c, f].Value) == Blanco)
                            {
                                respaldo = Convert.ToInt32(dgv_puzlee[c, f - 1].Value);
                                dgv_puzlee[c, f].Value = respaldo;
                                dgv_puzlee[c, --f].Value = Blanco;
                                puntuacion++;

                            }
                        }
                    }
                    if (e.KeyCode == Keys.Down)//Tecla Abajo===>Abajo Blanco===>Pieza Arriba
                    {
                        if (f < num_fila - 1)
                        {
                            if (Convert.ToInt32(dgv_puzlee[c, f].Value) == Blanco)
                            {
                                respaldo = Convert.ToInt32(dgv_puzlee[c, f + 1].Value);
                                dgv_puzlee[c, f].Value = respaldo;
                                dgv_puzlee[c, ++f].Value = Blanco;
                                puntuacion++;

                            }
                        }
                    }
                    if (e.KeyCode == Keys.Left)//Tecla Izquierda===>Izquierda Blanco===>Pieza Derecha
                    {
                        if (c > 0)
                        {
                            if (Convert.ToInt32(dgv_puzlee[c, f].Value) == Blanco)
                            {
                                respaldo = Convert.ToInt32(dgv_puzlee[c - 1, f].Value);
                                dgv_puzlee[c, f].Value = respaldo;
                                dgv_puzlee[--c, f].Value = Blanco;
                                puntuacion++;

                            }
                        }
                    }
                    if (e.KeyCode == Keys.Right)//Tecla Derecha===>Derecha Blanco===>Izquierda Pieza
                    {
                        if (c < num_columnas - 1)
                        {
                            if (Convert.ToInt32(dgv_puzlee[c, f].Value) == Blanco)
                            {
                                respaldo = Convert.ToInt32(dgv_puzlee[c + 1, f].Value);
                                dgv_puzlee[c, f].Value = respaldo;
                                dgv_puzlee[++c, f].Value = Blanco;
                                puntuacion++;

                            }
                        }
                    }
                    Lbl_Puntuacion.Text = puntuacion.ToString();

                }
                else
                {
                    GuardarJugador(puntuacion.ToString(), puntuacion);
                    MessageBox.Show("Gano ( ͡° ͜ʖ ͡°)", "Felicidades");

                }
            }
            catch
            {

            }
        }
    }
}
