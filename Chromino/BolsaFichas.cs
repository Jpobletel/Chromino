namespace Chromino;

public class BolsaFichas
{
    private List<Ficha> _fichas = new();
    private List<Ficha> _fichasComodines = new();
    private readonly List<string> _colores = new() { "G","R","Y","P","B" }; 
    private Random _rnd = new Random();

    public BolsaFichas()
    {
        GenerarFichas();
        Console.WriteLine(_fichas.Count);
    }

    private void GenerarFichas()
    {
        for (var index = 0; index < _colores.Count; index++)
        {
            var color1 = _colores[index];
            _fichasComodines.Add(new Ficha(color1, "C", _colores[(index + 1) % _colores.Count]));
            
            foreach (var color2 in _colores)
            {
                foreach (var color3 in _colores)
                {
                    var ficharellena = new Ficha(color1, color2, color3);
                    if (!CheckDup(ficharellena, _fichas))
                    {
                        _fichas.Add(ficharellena);
                    }
                }
            }
        }
    }

    private bool CheckDup(Ficha ficha, List<Ficha> bolsa)
    {
        foreach (var f in bolsa)
        {
            if (f.valor1 == ficha.valor1 && f.valor2 == ficha.valor2 && f.valor3 == ficha.valor3) return true;
            if (f.valor3 == ficha.valor1 && f.valor2 == ficha.valor2 && f.valor1 == ficha.valor3) return true;
        }
        return false;
    }
    
    public Ficha SacarComodinInicial()
    {
        int idFicha = _rnd.Next(_fichasComodines.Count);
        Ficha fichaSacada = _fichasComodines[idFicha];
        fichaSacada.orientacion = "V";
        var remove = _fichasComodines.Remove(fichaSacada);
        foreach (var fichaComodin in _fichasComodines)
        {
            _fichas.Add(fichaComodin);
        }
        _fichasComodines.Clear();
        return fichaSacada;
    }
    
    private Ficha SacarFichaAlAzar()
    {
        int idFicha = _rnd.Next(_fichas.Count);
        Ficha fichaSacada = _fichas[idFicha];
        _fichas.Remove(fichaSacada);
        return fichaSacada;
    }
    
    
}