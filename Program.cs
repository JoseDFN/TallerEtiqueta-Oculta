internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();

        var productosConEtiquetas = new List<(string Producto, List<string> Etiquetas)>
        {
            ("Laptop HP", new List<string> { "Electronica", "Computadores", "Trabajo" }),
            ("Silla de Oficina", new List<string> { "Muebles", "Confort", "Oficina" }),
            ("Cafetera Oster", new List<string> { "Cocina", "Electrodomesticos", "Café" })
        };

        Console.WriteLine("\nTodas las etiquetas:");
        var todasEtiquetas = productosConEtiquetas.SelectMany(p => p.Etiquetas).Distinct().ToList();
        foreach (var etiqueta in todasEtiquetas)
            Console.WriteLine(etiqueta);
        var etq = todasEtiquetas[rnd.Next(todasEtiquetas.ToList().Count())];
        //Console.WriteLine($"\nEtiqueta random: {etq}");

        string? intento;
        int intentos = 0;

        do
        {
            Console.Write("\nAdivina la etiqueta oculta: ");
            intento = Console.ReadLine();
            intentos++;

            if (intento?.Trim().Equals(etq, StringComparison.OrdinalIgnoreCase) == true)
            {
                Console.WriteLine($"\n¡Correcto! La etiqueta oculta era '{etq}'.");
                Console.WriteLine($"🔁 Lo lograste en {intentos} intento(s).");
                break;
            }
            else
            {
                Console.WriteLine("Incorrecto. Intenta de nuevo.");
            }

        } while (true);
    }
}