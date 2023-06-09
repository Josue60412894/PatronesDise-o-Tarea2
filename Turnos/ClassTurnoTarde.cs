using System;

public class TurnoDeTarde : ITurno
{
    public void Cocinar()
    {

        Console.WriteLine($"\n***INICIO DEL TURNO DE LA TARDE***\n");

        EmpleadosTurnoTarde empleados = new EmpleadosTurnoTarde();
        Console.WriteLine($"Requerimientos de Personal:");
        Console.WriteLine($"  -Se necesita {empleados.getEncargadosDePersonal()} Encargados de Personal");
        Console.WriteLine($"  -Se necesita {empleados.getPersonalDeLimpieza()} Encargados de Limpieza");
        Console.WriteLine($"  -Se necesita {empleados.getPanaderos()} Panaderos especializados en Pan Salado\n");


        PanRellenoDePollo receta1 = new PanRellenoDePollo();

        receta1.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");

        PanBaguette receta2 = new PanBaguette();

        receta2.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");

        PanSaladoConQueso receta3 = new PanSaladoConQueso();

        receta3.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");
    }
}