namespace ProjetCs;

public class Participant : User
{
    #region Attributes

    private int boatNumber;

    #endregion
    
    #region Getter/Setter

    public int BoatNumber
    {
        get => boatNumber;
        set => boatNumber = value;
    }

    #endregion

    #region Constructor

    public Participant(int id, string lastName, string firstName, DateTime birthdate) : base(id, lastName, firstName, birthdate)
    {
        BoatNumber = boatNumber;
    }

    #endregion
}