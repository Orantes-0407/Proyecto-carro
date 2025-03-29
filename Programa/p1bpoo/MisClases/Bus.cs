using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Bus : Vehiculo
    {
        public Bus(int year, string color, string modelo, int velmax) : base(year, color, modelo, 150)
        {
            tiposdelicenciaaceptados = new List<string> { "A" };
        }

        public void Transportar(string destino)
        {
            Console.WriteLine("El camión " + Modelo + " se está transportando hacia " + destino);
        }
    }
}
