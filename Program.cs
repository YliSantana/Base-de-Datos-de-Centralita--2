class Program
{
    static void Main()
    {
        BaseDeDatos.CrearTabla();
        Centralita centralita = new Centralita();

        centralita.RegistrarLlamada("8295551234", "8097775678", 3, Tarifas.ObtenerTarifa("provincial", 2));
        centralita.MostrarLlamadas();
    }
}
