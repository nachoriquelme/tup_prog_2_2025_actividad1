using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cubo
    {
        public Cuadrado[] Caras = new Cuadrado[6];
        //public double lado;
        public Cubo(double lado) 
        {
            for (int i = 0; i < Caras.Length; i++) 
            {
                Caras[i] = new Cuadrado(lado);
            }
        }

        public double CalcularArea() 
        {
            double area = 4 * Caras[0].CalcularArea();
            return area;
        }

        public double CalcularVolumen() 
        {
            double lado = Caras[0].Ancho;
            double volumen = lado * lado * lado;
            return volumen;
        }

        public string Describir() 
        {
            string lateralesDescripcion = "";
            for (int n = 0; n < 6; n++)
            {
                lateralesDescripcion += Caras[n].Describir() + ", \n";
            }

            string json = $@"
            {{
                    ""Tipo"": ""Cubo"",
                    ""Caras"": 
                    [
                       {lateralesDescripcion}
                    ],
                    ""Area"" : {CalcularArea()},
                    ""Volumen"" : {CalcularVolumen()}
            }}
            ";
            return json;
        }
    }
}
