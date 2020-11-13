using System;

class Avion:Vehiculo{
	public void Aterrizar(){
		Console.WriteLine("Aterrizando");
	}
	public void Despegar(){
		Console.WriteLine("Despegando");
	}
	public override void Conducir(){
		Console.WriteLine("Avion Conducir");
	}
}