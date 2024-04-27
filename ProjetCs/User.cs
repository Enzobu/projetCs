namespace ProjetCs;

public abstract class User
{
    #region Attributes

        private int id;
        private string lastName;
        private string firstName;
        private DateTime birthdate;

    #endregion

    #region Getter/Setter

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }

    public string LastName
    {
        get { return lastName; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("The lastname cannot be null or empty");
            }

            lastName = value;
        }
    }

    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("The firstname cannot be null or empty");
            }

            firstName = value;
        }
    }

    public DateTime Birthdate
    {
        get { return birthdate;  }
        private set
        {
            if (CalculateAge(value) < 16)
            {
                throw new Exception("The user must be at least 16 years old to register");
            }

            birthdate = value;
        }
    }

    #endregion

    #region Méthods

    private int CalculateAge(DateTime birthDate)
    {
        DateTime now = DateTime.Today;
        int age = now.Year - birthDate.Year;
        if (now < birthDate.AddYears(age))
        {
            age--;
        }
        return age;
    }

    public void Presentation()
    {
        Console.WriteLine("id : {0}, firstName : {1}, lastName : {2}", this.id, this.firstName, this.lastName);
    }

    #endregion

    #region Constuctors

    protected User(int id, string lastName, string firstName, DateTime birthdate)
    {
        Id = id;
        LastName = lastName;
        FirstName = firstName;
        Birthdate = birthdate;
    }

    #endregion

}