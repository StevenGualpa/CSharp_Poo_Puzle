using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Poo_Puzle
{
    internal class JuegoPuzzle
    {
        public int f = 0;
        public int c = 0;
        public int num_fila = 0;
        public int num_columnas = 0;
        public int[,] Trozos;
        public int[,] Aletorio;
        public int Blanco = -1;
        public int puntuacion = 0; // Variable para almacenar la puntuación

        public List<Jugador> jugadores = new List<Jugador>();
        public GestorDeArchivos gestorArchivos;
        public string rutaArchivoJugadores = "jugadores.txt";
        public string NombreJugadorActual = "";

        public void MostrarRanking(DataGridView dgvRanking)
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

            //Ordenar la puntuacion de mejor a peor
            dt.DefaultView.Sort = "Puntuacion ASC";
            dt = dt.DefaultView.ToTable();

            // Configurar el DataGridView para mostrar el DataTable
            dgvRanking.DataSource = dt;

            // Opcional: Formatear el DataGridView
            dgvRanking.Columns["Nombre"].HeaderText = "Nombre del Jugador";
            dgvRanking.Columns["Puntuacion"].HeaderText = "Puntuación";
            dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void GuardarJugador(string nombre, int puntuacion, DataGridView dgvRanking)
        {
            jugadores.Add(new Jugador(nombre, puntuacion));
            jugadores = jugadores.OrderByDescending(j => j.Puntuacion).ToList(); // Ordenar por puntuación
            gestorArchivos.GuardarEnArchivo(jugadores);
            MostrarRanking(dgvRanking);
        }

        //Procedimiento que mostrara la Solucion
        public void Mostrar_Solucion(DataGridView dgv_puzlee)
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
        public void Generar_Columnas_Filas(DataGridView dgv_puzlee)
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
                Limpiar_Dgv(dgv_puzlee);
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
        public void Generar_Puzlee()
        {
            Random aleto = new Random();
            int[] res_vec = new int[num_fila * num_columnas];
            int n = 0;

            // Matriz a Vector
            for (int i = 0; i < num_fila; i++)
            {
                for (int j = 0; j < num_columnas; j++)
                {
                    res_vec[n++] = Trozos[i, j];
                }
            }

            // Fisher-Yates shuffle
            for (int i = res_vec.Length - 2; i > 0; i--) // Ignore the last element which should be the blank
            {
                int j = aleto.Next(0, i + 1);
                int temp = res_vec[i];
                res_vec[i] = res_vec[j];
                res_vec[j] = temp;
            }

            // Ensure the last element is blank
            int ultimo = res_vec.Length - 1;
            res_vec[ultimo] = -1;

            // Vector to Matriz
            n = 0;
            for (int i = 0; i < num_fila; i++)
            {
                for (int j = 0; j < num_columnas; j++)
                {
                    Aletorio[i, j] = res_vec[n++];
                }
            }
        }

        //Procedimiento Para Mostrar Puzlee
        public void Mostrar_Puzlee(DataGridView dgv_puzlee)
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
        public void Limpiar_Dgv(DataGridView dgv_puzlee)
        {
            int numcl = num_columnas;
            for (int i = 0; i < numcl; i++)
            {
                dgv_puzlee.Columns.RemoveAt(0);
            }
            dgv_puzlee.Rows.Clear();
        }

        //Procedimiento Para Verificar si Gano
        public bool Gano(DataGridView dgv_puzlee)
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

        //Procedimiento Para Jugar
        public void Jugar(Label Lbl_Puntuacion, NumericUpDown numupdow_filas, NumericUpDown numupdow_columnas, DataGridView dgv_puzlee) {
            bool ban = false;
            puntuacion = 0;
            Lbl_Puntuacion.Text = puntuacion.ToString();

            num_fila = Convert.ToInt32(numupdow_filas.Value);
            num_columnas = Convert.ToInt32(numupdow_columnas.Value);
            f = num_fila - 1;
            c = num_columnas - 1;
            try
            {
                Generar_Columnas_Filas(dgv_puzlee);
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
                Mostrar_Puzlee(dgv_puzlee);
            }
        }

        //Procedimiento Para Mover Celda
        public void MoverCelda(DataGridView dgv_puzlee, Label Lbl_Puntuacion, object sender, KeyEventArgs e, DataGridView dgvRanking) 
        {
            try
            {
                if (!Gano(dgv_puzlee))
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
                    GuardarJugador(NombreJugadorActual, puntuacion, dgvRanking);
                    MessageBox.Show("Gano ( ͡° ͜ʖ ͡°)", "Felicidades");

                }
            }
            catch
            {

            }
        }

    }
}

