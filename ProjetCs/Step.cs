namespace ProjetCs;

public class Step
{
    #region Attributes

    private int id;
    private string name;
    private double longitude;
    private double latitude;
    private List<Penalty> listPenalty = [];

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
    
    public List<Penalty> ListPenanty
    {
        get => listPenalty;
        set => listPenalty = value ?? throw new ArgumentNullException(nameof(value));
    }

    #endregion

    #region Méthods

    #region CRUD Penalty

    public void AddPenalty(List<Penalty> addListPenalty)
    {
        foreach (var penalty in addListPenalty)
        {
            listPenalty.Add(penalty);
        }
    }

    public Penalty SearchPenalty(int code)
    {
        return listPenalty.Find(p => p.Code == code);
    }

    public bool DeletePenalty(int code)
    {
        Penalty penalty = SearchPenalty(code);
        if (penalty != null)
        {
            listPenalty.Remove(penalty);
            Console.WriteLine($"la pénalité avec le code {code} a été supprimée avec succès ");
            return true;
        }
        Console.WriteLine($"la pénalité avec le code {code} est introuvable");
        return false;
    }

    #endregion

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