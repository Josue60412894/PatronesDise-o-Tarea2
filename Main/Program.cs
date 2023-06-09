using System;

//Main program de panaderia
//Se crean 3 objetos nuevos. Un objeto por cada Sucursal
class Program
{
    static void Main(string[] args)
    {
        
        ////Sucuarsal 1
        Sucursal SucursalHeredia = new Sucursal("Heredia","Panaderia-La-Favorita",0001,"Jose_Luis_Rodriguez");  // Crea un objecto de Sucursal
        Console.WriteLine($"\n******************** {SucursalHeredia.GetNombre()} ********************");
        Console.WriteLine($"\nEl nombre de la sucursal es: {SucursalHeredia.GetNombre()}");
        Console.WriteLine($"La ubicacion  de la sucursal es: {SucursalHeredia.GetUbicacion()}");
        Console.WriteLine($"El ID de la sucursal es: {SucursalHeredia.GetID()}");
        Console.WriteLine($"El nombre del Gerente de la sucursal es: {SucursalHeredia.GetGerente()}");
        SucursalHeredia.InicioTurnos();
        
        ////Sucuarsal 2
        Sucursal SucursalSanJose = new Sucursal("San Jose","Panaderia-La-Esquina",0002,"Roberto_Blanco");  // Crea un objecto de Sucursal
        Console.WriteLine($"\n******************** {SucursalSanJose.GetNombre()} ********************");
        Console.WriteLine($"\nEl nombre de la sucursal es: {SucursalSanJose.GetNombre()}");
        Console.WriteLine($"La ubicacion  de la sucursal es: {SucursalSanJose.GetUbicacion()}");
        Console.WriteLine($"El ID de la sucursal es: {SucursalSanJose.GetID()}");
        Console.WriteLine($"El nombre del Gerente de la sucursal es: {SucursalSanJose.GetGerente()}");
        SucursalSanJose.InicioTurnos();

        ////Sucuarsal 3
        Sucursal SucursalAlajuela = new Sucursal("Alajuela","Panaderia-La-Famosa",0003,"Maria_Sanchez");  // Crea un objecto de Sucursal
        Console.WriteLine($"\n******************** {SucursalAlajuela.GetNombre()} ********************");
        Console.WriteLine($"\nEl nombre de la sucursal es: {SucursalAlajuela.GetNombre()}");
        Console.WriteLine($"La ubicacion  de la sucursal es: {SucursalAlajuela.GetUbicacion()}");
        Console.WriteLine($"El ID de la sucursal es: {SucursalAlajuela.GetID()}");
        Console.WriteLine($"El nombre del Gerente de la sucursal es: {SucursalAlajuela.GetGerente()}");
        SucursalAlajuela.InicioTurnos();

    }
}


