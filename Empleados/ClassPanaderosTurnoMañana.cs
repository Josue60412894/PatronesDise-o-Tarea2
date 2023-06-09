//Clase Derivada de la clase abstracta "Empleados No Especializados"
public class EmpleadosTurnoMañana : EmpleadosNoEspecializados
{
    private int PanaderoDulce = 2;
    public override int getPanaderos() // metodo abstracto
    {
        return PanaderoDulce;
    }
}
