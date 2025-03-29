using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
   
        public class Motocicleta : Vehiculo
        {
            public Motocicleta(int anio, string elColor, string elModelo, int velmax) : base(anio, elColor, elModelo, velmax)
            {
                tiposdelicenciaaceptados = new List<string> { "M" };
            }

            public override void acelerar(int cuanto, Chofer chofer)
            {
                if (ValidarLicencia(chofer))
                {
                    base.acelerar(cuanto, chofer);
                    Console.WriteLine($"La motocicleta acelera a {cuanto} km/h.");
                }
                else
                {
                    Console.WriteLine("El chofer no tiene la licencia adecuada para acelerar la motocicleta.");
                }
            }

        private bool ValidarLicencia(Chofer chofer)
        {
            throw new NotImplementedException();
        }

        public void CambiarCambio(int marcha)
        {
            if (marcha < 1 || marcha > 6)
            {
                Console.WriteLine("Numero de cambios entre 1 y 6.");
            }
            else
            {
                Console.WriteLine("Ahora: " +marcha + "es la nueva marcha");
            }
        }

        public void luces(int cual)
        {
            if (cual == 1)
            {
                Console.WriteLine("Las luces altas estan encendidas");
            }
            else if (cual == 2)
            {
                Console.WriteLine("Las luces bajas estan encendidas");
            }
            else
            {
                Console.WriteLine("Las luces estan apagadas");
            }
        }

        public void pito()
        {
            Console.WriteLine("Piiiiiip");
        }

            //privados
            int NiveldelTanque;

        private void LlenarTanque(int cuanto)
        {
            NiveldelTanque = +cuanto;

        }

        private void NivelDelTanque(int NiveldelTanque)
        {
            Console.WriteLine("El nivel del tanque es: " + NiveldelTanque);

            if (NiveldelTanque <= 20)
            {
                Console.WriteLine("El tanque esta casi vacio");
            }
            else if (NiveldelTanque <= 60)

            {
                Console.WriteLine("El tanque esta a la mitad");
            }
            else if (NiveldelTanque <= 80)
            {
                Console.WriteLine("El tanque esta  lleno");
            }
            else if (NiveldelTanque <= 100)
            {
                Console.WriteLine("El tanque esta lleno");
            }
        }

        private void Encender()
        {
            Console.WriteLine("El auto esta encendido");
        }
    }
}
