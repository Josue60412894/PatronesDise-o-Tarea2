//Clase Derivada de la clase abstracta "Empleados No Especializados"
//Guarda la cantidad de panaderos especializados necesarios por shift
public class EmpleadosTurnoNoche: EmpleadosNoEspecializados
{
    private int PanaderoGalletero = 2;
    public override int getPanaderos() // metodo abstracto
    {
        return PanaderoGalletero;
    }
}
