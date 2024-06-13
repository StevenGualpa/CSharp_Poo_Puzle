using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Poo_Puzle
{
    internal class GestorDeArchivos
    {
        private string rutaArchivo;

        public GestorDeArchivos(string ruta)
        {
            rutaArchivo = ruta;
        }

        // Método para guardar jugadores en un archivo
        public void GuardarEnArchivo(List<Jugador> jugadores)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (var jugador in jugadores)
                {
                    sw.WriteLine($"{jugador.Nombre};{jugador.Puntuacion}");
                }
            }
        }

        // Método para cargar jugadores desde un archivo
        public List<Jugador> CargarDesdeArchivo()
        {
            List<Jugador> jugadores = new List<Jugador>();

            if (!File.Exists(rutaArchivo))
                return jugadores;

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    var datos = linea.Split(';');
                    if (datos.Length == 2 && int.TryParse(datos[1], out int puntuacion))
                    {
                        jugadores.Add(new Jugador(datos[0], puntuacion));
                    }
                }
            }

            return jugadores.OrderByDescending(j => j.ObtenerPuntuacion()).ToList();
        }
    }
}
