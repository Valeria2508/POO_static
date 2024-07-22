using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.models
{
    public static class EjemploEstatico //al declarar una clase estatica, todo lo de adentro sera esatico
    //si la clase no es estatica, lo de adentro puede ser estatico o no 
    {
        public static string Nombre { get; set; }
        //poniendole el static me permite acceder a metodos y atributos sin necesidad de instanciar
        public static string Apellido { get; set; }

        static EjemploEstatico() //no le puedo pasar parametros a un constructor estatico
        {
            Nombre = "Valeria";
            Apellido = "cano";
        }

        public static void Saludar()
        {
            Console.WriteLine($"Hola {Nombre} {Apellido}");
        }
    }
}