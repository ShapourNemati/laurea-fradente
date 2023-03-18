using System.Security.Claims;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var claims = new List<Claim>();

        claims.Add(new Claim("Name", "Fradente"));

        Console.WriteLine("Goodbye, World!");
    }
}