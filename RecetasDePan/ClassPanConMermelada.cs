
using System;
//Clase que almacena ingredientes de receta
public class PanConMermelada : IReceta 
{
  private string Harina = "5kg";
  private string Azucar = "2kg";
  private string Agua = "3L";
  private string Levadura = "0.5kg";
  private string Sal = "350g";

  
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