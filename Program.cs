using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        decimal valor = 10589.25m;
        
       // Console.WriteLine(valor.ToString());
        Console.WriteLine(
            valor.ToString(
                "C",
        CultureInfo.CreateSpecificCulture("pt-BR")));
    }   
}s