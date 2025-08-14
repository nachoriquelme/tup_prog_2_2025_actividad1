using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Rectangulo
    {
        public double ancho {  get; set; } 
        public double largo { get; set; }
        public Rectangulo(double ancho, double largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
        public string Describir() 
        {
            string json = $@"
            {{
                ""Tipo"" : ""Rectangulo"",
                ""Largo"" : {largo};
                ""Ancho"" : {ancho};
                ""Area"" : {CalcularArea()};
            }}
            ";
            return json;
        }

        public double CalcularArea() 
        {
            double area = ancho * largo;
            return area;
        }
    }
}
