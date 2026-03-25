namespace FowCampaign.App.DTO;

public class GameStateDto
{
    public List<FactionApiDto> Factions { get; set; }
    public List<ZoneSeedApiDto> Zones { get; set; }
    public List<UnitApiDto> Units { get; set; } = new();
    public List<UnitDefinitionApiDto> UnitDefinitions { get; set; } = new();
    public string CurrentTurnFaction { get; set; } = string.Empty;
    public int TurnNumber { get; set; }
}