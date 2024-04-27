namespace ProjetCs;

public class Boat
{
    #region Attributes
    
    private int id;
    private string name;
    private List<User> listUser = [];

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
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Entrez un nom valide pour votre bateau");
            }

            name = value;
        }
    }

    public List<User> ListUser
    {
        get => listUser;
        set => listUser = value ?? throw new ArgumentNullException(nameof(value));
    }

    #endregion
    
    #region Methods

    public string CrewToString()
    {
        string user = "";
        foreach (var participant in listUser)
        {
            user += participant.FirstName + " " + participant.LastName + ", ";
        }

        return user;
    }

    public void Presentation()
    {
        string crew = CrewToString();
        Console.WriteLine("nom du bateau : {0}, équipage : {1}", this.id, crew);
    } 
    
    public void AddUsers(List<User> listUsers)
    {
        //vérifier si user existe avant ajouter ???
        if (listUsers.Count < 3 || listUsers.Count > 10)
        {
            throw new Exception("le nombre de participant dans le bateau doit etre compris entre 3 et 10");
        }
        
        foreach (var user in listUsers)
        {
            listUser.Add(user);
        }
    }

    public User SearchUser(int id)
    {
        return listUser.Find(u => u.Id == id);
    }

    public bool DeleteUser(int id)
    {
        User user = SearchUser(id);
        if (user != null)
        {
            listUser.Remove(user);
            Console.WriteLine("utilisateur {0} supprimé avec succès");
            return true;
        }

        throw new Exception($"l'utilisateur avec l'id {id} est introuvale");
    }
    
    #endregion
    
    #region Constructor

    public Boat(int id, string name)
    {
        Id = id;
        Name = name;
    }

    #endregion


}