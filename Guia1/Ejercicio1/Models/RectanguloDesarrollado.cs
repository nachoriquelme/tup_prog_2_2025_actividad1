using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RectanguloDesarrollado
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public RectanguloDesarrollado(double largo, double ancho) 
        {
            Largo = largo;
            Ancho = ancho;
        }
        public double CalcularArea() 
        {
            return Largo * Ancho;
        }
        public string Describir() 
        {
            string json = $@"
            {{
                ""Tipo"" : ""RectanguloDesarrollado"",
                ""Largo"" : {Largo};
                ""Ancho"" : {Ancho};
                ""Area"" : {CalcularArea()};
            }}
            ";
            return json;
        }
    }
}
