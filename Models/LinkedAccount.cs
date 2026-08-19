namespace MyGameList.Models;

public class LinkedAccount
{
    public int Id { get; set; }
    
    // Chave Estrangeira (Qual usuário é dono desta conta?)
    public int UserId { get; set; }
    public required User User { get; set; } 

    public required string Platform { get; set; } // Ex: "Steam", "Xbox", "PSN"
    public required string PlatformAccountId { get; set; } // O ID longo na plataforma (Ex: SteamID64)
    public required string PlatformUsername { get; set; } // O Gamertag para mostrar na tela

    // Dados de autenticação (Podem ser nulos, pois a PSN, por exemplo, não usa)
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? TokenExpiresAt { get; set; }
}