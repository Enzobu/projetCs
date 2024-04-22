namespace ProjetCs;

public class Employee : User
{
    #region Attributes
    
    private string role;
    
    #endregion
    
    #region Getter/Setter

    public string Role
    {
        get { return role; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("The role cannot be null or empty");
            }

            role = value;
        }
    }
    
    #endregion
    
    #region Constructor
    
    public Employee(int id, string lastName, string firstName, DateTime birthdate, string role) : base(id, lastName, firstName, birthdate)
    {
        Role = role;
    }
    
    #endregion
}