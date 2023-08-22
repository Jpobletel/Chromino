namespace Chromino;

public class Ficha
{
    public string valor1 { get; }
    public string valor2 { get; }
    public string valor3 { get; }

    public List<(int, int)> posiciones = new();
    
    public string orientacion = "null";

    public Ficha(string valor1, string valor2, string valor3)
    {
        this.valor1 = valor1;
        this.valor2 = valor2;
        this.valor3 = valor3;
    }
}