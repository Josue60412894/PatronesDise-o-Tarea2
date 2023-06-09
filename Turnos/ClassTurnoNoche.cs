using System;

public class TurnoDeNoche : ITurno
{
    public void Cocinar()
    {

        Console.WriteLine($"\n***INICIO DEL TURNO DE LA NOCHE***\n");

        EmpleadosTurnoNoche empleados = new EmpleadosTurnoNoche();
        Console.WriteLine($"Requerimientos de Personal:");
        Console.WriteLine($"  -Se necesita {empleados.getEncargadosDePersonal()} Encargados de Personal");
        Console.WriteLine($"  -Se necesita {empleados.getPersonalDeLimpieza()} Encargados de Limpieza");
        Console.WriteLine($"  -Se necesita {empleados.getPanaderos()} Panaderos especializados en Galletas\n");


        GalletasDeChocolate receta1 = new GalletasDeChocolate();

        receta1.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");

        GalletasDeVainilla receta2 = new GalletasDeVainilla();

        receta2.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");
    }
}