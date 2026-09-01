using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace Services.RawgDTO;

//Data Transfer Object para tratar o json recebido do rawg
public class RawgGameItemDTO()
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    [JsonPropertyName("background_image")]
    public string? BackgroundImage { get; set; }

}
//compila a resposta do Rawg em uma lista de varios RawgGameItemDTO
public class RawgSearchResponseDTO()
{
    [JsonPropertyName("results")]
    public List<RawgGameItemDTO> Results { get; set; } = new();
}

//modelo limpo que sera enviado para o frontend
public class GameSummaryDTO()
{
    public int Id {get; set; }
    public string Title {get; set;} = string.Empty;
    public string CoverUrl { get; set; } = string.Empty;
}

