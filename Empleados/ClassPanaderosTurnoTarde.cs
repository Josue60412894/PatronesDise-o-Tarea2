//Clase Derivada de la clase abstracta "Empleados No Especializados"
public class EmpleadosTurnoTarde: EmpleadosNoEspecializados
{
    private int PanaderoSalado = 2;
    public override int getPanaderos() // metodo abstracto
    {
        return PanaderoSalado;
    }
}
