namespace MyGameList.Models;

public class Game
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Developer { get; set; }
    public string CoverImageUrl { get; set; } = string.Empty; // Link para a capinha do jogo
    public DateTime? ReleaseDate { get; set; }
    
    // Relacionamento: 1 Jogo pode estar na biblioteca de vários usuários
    public List<UserGame> Owners { get; set; } = new();
}