namespace ProjetCs;

public class Step
{
    #region Attributes

    private int id;
    private string name;
    private double longitude;
    private double latitude;

    #endregion

    #region Getter/Setter

    public int Id
    {
        get => id;
        private set => id = value;
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("The role cannot be null or empty");
            }

            name = value;
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

    public Step(int id, string name, double longitude, double latitude)
    {
        Id = id;
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
    }

    #endregion
}