
using System;
//Clase que almacena ingredientes de receta
public class GalletasDeVainilla : IReceta 
{
  private string Harina = "7.8kg";
  private string Azucar = "1kg";
  private string Agua = "2L";
  private string Levadura = "1.4kg";
  private string Sal = "160g";

  
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