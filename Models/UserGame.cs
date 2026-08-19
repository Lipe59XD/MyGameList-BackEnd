namespace MyGameList.Models;

public class UserGame
{
    public int Id { get; set; }
    
    // Chave Estrangeira: O Dono
    public int UserId { get; set; }
    public required User User { get; set; }

    // Chave Estrangeira: O Jogo
    public int GameId { get; set; }
    public required Game Game { get; set; }

    public required string Platform { get; set; } // Ex: "Steam" ou "PSN"
    public int PlaytimeMinutes { get; set; }
    public int UnlockedAchievements { get; set; }
    
    public DateTime? LastPlayedAt { get; set; } // Última vez que ele abriu o jogo
    public DateTime SyncedAt { get; set; } = DateTime.UtcNow; // Última vez que seu robô atualizou isso
}