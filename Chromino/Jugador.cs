namespace Chromino;

public class Jugador
{
    private List<Ficha> _mano = new();

    public int nJugador;


    public List<Ficha> GetMano => _mano;
    public void AgregarFichaAMano(Ficha ficha) => _mano.Add(ficha);
    public void SacarFichaDeMano(Ficha ficha) => _mano.Remove(ficha);
    public bool TieneFichasEnMano() => _mano.Any();
    
    public Jugador(int nJugador) => this.nJugador = nJugador;
}