using System;
//Clase que almacena turno. Llama al personal y obtiene las recetas del producto que se va a hornear en el shift
public class TurnoDeNoche : ITurno
{
    public void Cocinar()
    {

        Console.WriteLine($"\n***INICIO DEL TURNO DE LA NOCHE***\n");
        
        //Obtiene los empleados necesarios por shift
        EmpleadosTurnoNoche empleados = new EmpleadosTurnoNoche();

        Console.WriteLine($"Requerimientos de Personal:");
        Console.WriteLine($"  -Se necesita {empleados.getEncargadosDePersonal()} Encargados de Personal");
        Console.WriteLine($"  -Se necesita {empleados.getPersonalDeLimpieza()} Encargados de Limpieza");
        Console.WriteLine($"  -Se necesita {empleados.getPanaderos()} Panaderos especializados en Galletas\n");

        ///Obtiene los ingredientes de la receta
        GalletasDeChocolate receta1 = new GalletasDeChocolate();

        receta1.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");


        ///Obtiene los ingredientes de la receta
        GalletasDeVainilla receta2 = new GalletasDeVainilla();

        receta2.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");
    }
}