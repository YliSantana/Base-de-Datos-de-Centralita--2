public class Llamada
{
    public string NumeroOrigen { get; set; }
    public string NumeroDestino { get; set; }
    public int Duracion { get; set; } // en minutos
    public double Costo { get; set; }

    public Llamada(string origen, string destino, int duracion, double tarifa)
    {
        NumeroOrigen = origen;
        NumeroDestino = destino;
        Duracion = duracion;
        Costo = CalcularCosto(duracion, tarifa);
    }

    private double CalcularCosto(int minutos, double tarifa)
    {
        return minutos * tarifa;
    }

    public override string ToString()
    {
        return $"Origen: {NumeroOrigen}, Destino: {NumeroDestino}, Duración: {Duracion}min, Costo: {Costo} DOP";
    }
}