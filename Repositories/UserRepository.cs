public static class UserRepository
{
    public static User Get(string username, string password)
    {
        var users = new List<User>
        {
            new User {Id = 1, Username = "goku", Password = "goku", Role = "manager"},
            new User {Id = 2, Username = "gohan", Password = "gohan", Role = "employee"}
        };
        return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
    }
}