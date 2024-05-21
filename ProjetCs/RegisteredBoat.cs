namespace ProjetCs;

public class RegisteredBoat : Boat
{
    #region Attributes
    
    private bool inRace;
    private int raceTime;
    private int realTime;
    private object race;
    
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
        get => realTime;
        set => realTime = 0;
        //set raceTime + Penalty.duration
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

    #region Constructors

    public RegisteredBoat(int id, string name, object race, bool inRace = false, int raceTime = 0, int realTime = 0) : base(id, name)
    {
        InRace = inRace;
        RaceTime = raceTime;
        //RealTime = this.GetRealTime();
        Race = race;
    }

    #endregion
    
}