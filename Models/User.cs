namespace MyGameList.Models;

public class User
{
    public int Id { get; set; }
    public required string  Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<LinkedAccount> LinkedAccounts { get; set; } = new();
    public List<UserGame> GamesLibrary { get; set; } = new();

}