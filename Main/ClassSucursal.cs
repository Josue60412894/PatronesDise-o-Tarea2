//Clase sucursal. Dentro de la clase se inician los 3 turnos y ahi se obtienen los empleados necesarios y receta.

public class Sucursal
{
    private string Ubicacion;
    private string Nombre;
    private int ID;
    private string Gerente;

    public Sucursal(string Ubicacion, string Nombre, int ID, string Gerente)
    {
        this.Ubicacion = Ubicacion;
        this.Nombre = Nombre;
        this.ID = ID;
        this.Gerente = Gerente;
    }

    public string GetUbicacion()
    {
        return Ubicacion;
    }

    public string GetNombre()
    {
        return Nombre;
    }

    public int GetID()
    {
        return ID;
    }

     public string GetGerente()
    {
        return Gerente;
    }

     public void InicioTurnos()
    {
      TurnoDeMañana TurnoMañana = new TurnoDeMañana();
      TurnoMañana.Cocinar();

      TurnoDeTarde TurnoTarde = new TurnoDeTarde();
      TurnoTarde.Cocinar();

      TurnoDeNoche TurnoNoche = new TurnoDeNoche();
      TurnoNoche.Cocinar();
    }

}
