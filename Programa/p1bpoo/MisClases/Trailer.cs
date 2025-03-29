using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Trailer : Vehiculo
    {
        public Trailer(int year, string color, string modelo, int velmax) : base(year, color, modelo, 200)
        {
            tiposdelicenciaaceptados = new List<string> { "B" };
        }

        public void carga(int cuanto)
        {
            int peso = 0;

            peso += cuanto;
            Console.WriteLine("El trailer lleva " + peso +" toneladas");
        }
        
    }
}
