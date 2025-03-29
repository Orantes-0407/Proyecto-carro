using p1bpoo.MisClases;

public class AutoDeCombustion : Vehiculo
{
    public AutoDeCombustion(int anio, string elColor, string elModelo, int velmax) : base(anio, elColor, elModelo, velmax) { }

    // Definición de los públicos
    public override void frenar()
    {
        base.frenar();
        NiveldelTanque--;
    }

    public override void acelerar(int cuanto, Chofer chofer)
    {
        if (estadoVehiculo == 1)  // Usé 'estadoVehiculo' tal como lo definiste en la clase Vehiculo
        {
            base.acelerar(cuanto, chofer);
            Console.WriteLine("El auto va a {0} km/h", cuanto);
        }
        else
        {
            Console.WriteLine("No se puede acelerar si el carro está apagado");
        }
    }

    public void luces(bool estado)
    {
        if (estado)
        {
            Console.WriteLine("Las luces están encendidas");
        }
        else
        {
            Console.WriteLine("Las luces están apagadas");
        }
    }

    // Definición de los privados
    private int NiveldelTanque;

    private void LlenarTanque(int cuanto)
    {
        NiveldelTanque += cuanto;
    }

    private void NivelDelTanque(int NiveldelTanque)
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
   
    public void Apagar(int velocidad)
    {
        if (velocidad == 0)
        {
            estadoVehiculo = 0;  // Apagar el vehículo solo si la velocidad es cero
            Console.WriteLine("El auto está apagado");
        }
        else
        {
            Console.WriteLine("No se puede apagar el vehículo en movimiento.");
        }
    }

    public void Encender()
    {
        if (estadoVehiculo == 0)
        {
            estadoVehiculo = 1;
            Console.WriteLine("El auto está encendido");
        }
        else
        {
            Console.WriteLine("El auto ya está encendido");
        }
    }
}
