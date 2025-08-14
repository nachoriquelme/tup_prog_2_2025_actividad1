using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Ortoedro
    {
        public Rectangulo[] Laterales = new Rectangulo[4];
        public Rectangulo[] Bases = new Rectangulo[2];

        public Ortoedro(double anchoBase, double ladoComun, double largoLateral) 
        {
            Bases[0] = new Rectangulo(anchoBase, ladoComun);
            Bases[1] = new Rectangulo(anchoBase, ladoComun);
            Laterales[0] = new Rectangulo(largoLateral, ladoComun);
            Laterales[1] = new Rectangulo(largoLateral, ladoComun);
            Laterales[2] = new Rectangulo(largoLateral, ladoComun);
            Laterales[3] = new Rectangulo(largoLateral, ladoComun);
        }

        public double CalcularArea() 
        {
            double areaBase = Bases[0].CalcularArea();
            double areaLateral = Laterales[0].CalcularArea();
            return (areaBase * 2) + (areaLateral * 4);
        }

        public double CalcularVolumen() 
        {
            double volumen = Bases[0].ancho * Bases[0].largo * Laterales[0].ancho;
            return volumen;
        }

        public string Describir() 
        {
            string json = $@"
                {{
                    ""Tipo"": ""Ortoedro"",
                    ""Tapas"": 
                    [
                       {Bases[0].Describir()},
                       {Bases[1].Describir()},
                    ],
                    ""Laterales"":
                    [
                       {Laterales[0].Describir()}
                       {Laterales[1].Describir()}
                       {Laterales[2].Describir()}
                    ],
                    ""Area"" : {CalcularArea()},
                    ""Volumen"" : {CalcularVolumen()}
                }}
               ";
                return json;
        }
    }
}
