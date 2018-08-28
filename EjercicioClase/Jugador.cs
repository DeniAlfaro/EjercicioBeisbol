using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public List<Equipo> equipos { get; set; }

        public Jugador()
        {
            equipos = new List<Equipo>();
        }
        public Jugador(string nombre, string numero)
        {
            equipos = new List<Equipo>();
            Nombre = nombre;
            Numero = numero;
        }
    }
}
