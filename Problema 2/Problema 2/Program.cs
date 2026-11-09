using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Problema_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new
            {
                Nombre = "Luiscarlos",
                Edad = 30,
                carrera = "Ingeniería en sistemas"
            };
            string json = JsonConvert.SerializeObject(persona);
            Console.WriteLine(json);
        }
    }
}
