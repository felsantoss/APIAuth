public static class UserRepository
{
    public static User Get(string username, string password)
    {
        var users = new List<User>
        {
            new User {Id = 1, Username = "Goku", Password = "Teste123", Role = "manager"},
            new User {Id = 2, Username = "Gohan", Password = "Teste1234", Role = "employee"}
        };
        return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password.Equals(password)).FirstOrDefault();
    }
}