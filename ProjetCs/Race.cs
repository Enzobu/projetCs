namespace ProjetCs;

public class Race
{
    #region Attributes
    
    private double startLatitudePoint;
    private double startLongitudePoint;
    private double endLatitudePoint;
    private double endLongitudePoint;
    private List<Step> listStep = [];
    private List<RegisteredBoat> listRegisteredBoat = [];
    private DateTime dateRace;

    #endregion

    #region Getter/Setter

    public double StartLatitudePoint
    {
        get => startLatitudePoint;
        set
        {
            if (value == 0 || value == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }

            startLatitudePoint = value;
        }
    }

    public double StartLongitudePoint
    {
        get => startLongitudePoint;
        set
        {
            if (value == 0 || value == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }

            startLatitudePoint = value;
        }
    }

    public double EndLatitudePoint
    {
        get => endLatitudePoint;
        set
        {
            if (value == 0 || value == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }

            endLongitudePoint = value;
        }
    }

    public double EndLongitudePoint
    {
        get => endLongitudePoint;
        set
        {
            if (value == 0 || value == null)
            {
                throw new Exception("Entrez une valeur correcte");
            }

            endLongitudePoint = value;
        }
    }
    
    public List<Step> ListStep
    {
        get => listStep;
        set => listStep = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<RegisteredBoat> ListRegisteredBoat
    {
        get => listRegisteredBoat;
        set => listRegisteredBoat = value ?? throw new ArgumentNullException(nameof(value));
    }

    public DateTime DateRace
    {
        get => dateRace;
        set
        {
            if (value < DateTime.Now.AddDays(1))
            {
                throw new Exception("Une course ne peut pas etre crée dans le passé");
            }

            dateRace = value;
        }
    }

    #endregion
    
    #region Method

    public bool StartRace()
    {
        if (listRegisteredBoat.Count <= 1)
        {
            Console.WriteLine($"la course ne peut pas démaréer si il n'y a pas de participant");
            return false;
        }
        
        if (listStep.Count <= 1)
        {
            Console.WriteLine($"La course ne peut pas démarer si il n'y a pas au moins une étape");
            return false;
        }
        Random random = new Random();
        foreach (var boat in listRegisteredBoat)
        {
            boat.InRace = true;
            boat.RaceTime = random.Next(3000, 35500);
        }

        Console.WriteLine($"la course a été lancée");
        return true;
    }

    public string printRanking()
    {
        if (dateRace < DateTime.Now)
        {
            return "pour afficher le classement d'une course, elle doit etre passée";
        }

        string ranking = "";
        int position = 1;

        if (listRegisteredBoat.Count > 1)
        {
            listRegisteredBoat.Sort((boat1, boat2) => boat1.RealTime.CompareTo(boat2.RaceTime));
        }
        
        foreach (var boat in listRegisteredBoat)
        {
            ranking += $"{position} - {boat.Name} - {boat.RealTime} \n";
            position += 1;
        }

        return ranking;
    }

    #region CRUD Steps

    public void AddStep(List<Step> listStep)
    {
        foreach (var step in listStep)
        {
            this.listStep.Add(step);
        }
    }

    public Step SearchStep(int id)
    {
        return listStep.Find(s => s.Id == id);
    }

    public bool DeleteStep(int id)
    {
        Step step = SearchStep(id);
        if (SearchStep(id) != null)
        {
            listStep.Remove(step);
            Console.WriteLine($"l'étape avec l'id {id} a été supprimé");
            return true;
        }
        Console.WriteLine($"la pénalité avec l'id {id} est introuvable");
        return false;
    }

    #endregion

    #region CRUD RegisteredBoat

    public void AddRegisteredBoat(List<RegisteredBoat> listRegisteredBoats)
    {
        foreach (var boat in listRegisteredBoats)
        {
            this.listRegisteredBoat.Add(boat);
        }
    }

    public RegisteredBoat SearchRegisteredBoat(int id)
    {
        return listRegisteredBoat.Find(rb => rb.Id == id);
    }

    public bool DeleteRegisteredBoat(int id)
    {
        RegisteredBoat registeredBoat = SearchRegisteredBoat(id);
        if (registeredBoat != null)
        {
            ListRegisteredBoat.Remove(registeredBoat);
            Console.WriteLine($"le bateau {id} a bien été supprimé");
            return true;
        }
        Console.WriteLine($"le bateau inscrit avec l'id {id} n'a pas été trouvé");
        return false;
    }

    #endregion
    
    
    #endregion

    #region Constructor

    public Race(double startLatitudePoint, double startLongitudePoint, double endLatitudePoint, double endLongitudePoint, DateTime dateRace)
    {
        StartLatitudePoint = startLatitudePoint;
        StartLongitudePoint = startLongitudePoint;
        EndLatitudePoint = endLatitudePoint;
        EndLongitudePoint = endLongitudePoint;
        DateRace = dateRace;
    }

    #endregion
}