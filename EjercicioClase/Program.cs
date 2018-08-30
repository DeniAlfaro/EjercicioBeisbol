using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo equipo1 = new Equipo();
            equipo1.EstadioJugadores = new Estadio();
            equipo1.EstadioJugadores.Nombre = "Estadio de Hermosillo";
            equipo1.Nombre = "Las Aguilas";
            equipo1.jugadores.Add(new Jugador("Javier", "53"));
            equipo1.jugadores.Add(new Jugador("Francisco", "12"));
            equipo1.jugadores.Add(new Jugador("Eduardo", "32"));
            equipo1.jugadores.Add(new Jugador("Ivan", "21"));
            equipo1.jugadores.Add(new Jugador("Angel", "23"));
            equipo1.jugadores.Add(new Jugador("Ernesto", "45"));
            equipo1.jugadores.Add(new Jugador("German", "65"));
            equipo1.jugadores.Add(new Jugador("Adrian", "78"));
            equipo1.jugadores.Add(new Jugador("Manuel", "98"));
            equipos.Add(equipo1);

            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Buhos";
            equipo2.jugadores.Add(new Jugador("Santiago", "35"));
            equipo2.jugadores.Add(new Jugador("David", "43"));
            equipo2.jugadores.Add(new Jugador("Miguel", "92"));
            equipo2.jugadores.Add(new Jugador("Armando", "76"));
            equipo2.jugadores.Add(new Jugador("Andres", "32"));
            equipo2.jugadores.Add(new Jugador("Sebastian", "54"));
            equipo2.jugadores.Add(new Jugador("Pablo", "65"));
            equipo2.jugadores.Add(new Jugador("Ruben", "87"));
            equipo2.jugadores.Add(new Jugador("Alejandro", "89"));
            equipos.Add(equipo2);

            foreach (Equipo elemento in equipos)
            {
                Console.WriteLine("Nombre Equipo: " + elemento.Nombre);
                if (elemento.EstadioJugadores != null)
                {
                    Console.WriteLine("Nombre Estadio: " + elemento.EstadioJugadores.Nombre);
                }
                else
                {
                    Console.WriteLine("El equipo no tiene estadio");
                }
                foreach (Jugador elemento2 in elemento.jugadores)
                {
                    Console.WriteLine("Nombre: " + elemento2.Nombre);
                    Console.WriteLine("Numero Jugador: " + elemento2.Numero);
                }
                Console.WriteLine(" ");
            }
            
            Console.ReadLine();
        }
    }
}
