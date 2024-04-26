namespace ProjetCs;

public class Race
{
    #region Attributes
    
    private double startLatitudePoint;
    private double startLongitudePoint;
    private double endLatitudePoint;
    private double endLongitudePoint;
    private string sponsor;

    #endregion

    #region Getter/Setter

    public double StartLatitudePoint
    {
        get => startLatitudePoint;
        set
        {
            if (startLatitudePoint == 0 || startLatitudePoint == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }
        }
    }

    public double StartLongitudePoint
    {
        get => startLongitudePoint;
        set
        {
            if (startLongitudePoint == 0 || startLongitudePoint == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }
        }
    }

    public double EndLatitudePoint
    {
        get => endLatitudePoint;
        set
        {
            if (endLatitudePoint == 0 || endLatitudePoint == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }
        }
    }

    public double EndLongitudePoint
    {
        get => endLongitudePoint;
        set
        {
            if (endLongitudePoint == 0 || endLongitudePoint == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }
        }
    }

    public string Sponsor
    {
        get => sponsor;
        set => sponsor = value ?? throw new ArgumentNullException(nameof(value));
    }

    #endregion

    #region Constructor

    public Race(double startLatitudePoint, double startLongitudePoint, double endLatitudePoint, double endLongitudePoint, string sponsor)
    {
        StartLatitudePoint = startLatitudePoint;
        StartLongitudePoint = startLongitudePoint;
        EndLatitudePoint = endLatitudePoint;
        EndLongitudePoint = endLongitudePoint;
        Sponsor = sponsor;
    }

    #endregion
}