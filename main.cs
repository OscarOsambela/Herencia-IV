using System;

class MainClass {
  public static void Main (string[] args) {
		Console.WriteLine("Probando el avión");
		Avion miAvion = new Avion();
		miAvion.ArrancaMotor("rrrrrrr");
		miAvion.Despegar();
		miAvion.Conducir();
		miAvion.Aterrizar();
		miAvion.PararMotor("sssssss");
		Console.WriteLine("---------------------------");
		Console.WriteLine("Probando el coche");
		Coche miCoche = new Coche();
		miCoche.ArrancaMotor("mmmmmmmmm");
		miCoche.Acelerar();
		miCoche.Conducir();
		miCoche.Frenar();
		miCoche.PararMotor("fffffffffff");
  	Console.WriteLine("---------------------------");
		Console.WriteLine("Polimorfismo:");
		Vehiculo miVehiculo = miCoche;
		miVehiculo.Conducir();
		miVehiculo = miAvion;
		miVehiculo.Conducir();
 		Console.WriteLine("---------------------------");
		
	}
}