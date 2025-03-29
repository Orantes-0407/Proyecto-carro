using p1bpoo.MisClases;
using System.Data;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

////miBYD.InformacionVehiculo();
////miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

//miBYD.acelerar(150);
//miBYD.frenar();   

Chofer piloto1 = new Chofer("Monica", 21, "B");
Chofer piloto2 = new Chofer("Andrea", 24, "M");
Chofer piloto3 = new Chofer("Pedro", 31, "A");

//piloto1.mostrarinformacion();
//piloto2.mostrarinformacion();
//piloto3.mostrarinformacion();


//Vehiculo sedan = new Vehiculo(2025, "rojo", "toyota");

//Console.WriteLine(sedan.encender());
//sedan.acelerar(50);
//Console.WriteLine(sedan.AsignarPilot(piloto1));
//Console.WriteLine(sedan.encender());

//Moto honda = new Moto(2000, "Morada", "honda");
//Console.WriteLine(honda.AsignarPilot(piloto2));

Bus microbus = new Bus(1999, "Azul", "Toyota", 200);
Console.WriteLine(microbus.AsignarPilot(piloto3));
microbus.Transportar("Guatemala");

Trailer CamiondeCarga = new Trailer(2020, "Azul", "Hiunday", 200);
Console.WriteLine(CamiondeCarga.AsignarPilot(piloto1));
CamiondeCarga.carga(20);
