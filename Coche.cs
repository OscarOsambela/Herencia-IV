using System;

class Coche:Vehiculo{
	public void Acelerar(){
		Console.WriteLine("Acelerando");
	}
	public void Frenar(){
		Console.WriteLine("Frenar");
	}
	public override void Conducir(){
		Console.WriteLine("Coche Conducir");
	}
}