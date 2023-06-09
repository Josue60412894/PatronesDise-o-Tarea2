using System;

public class TurnoDeMañana : ITurno 
{
  public void Cocinar() 
  {

   Console.WriteLine($"\n***INICIO DEL TURNO DE LA MAÑANA***\n");

        EmpleadosTurnoMañana empleados = new EmpleadosTurnoMañana();
        Console.WriteLine($"Requerimientos de Personal:");
        Console.WriteLine($"  -Se necesita {empleados.getEncargadosDePersonal()} Encargados de Personal");
        Console.WriteLine($"  -Se necesita {empleados.getPersonalDeLimpieza()} Encargados de Limpieza");
        Console.WriteLine($"  -Se necesita {empleados.getPanaderos()} Panaderos especializados en Pan Dulce\n");
    

        PanConMermelada receta1 = new PanConMermelada();

        receta1.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");

        PanDulceConPasas receta2 = new PanDulceConPasas();

        receta2.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");
  }
}