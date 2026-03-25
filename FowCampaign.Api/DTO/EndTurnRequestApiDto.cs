namespace FowCampaign.App.DTO;

public class EndTurnRequestApiDto
{
    public List<UnitApiDto> Units { get; set; } = new();
    public List<ZoneSeedApiDto> Zones { get; set; } = new();
}