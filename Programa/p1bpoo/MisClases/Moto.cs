using System;

namespace p1bpoo.MisClases
{
    public class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo, 180) { }

        public override int CapacidadTanque => 15;

        public override int ConsumoCombustible => 3;

        public override int VelocidadMaxima => 180;

        public override void acelerar(int cuanto, Chofer chofer)
        {
            if (estadoVehiculo == 1)
            {
                base.acelerar(cuanto, chofer);
                Console.WriteLine("La moto va a {0} km/h", cuanto);
            }
            else
            {
                Console.WriteLine("No se puede acelerar si la moto está apagada");
            }
        }

        public override void frenar()
        {
            base.frenar();
            Console.WriteLine("La moto ha frenado.");
        }

        public void hacerCaballito()
        {
            Console.WriteLine("¡La moto está haciendo un caballito!");
        }

        private void LlenarTanque(int cuanto)
        {
            NiveldelTanque += cuanto;
        }

        private void NivelDelTanque()
        {
            Console.WriteLine("El nivel del tanque es: " + NiveldelTanque);

            if (NiveldelTanque <= 20)
            {
                Console.WriteLine("El tanque está casi vacío");
            }
            else if (NiveldelTanque <= 60)
            {
                Console.WriteLine("El tanque está a la mitad");
            }
            else if (NiveldelTanque <= 80)
            {
                Console.WriteLine("El tanque está lleno");
            }
            else if (NiveldelTanque <= 100)
            {
                Console.WriteLine("El tanque está completamente lleno");
            }
        }

        private int NiveldelTanque = 0;
    }
}
