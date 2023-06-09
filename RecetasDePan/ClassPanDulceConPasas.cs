
using System;
//Clase que almacena ingredientes de receta
public class PanDulceConPasas : IReceta 
{
  private string Harina = "3kg";
  private string Azucar = "2.5kg";
  private string Agua = "5L";
  private string Levadura = "1.5kg";
  private string Sal = "550g";

  
  public void getIngredientes() 
  {
    Console.WriteLine($"El tipo de pan a hornear es: {this.GetType().Name}\n");
    Console.WriteLine($"Detalles de los ingredientes:");
    Console.WriteLine($"  -Harina : {this.Harina}");
    Console.WriteLine($"  -Azucar : {this.Azucar}");
    Console.WriteLine($"  -Agua : {this.Agua}");
    Console.WriteLine($"  -Levadura : {this.Levadura}");
    Console.WriteLine($"  -Sal : {this.Sal}");
  }

  
}