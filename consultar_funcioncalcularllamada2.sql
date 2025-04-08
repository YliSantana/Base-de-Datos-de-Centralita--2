SELECT 
    Duracion,
    TipoLlamada,
    FranjaHoraria,
    dbo.CalcularCostoLlamada(Duracion, TipoLlamada, FranjaHoraria) AS CostoLlamada
FROM Llamadas2;
