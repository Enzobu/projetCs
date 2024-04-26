namespace ProjetCs;

public class RegisteredBoat : Boat
{
    #region Attributes
    
    private bool inRace;
    private int raceTime;
    private int realTime;
    
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
        set => realTime = 0;
        //set raceTime + Penalty.duration
    }
    
    #endregion

    #region Constructors

    public RegisteredBoat(int id, bool inRace, int raceTime, int realTime) : base(id)
    {
        InRace = inRace;
        RaceTime = raceTime;
        //RealTime = this.GetRealTime();
    }

    #endregion
    
}