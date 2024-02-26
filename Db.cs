public record User 
{
    public int Id {get; set;}
    public string ? Username {get; set;}
    public string ? Password {get; set;}
    public bool ? Admin {get; set;}
}

public class UserDB
{
    private static List<User> _user = new List<User>()
    {
        
    };

    public static User CreateUser(User user)
    {
        _user.Add(user);
        return user;
    }
}