namespace Chromino;

public class Juego
{
    public Juego()
    {
        var tablero = new Tablero();
        var bolsaFichas = new BolsaFichas();
        var vista = new Vista();
        tablero.AgregarFicha(bolsaFichas.SacarComodinInicial());
        vista.MostrarTablero(tablero);
    }
}