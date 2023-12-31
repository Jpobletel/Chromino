using System.Collections;

namespace Chromino;

public class Jugadores
{
    private List<Jugador> _jugadores;

    public List<Jugador> ObtenerJugadores() => _jugadores;

    public Jugadores()
    {
        _jugadores = new List<Jugador>();
        for(int i = 0; i < 4; i++)
            _jugadores.Add(new Jugador(i));
    }
    public Jugador ObtenerJugador(int idJugador) => _jugadores[idJugador];
    
}