
using System;

public class GalletasDeChocolate : IReceta 
{
  private string Harina = "6.3g";
  private string Azucar = "1kg";
  private string Agua = "2.8L";
  private string Levadura = "0.9kg";
  private string Sal = "475g";

  
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