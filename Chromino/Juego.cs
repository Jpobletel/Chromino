namespace Chromino;

public class Juego
{
    private Tablero _tablero = new Tablero();
    private BolsaFichas _bolsaFichas = new BolsaFichas();
    private Vista _vista = new Vista();
    private Jugadores _jugadores = new Jugadores();

    public Juego() => EmpezarJuego();

    public void EmpezarJuego()
    {
        var termino = false;
        var jActual = 0;
        
        _tablero.AgregarFicha(_bolsaFichas.SacarComodinInicial());
        foreach (var jugador in _jugadores.ObtenerJugadores())
            for (var i = 0; i < 8; i++) 
                jugador.AgregarFichaAMano(_bolsaFichas.SacarFichaAlAzar());


        for (int i= 0; i < 4; i++) //Para que se muestre que se repartieron a los 4 jugadores
        {
            _vista.MostrarTablero(_tablero);
            var jugadorActual = _jugadores.ObtenerJugador(jActual);
            _vista.MostrarMano(jugadorActual);
            jActual += 1;
            if(jActual == 4) jActual = 0;
        }
        _vista.MostrarTablero(_tablero);
    }
}
