using System;
//Clase que almacena turno. Llama al personal y obtiene las recetas del producto que se va a hornear en el shift
public class TurnoDeMañana : ITurno 
{
  public void Cocinar() 
  {

   Console.WriteLine($"\n***INICIO DEL TURNO DE LA MAÑANA***\n");

        //Obtiene los empleados necesarios por shift
        EmpleadosTurnoMañana empleados = new EmpleadosTurnoMañana();

        Console.WriteLine($"Requerimientos de Personal:");
        Console.WriteLine($"  -Se necesita {empleados.getEncargadosDePersonal()} Encargados de Personal");
        Console.WriteLine($"  -Se necesita {empleados.getPersonalDeLimpieza()} Encargados de Limpieza");
        Console.WriteLine($"  -Se necesita {empleados.getPanaderos()} Panaderos especializados en Pan Dulce\n");
    
        ///Obtiene los ingredientes de la receta
        PanConMermelada receta1 = new PanConMermelada();

        receta1.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");

        ///Obtiene los ingredientes de la receta
        PanDulceConPasas receta2 = new PanDulceConPasas();

        receta2.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");
  }
}