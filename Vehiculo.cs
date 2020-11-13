using System;

class Vehiculo{
	public void ArrancaMotor(string sonidoAlArrancar){
		Console.WriteLine($"Arranca el motor: {sonidoAlArrancar}");
	}
	public void PararMotor(string sonidoAlParar){
		Console.WriteLine($"Parando el motor: {sonidoAlParar}");
	}
	public virtual void Conducir(){
		Console.WriteLine("Este es el código genérico para conducir");
	}
}