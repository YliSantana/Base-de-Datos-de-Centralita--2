using System.Data.SQLite;

public class BaseDeDatos
{
    private const string connectionString = "Data Source=centralita.db;Version=3;";

    public static void CrearTabla()
    {
        using (var conexion = new SQLiteConnection(connectionString))
        {
            conexion.Open();
            string query = @"CREATE TABLE IF NOT EXISTS llamadas (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            numero_origen TEXT,
                            numero_destino TEXT,
                            duracion INTEGER,
                            costo REAL)";
            SQLiteCommand command = new SQLiteCommand(query, conexion);
            command.ExecuteNonQuery();
        }
    }

    public static void GuardarLlamada(Llamada llamada)
    {
        using (var conexion = new SQLiteConnection(connectionString))
        {
            conexion.Open();
            string query = "INSERT INTO llamadas (numero_origen, numero_destino, duracion, costo) VALUES (@origen, @destino, @duracion, @costo)";
            SQLiteCommand command = new SQLiteCommand(query, conexion);
            command.Parameters.AddWithValue("@origen", llamada.NumeroOrigen);
            command.Parameters.AddWithValue("@destino", llamada.NumeroDestino);
            command.Parameters.AddWithValue("@duracion", llamada.Duracion);
            command.Parameters.AddWithValue("@costo", llamada.Costo);
            command.ExecuteNonQuery();
        }
    }
}
