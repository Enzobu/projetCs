namespace ProjetCs;

public class Boat
{
    #region Attributes
    
    private int id;
    private string name;
    private List<User> listUser = [];
    private List<Compagny> listCompagny = [];

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

    public List<Compagny> ListCompagny
    {
        get => listCompagny;
        set => listCompagny = value ?? throw new ArgumentNullException(nameof(value));
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

    public string CompagnyToString()
    {
        string compagny = "";
        foreach (var compagnies in listCompagny)
        {
            compagny += compagnies.Nom + ", ";
        }

        return compagny;
    }

    public void Presentation()
    {
        string crew = CrewToString();
        string compagny = CompagnyToString();
        Console.WriteLine("nom du bateau : {0}, équipage : {1}, sponsor : {2}", this.id, crew, compagny);
    }

    #region CRUD User
    
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
            Console.WriteLine($"utilisateur {user.FirstName} {user.LastName} a été supprimé du bateau {this.name}");
            return true;
        }

        throw new Exception($"l'utilisateur avec l'id {id} est introuvale");
    }
    
    #endregion

    #region CRUD Compagnies

    public void AddCompagny(List<Compagny> addCompagnyList)
    {
        foreach (var compagny in addCompagnyList)
        {
            listCompagny.Add(compagny);
            Console.WriteLine($"l'entreprise {compagny.Nom} a été ajouté comme sponsor au bateau {this.name}");
        }
    }

    public Compagny SearchCompagny(int id)
    {
        return listCompagny.Find(c => c.Id == id);
    }

    public bool deleteCompagny(int id)
    {
        Compagny compagny = SearchCompagny(id);
        if (compagny != null)
        {
            listCompagny.Remove(compagny);
            Console.WriteLine($"le sponsor {compagny.Nom} a été supprimé pour le bateau {this.name}");
            return true;
        }

        throw new Exception($"le sponsor avec l'id {compagny.Id} est introuvable");
    }

    #endregion
    
    
    
    #endregion
    
    #region Constructor

    public Boat(int id, string name)
    {
        Id = id;
        Name = name;
    }

    #endregion


}