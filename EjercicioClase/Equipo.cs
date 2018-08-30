using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }
        public Estadio EstadioJugadores { get; set; }

        public List<Jugador> jugadores { get; set; }

        public Equipo(string nombre)
        {
            jugadores = new List<Jugador>();
            Nombre = nombre;
        }
        public Equipo()
        {
            jugadores = new List<Jugador>();
            CiudadOrigen = "No existe dato";
            Entrenador = "Emiliano";
        }
    }
}
