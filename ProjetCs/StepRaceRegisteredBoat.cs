namespace ProjetCs;

public class StepRaceRegisteredBoat
{
    #region Attributes
    
    private object registeredBoat;
    private object penalty;
    private object road;
    private object step;
    
    #endregion

    #region GetterSetter

    public object RegisteredBoat
    {
        get => registeredBoat;
        set => registeredBoat = value;
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

    public StepRaceRegisteredBoat(object registeredBoat, object penalty, object road, object step)
    {
        RegisteredBoat = registeredBoat;
        Penalty = penalty;
        Road = road;
        Step = step;
    }

    #endregion
}