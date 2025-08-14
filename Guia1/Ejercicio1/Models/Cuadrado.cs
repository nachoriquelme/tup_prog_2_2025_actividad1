using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cuadrado
    {
        public double Ancho {  get; set; }
        public double Largo { get; set; }
        public Cuadrado(double lado)
        {
            Largo = lado;
            Ancho = lado;
        }
        public double CalcularArea() 
        {
            return Largo * Ancho;
        }

        public string Describir() 
        {
            string json = $@"
            {{
                ""Tipo"" : ""Cuadrado"",
                ""Largo"" : {Largo};
                ""Ancho"" : {Ancho};
                ""Area"" : {CalcularArea()};
            }}
            ";
            return json;
        }
    }
}
