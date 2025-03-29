using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        public int CargaMaxima { get; set; }
        public int CargaActual { get; set; }

        public Camion(int anio, string elColor, string elModelo, int velmax) : base(anio, elColor, elModelo, 200) { }

        public override void acelerar(int cuanto, Chofer chofer)
        {
            base.acelerar(cuanto, chofer);
            Console.WriteLine("El camión va a {0} km/h", cuanto);
        }

        public override void frenar()
        {
            base.frenar();
        }

        public void Cargar(int carga)
        {
            if (CargaActual + carga <= CargaMaxima)
            {
                CargaActual += carga;
                Console.WriteLine("Se cargaron " + carga + " kg. Carga actual: " + CargaActual + " kg.");
            }
            else
            {
                Console.WriteLine("La carga es mayor al límite.");
            }
        }

        public void Transportar(string destino)
        {
            Console.WriteLine("El camión " + Modelo + " está transportando carga hacia " + destino);
        }

        public void Descargar(int carga)
        {
            if (CargaActual >= carga)
            {
                CargaActual -= carga;
                Console.WriteLine($"Se descargaron " + carga + " kg. Carga actual: " + CargaActual + " kg.");
            }
            else
            {
                Console.WriteLine("No hay suficiente carga para descargar.");
            }
        }

        int NiveldelTanque;

        private void Apagar()
        {
            Console.WriteLine("El camión está apagado");
        }

        private void Encender()
        {
            Console.WriteLine("El camión está encendido");
        }

        private void LlenarTanque(int cuanto)
        {
            NiveldelTanque += cuanto;
        }
    }
}
