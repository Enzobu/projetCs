namespace ProjetCs;

public class Race
{
    #region Attributes
    
    private double startLatitudePoint;
    private double startLongitudePoint;
    private double endLatitudePoint;
    private double endLongitudePoint;
    private List<Step> listStep = [];
    private List<Participant> listParticipant = [];

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

    public List<Participant> ListParticipant
    {
        get => listParticipant;
        set => listParticipant = value ?? throw new ArgumentNullException(nameof(value));
    }

    #endregion
    
    #region Method

    public void SetStep(List<Step> listStep)
    {
        foreach (var step in listStep)
        {
            this.listStep.Add(step);
        }
    }
    
    public void SetParticipant(List<Participant> listParticipant)
    {
        foreach (var participant in listParticipant)
        {
            this.listParticipant.Add(participant);
        }
    }
    
    #endregion

    #region Constructor

    public Race(double startLatitudePoint, double startLongitudePoint, double endLatitudePoint, double endLongitudePoint)
    {
        StartLatitudePoint = startLatitudePoint;
        StartLongitudePoint = startLongitudePoint;
        EndLatitudePoint = endLatitudePoint;
        EndLongitudePoint = endLongitudePoint;
    }

    #endregion
}