namespace FowCampaign.App.DTO;

public class GameStateAppDto
{
    public List<FactionAppDto> Factions { get; set; }
    public List<ZoneSeedAppDto> Zones { get; set; }
    public List<UnitAppDto> Units { get; set; } = new();
    public List<UnitDefinitionAppDto> UnitDefinitions { get; set; } = new();
    public string CurrentTurnFaction { get; set; } = string.Empty;
    public int TurnNumber { get; set; }
}