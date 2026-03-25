namespace FowCampaign.App.DTO;

public class EndTurnRequestAppDto
{
    public List<UnitAppDto> Units { get; set; } = new();
    public List<ZoneSeedAppDto> Zones { get; set; } = new();
}