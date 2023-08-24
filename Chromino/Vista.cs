namespace Chromino;

public class Vista
{
    public void MostrarTablero(Tablero tablero)
    {
        List<Ficha> fichasEnMesa = tablero.GetFichasEnMesa();
        foreach (var ficha in fichasEnMesa) Console.WriteLine(ficha.valor1 + " " + ficha.valor2 + " " + ficha.valor3);
    }

    public void MostrarMano(Jugador jugador)
    {
        if (jugador == null) return;
        List<Ficha> fichas = jugador.GetMano;
        foreach (var ficha in fichas)
        {
            Console.WriteLine($"[{ficha.valor1}|{ficha.valor2}|{ficha.valor3}]");
        }
    }
}