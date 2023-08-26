namespace Chromino;

public class Vista
{
    public void MostrarTablero(Tablero tablero)
    {
        List<List<string>> tableroDibujo = new();
        List<Ficha> fichasEnMesa = tablero.GetFichasEnMesa();
        int filaActualX = tablero.getMinX();
        int columnaActualY = tablero.getMinY();
        
        Console.WriteLine(" ----------------------- Tablero ----------------------- ");
        
        for (int i = 0; i <tablero.GetRangeX() + 1 ; i++)
        {
            List<string> listFilaActual = new();
            for (int j = 0; j < tablero.GetRangeY(); j++)
            {
                foreach (var ficha in fichasEnMesa)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (ficha.posiciones[k].Item1 == filaActualX && ficha.posiciones[k].Item2 == columnaActualY && k==0) listFilaActual.Add(ficha.valor1);
                        if (ficha.posiciones[k].Item1 == filaActualX && ficha.posiciones[k].Item2 == columnaActualY && k==1) listFilaActual.Add(ficha.valor2);
                        if (ficha.posiciones[k].Item1 == filaActualX && ficha.posiciones[k].Item2 == columnaActualY && k==2) listFilaActual.Add(ficha.valor3);
                    }
                }
                columnaActualY += 1;
            }
            columnaActualY = tablero.getMinY();
            tableroDibujo.Add(listFilaActual);
            filaActualX += 1;
        }

        foreach (var fila in tableroDibujo) Console.WriteLine("[{0}]", string.Join("][", fila));
    }

    public void MostrarMano(Jugador jugador)
    {
        List<Ficha> fichas = jugador.GetMano;
        Console.WriteLine($" ----------- Mano Jugador N {jugador.nJugador+1} -----------");
        foreach (var ficha in fichas) Console.WriteLine($"[{ficha.valor1}|{ficha.valor2}|{ficha.valor3}]");
    }
}
