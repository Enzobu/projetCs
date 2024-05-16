namespace ProjetCs;

public class Compagny
{
    #region Attributes

    private int id;
    private string name;
    private string iban;
    private List<Boat> listBoat = [];

    #endregion

    #region Getter/Setter

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Iban
    {
        get => iban;
        set
        {
            if (value.Length != 27)
            {
                throw new FormatException("IBAN invalide");
            }
            iban = value;
        }
    }

    public List<Boat> ListBoat
    {
        get => listBoat;
        set => listBoat = value ?? throw new ArgumentNullException(nameof(value));
    }

    #endregion

    #region Méthods

    

    #endregion

    #region Constuctors

    public Compagny(int id, string nom, string iban)
    {
        Id = id;
        Name = nom;
        Iban = iban;
    }

    #endregion
}