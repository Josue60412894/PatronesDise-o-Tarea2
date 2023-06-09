
using System;

public class PanSaladoConQueso : IReceta 
{
  private string Harina = "8kg";
  private string Azucar = "2kg";
  private string Agua = "3.1L";
  private string Levadura = "1kg";
  private string Sal = "800g";

  
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