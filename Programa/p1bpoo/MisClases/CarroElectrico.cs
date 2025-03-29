using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        public int velocidad = 0;
        private int cargaBateria;
        private int estadoVehicul;

        public CarroElectrico(int anio, string elColor, string elModelo, int velmax) : base(anio, elColor, elModelo, velmax)
        {
            cargaBateria = 50;
        }

        public override void acelerar(int cuanto, Chofer chofer)
        {
            if (estadoVehicul == 1)
            {
                base.acelerar(cuanto, chofer);
                cargaBateria--;
            }
            else
            {
                Console.WriteLine("No se puede acelerar si el carro está apagado");
            }
        }

        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }
    }
}
