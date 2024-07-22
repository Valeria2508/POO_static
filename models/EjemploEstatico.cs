using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.models
{
    public class EjemploEstatico
    {
         public string Nombre { get; set; }
        public string Apellido { get; set; }

        public EjemploEstatico()
        {
            Nombre = "Valeria";
            Apellido = "cano";
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola {Nombre} {Apellido}");
        }
    }
}