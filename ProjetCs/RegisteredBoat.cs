namespace ProjetCs;

public class RegisteredBoat : Boat
{
    #region Attributes
    
    private bool inRace;
    private int raceTime;
    private int realTime;
    private object race;
    private List<Penalty> listPenalty = [];
    
    #endregion
    
    #region Getter/Setter
    public bool InRace
    {
        get => inRace;
        set => inRace = value;
    }

    public int RaceTime
    {
        get => raceTime;
        set => raceTime = value;
    }

    public int RealTime
    {
        get => CalculateRealTime();
        set => CalculateRealTime();
    }

    public List<Penalty> ListPenalty
    {
        get => listPenalty;
        set => listPenalty = value ?? throw new ArgumentNullException(nameof(value));
    }

    public object Race
    {
        get => race;
        set
        {
            if (value is Race setterRace && setterRace.DateRace > DateTime.Now)
            {
                race = value;
            }
            else
            {
                throw new Exception("impossible de s'inscrire a une course passée");
            }
        }
    }
    
    #endregion
    
    #region méthods

    public bool GivePenalty(Penalty penalty)
    {
        foreach (var penaltyItem in listPenalty)
        {
            if (penalty.Code == penaltyItem.Code)
            {
                return false;
            }
        }
        listPenalty.Add(penalty);

        return true;
    }

    public void RemovePenalty(Penalty penalty)
    {
        listPenalty.Remove(penalty);
    }

    private int CalculateRealTime()
    {
        int realTimeToSet = raceTime;
            
        foreach (var penalty in listPenalty)
        {
            realTimeToSet += penalty.Duration;
        }

        return realTimeToSet;

    }
    
    #endregion

    #region Constructors

    public RegisteredBoat(int id, string name, object race, bool inRace = false, int raceTime = 0, int realTime = 0) : base(id, name)
    {
        InRace = inRace;
        RaceTime = raceTime;
        Race = race;
    }

    #endregion
    
}