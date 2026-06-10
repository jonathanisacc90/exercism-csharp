static class LogLine
{
    public static string Message(string logLine)
    {
       
        // 1) Cortar en el punto estable "]:"
        // 2) Quedarse con la segunda parte (el mensaje)
        // 3) Limpiar espacios y saltos de línea

        return logLine.Split("]:")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
       
        // 1) Cortar en el punto estable "]:"
        // 2) Quedarse con la primera parte (el nivel)
        // 3) Quitar los corchetes
        // 4) Normalizar a minúsculas

        return logLine.Split("]:")[0]
                      .Trim('[', ']')
                      .ToLower();
    }

    public static string Reformat(string logLine)
    {
        
        // Coordina y reutiliza lógica ya resuelta:
        // mensaje primero, nivel después entre paréntesis

        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
