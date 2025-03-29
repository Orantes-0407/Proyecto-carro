using p1bpoo.MisClases;

public class Vehiculo
{
    public string Color { get; set; }
    public string Modelo { get; set; }
    public int Year { get; set; }
    private int velocidad = 0;
    public virtual int CapacidadTanque { get; set; }
    public virtual int ConsumoCombustible { get; set; }
    public virtual int VelocidadMaxima { get; set; }
    public int NiveldelTanque { get; private set; }

    protected List<string> tiposdelicenciaaceptados = new List<string> { "A", "B", "C", "M" };
    private Chofer piloto = null;
    protected int estadoVehiculo = 0;

    public string encender()
    {
        if (piloto == null)
        {
            return "No se puede encender el vehiculo sin un piloto";
        }
        if (estadoVehiculo == 0)
        {
            estadoVehiculo = 1;
            return "Vehiculo encendido";
        }
        return "El vehiculo ya esta encendido";
    }

    public string AsignarPilot(Chofer elpiloto)
    {
        if (elpiloto == null)
        {
            return "No se puede asignar un piloto nulo";
        }
        if (!tiposdelicenciaaceptados.Contains(elpiloto.Tipolicencia))
        {
            return "El piloto no tiene el tipo de licencias adecuado a este carro";
        }
        piloto = elpiloto;  
        return "Piloto asignado correctamente";
    }

    public virtual void acelerar(int cuanto, Chofer chofer)
    {
        if (estadoVehiculo == 1)
        {
            if (ValidarLicencia(chofer))
            {
                velocidad += cuanto;
                AjustarVelocidadMaxima();
                Console.WriteLine("Vas a {0} KMS / Hora", velocidad);
            }
            else
            {
                Console.WriteLine("El chofer no tiene la licencia adecuada para acelerar este vehículo.");
            }
        }
        else
        {
            Console.WriteLine("No se puede acelerar si el carro está apagado");
        }
    }

    private bool ValidarLicencia(Chofer chofer)
    {
        throw new NotImplementedException();
    }

    private void AjustarVelocidadMaxima()
    {
        if (velocidad > VelocidadMaxima)
        {
            velocidad = VelocidadMaxima;
            Console.WriteLine("Has alcanzado la velocidad máxima permitida: {0} KMS / Hora", VelocidadMaxima);
        }
    }

    public Vehiculo(int anio, string elColor, string elModelo, int velocidadMaxima)
    {
        this.Color = elColor;
        this.Modelo = elModelo;
        this.Year = anio;
        this.VelocidadMaxima = velocidadMaxima;
    }

    public void InformacionVehiculo()
    {
        Console.WriteLine("Color: {0}", this.Color);
        Console.WriteLine("Modelo: {0}", this.Modelo);
        Console.WriteLine("Año: {0}", this.Year);
        Console.WriteLine("Velocidad Máxima: {0} KMS / Hora", this.VelocidadMaxima);
    }

    public virtual void frenar()
    {
        if (velocidad > 0)
        {
            velocidad -= 10;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("La velocidad actual es de {0} km/h.", velocidad);
        }
        else
        {
            Console.WriteLine("El vehículo ya está detenido.");
            // No cambiar el estadoVehiculo aquí, ya que el vehículo está detenido
        }
    }

    public void apagar()
    {
        if (velocidad == 0)
        {
            estadoVehiculo = 0;  // Apagar el vehículo solo si la velocidad es cero
            Console.WriteLine("Vehículo apagado");
        }
        else
        {
            Console.WriteLine("No se puede apagar el vehículo en movimiento.");
        }
    }

    public void NivelDelTanque()
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
}
