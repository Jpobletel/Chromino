namespace Chromino;

public class Juego
{
    public Juego()
    {
        var tablero = new Tablero();
        var bolsaFichas = new BolsaFichas();
        tablero.AgregarFicha(bolsaFichas.SacarComodinInicial());
    }
}
dfs+} s