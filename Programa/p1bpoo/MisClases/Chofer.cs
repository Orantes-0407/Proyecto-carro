using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace p1bpoo.MisClases
{
    public class Chofer : IPiloto
     {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Tipolicencia { get; set; }

        public Chofer(string name, int edadpiloto, string tipo)
        {
            Nombre = name;
            Edad = edadpiloto;
            Tipolicencia = tipo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
        }

        public void mostrarinformacion()
        {
            Console.WriteLine("Nombre: {0}", this.Nombre);
            Console.WriteLine("Edad: {0}", this.Edad);
            Console.WriteLine("Tipo de Licencia: {0}", this.Tipolicencia);
        }
    }
}

