// Abstract class de empleados. Guarda la cantidad de empleados no especializados necesarios por shift
public abstract class EmpleadosNoEspecializados
{
    private int EncargadosDePersonal = 1;

    private int PersonalDeLimpieza = 3;


    public abstract int getPanaderos();

  
    public int getEncargadosDePersonal()
    {
        return EncargadosDePersonal;
    }

    public int getPersonalDeLimpieza()
    {
        return PersonalDeLimpieza;
    }


}

