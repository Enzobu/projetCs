namespace ProjetCs;

public class Boat
{
    #region Attributes
    
    private int id;
    private List<User> listUser = [];

    #endregion

    #region Getter/Setter

    public int Id
    {
        get => id;
        set => id = value;
    }

    public List<User> ListUser
    {
        get => listUser;
        set => listUser = value ?? throw new ArgumentNullException(nameof(value));
    }

    #endregion
    
    #region Constructor

    public Boat(int id)
    {
        Id = id;
    }

    #endregion


}