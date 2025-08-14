using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Cilindro
    {
        public Circulo[] tapas = new Circulo[2];
        RectanguloDesarrollado lado;

        public Cilindro(double radio, double altura) 
        {
            tapas[0] = new Circulo(radio);
            tapas[1] = new Circulo(radio);
            lado = new RectanguloDesarrollado(radio, altura);
        }

        public double CalcularArea() 
        {
            return 2 * tapas[0].CalcularArea() + lado.CalcularArea();
        }

        public double CalcularVolumen() 
        {
            return tapas[0].CalcularArea() * lado.Largo;
        }

        public string Describir() 
        {
            string json = $@"
                {{
                    ""Tipo"": ""Cilindro"",
                    ""Tapas"": 
                    [
                       {tapas[0].Describir()},
                       {tapas[1].Describir()},
                    ],
                    ""Lado"": {lado.Describir()},
                    ""Area"" : {CalcularArea()},
                    ""Volumen"" : {CalcularVolumen()}
                }}
               ";
            return json;
        }
    }
}
