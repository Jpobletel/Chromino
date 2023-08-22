namespace Chromino;

public class Jugador
{
    private List<Ficha> _mano = new();
    public List<Ficha> mano => _mano;
    public void AgregarFichaAMano(Ficha ficha) => _mano.Add(ficha);
    public void SacarFichaDeMano(Ficha ficha) => _mano.Remove(ficha);
    public bool TieneFichasEnMano() => _mano.Any();
    
    
}