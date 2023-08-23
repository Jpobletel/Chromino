namespace Chromino;

public class Tablero
{
    private List<Ficha> _fichasEnMesa = new();
    public void AgregarFicha(Ficha ficha) => _fichasEnMesa.Add(ficha);
    
    public List<Ficha> GetFichasEnMesa() => _fichasEnMesa;

}