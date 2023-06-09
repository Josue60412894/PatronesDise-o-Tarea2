using System;
//Clase que almacena turno. Llama al personal y obtiene las recetas del producto que se va a hornear en el shift
public class TurnoDeTarde : ITurno
{
    public void Cocinar()
    {

        Console.WriteLine($"\n***INICIO DEL TURNO DE LA TARDE***\n");
        
        //Obtiene los empleados necesarios por shift
        EmpleadosTurnoTarde empleados = new EmpleadosTurnoTarde();

        Console.WriteLine($"Requerimientos de Personal:");
        Console.WriteLine($"  -Se necesita {empleados.getEncargadosDePersonal()} Encargados de Personal");
        Console.WriteLine($"  -Se necesita {empleados.getPersonalDeLimpieza()} Encargados de Limpieza");
        Console.WriteLine($"  -Se necesita {empleados.getPanaderos()} Panaderos especializados en Pan Salado\n");

        ///Obtiene los ingredientes de la receta
        PanRellenoDePollo receta1 = new PanRellenoDePollo();

        receta1.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");

        ///Obtiene los ingredientes de la receta
        PanBaguette receta2 = new PanBaguette();

        receta2.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");

        ///Obtiene los ingredientes de la receta
        PanSaladoConQueso receta3 = new PanSaladoConQueso();

        receta3.getIngredientes();

        Console.WriteLine($"\n<(^.^)>  COCINANDO  <(^.^)>\n");
    }
}