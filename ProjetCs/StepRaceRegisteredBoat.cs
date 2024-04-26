namespace ProjetCs;

public class StepRaceRegisteredBoat
{
    #region Attributes
    
    private object boat;
    private object penalty;
    private object road;
    private object step;
    
    #endregion

    #region GetterSetter

    public object Boat
    {
        get => boat;
        set => boat = value;
    }

    public object Penalty
    {
        get => penalty;
        set => penalty = value;
    }

    public object Road
    {
        get => road;
        set => road = value;
    }

    public object Step
    {
        get => step;
        set => step = value;
    }

    #endregion
    
    #region Constructor

    public StepRaceRegisteredBoat(object boat, object penalty, object road, object step)
    {
        Boat = boat;
        Penalty = penalty;
        Road = road;
        Step = step;
    }

    #endregion
}