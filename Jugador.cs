using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Poo_Puzle
{
    internal class Jugador
    {
        public string Nombre { get; set; }
        public int Puntuacion { get; set; }
        public Jugador(string nombre, int puntuacion)
        {
            Nombre = nombre;
            Puntuacion = puntuacion;
        }
        // Método para obtener la puntuación
        public int ObtenerPuntuacion()
        {
            return Puntuacion;
        }
    }
}
