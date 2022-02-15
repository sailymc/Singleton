// Singleton

namespace Singleton;

public class Ejemplo
{
    private static Ejemplo _instancia = null;
    private Ejemplo()
    {
    }

    public static Ejemplo Instancia
    {
        get
        {
            if (_instancia == null)
                _instancia = new Ejemplo();
            return _instancia;
        }
    }
}




