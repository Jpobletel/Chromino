namespace Chromino;

public class Tablero
{
    private List<Ficha> _fichasEnMesa = new();
    public void AgregarFicha(Ficha ficha) => _fichasEnMesa.Add(ficha);
    
    public List<Ficha> GetFichasEnMesa() => _fichasEnMesa;
    public int getMinX()
    {
        int minX = 0;
        foreach (var ficha in _fichasEnMesa)
        {
            for (int i = 0; i < 3; i++)
            {
                if (minX > ficha.posiciones[i].Item1) minX = ficha.posiciones[i].Item1;
            }
        }

        return minX;
    }
    
    public int getMaxX()
    {
        int maxX = 0;
        foreach (var ficha in _fichasEnMesa)
        {
            for (int i = 0; i < 3; i++)
            {
                if (maxX < ficha.posiciones[i].Item1) maxX = ficha.posiciones[i].Item1;
            }
        }

        return maxX;
    }
    
    public int getMinY()
    {
        int minY = 0;
        foreach (var ficha in _fichasEnMesa)
        {
            for (int i = 0; i < 3; i++)
            {
                if (minY > ficha.posiciones[i].Item2) minY = ficha.posiciones[i].Item2;
            }
        }

        return minY;
    }
    
    public int getMaxY()
    {
        int maxY = 0;
        foreach (var ficha in _fichasEnMesa)
        {
            for (int i = 0; i < 3; i++)
            {
                if (maxY < ficha.posiciones[i].Item2) maxY = ficha.posiciones[i].Item2;
            }
        }

        return maxY;
    }

    public int GetRangeY()
    {
        if (getMaxY() - getMinY() == 0)
        {
            return 1;
        }
        return getMaxY() - getMinY();
    }
    public int GetRangeX()
    {

        return getMaxX() - getMinX();
    }

}