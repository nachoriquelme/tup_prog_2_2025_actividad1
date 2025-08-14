using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Circulo
    {
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            double radio2 = Radio * Radio;
            return Math.PI * radio2;
        }

        public string Describir()
        {
            string json = $@"
                {{  
                  ""Tipo"":""Circulo"", 
                  ""Radio"": {Radio}, 
                  ""Area"": {CalcularArea()}
                }}
                ";
            return json;
        }
    }
}
