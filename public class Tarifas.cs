public class Tarifas
{
    public static double ObtenerTarifa(string tipo, int franja)
    {
        if (tipo == "local") return 2.50;
        return franja switch
        {
            1 => 3.00,
            2 => 4.50,
            3 => 6.00,
            _ => 3.00 // Tarifa por defecto
        };
    }
}
