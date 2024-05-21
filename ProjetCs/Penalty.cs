namespace ProjetCs;

public class Penalty
{
    #region Attributes

    private int code;
    private int duration;
    private double longitude;
    private double latitude;

    #endregion

    #region Getter/Setter

    public int Code
    {
        get => code;
        private set => code = value;
    }

    public int Duration
    {
        get => duration;
        private set
        {
            if (value < 0)
            {
                throw new Exception("Valeurs inférieure à 0");
            }
            duration = value;
        }
    }

    public double Longitude
    {
        get => longitude;
        private set => longitude = value;
    }

    public double Latitude
    {
        get => latitude;
        private set => latitude = value;
    }

    #endregion

    #region Méthods

    

    #endregion

    #region Constuctors

    public Penalty(int code, int duration, double longitude, double latitude)
    {
        Code = code;
        Duration = duration;
        Longitude = longitude;
        Latitude = latitude;
    }

    #endregion

}