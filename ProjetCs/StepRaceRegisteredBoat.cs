namespace ProjetCs;

public class StepRaceRegisteredBoat
{
    #region Attributes
    
    private int idBoat;
    private int idPenalty;
    private int idRoad;
    private int idStep;
    
    #endregion

    #region GetterSetter

    public int IdBoat
    {
        get => idBoat;
        set => idBoat = value;
    }

    public int IdPenalty
    {
        get => idPenalty;
        set => idPenalty = value;
    }

    public int IdRoad
    {
        get => idRoad;
        set => idRoad = value;
    }

    public int IdStep
    {
        get => idStep;
        set => idStep = value;
    }

    #endregion
    
    #region Constructor

    public StepRaceRegisteredBoat(int idBoat, int idPenalty, int idRoad, int idStep)
    {
        IdBoat = idBoat;
        IdPenalty = idPenalty;
        IdRoad = idRoad;
        IdStep = idStep;
    }

    #endregion
}