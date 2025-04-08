public class Centralita
{
    private List<Llamada> llamadas = new List<Llamada>();

    public void RegistrarLlamada(string origen, string destino, int duracion, double tarifa)
    {
        Llamada nuevaLlamada = new Llamada(origen, destino, duracion, tarifa);
        llamadas.Add(nuevaLlamada);
        Console.WriteLine("Llamada registrada correctamente.");
    }

    public void MostrarLlamadas()
    {
        foreach (var llamada in llamadas)
        {
            Console.WriteLine(llamada);
        }
    }
}