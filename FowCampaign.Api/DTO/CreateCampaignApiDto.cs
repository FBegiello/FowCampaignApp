namespace FowCampaign.Api.DTO;

public class CreateCampaignApiDto
{
    public string Name { get; set; }
    public IFormFile MapImage { get; set; }
    public string GameStateJson { get; set; }
    public string CreatorFactionName { get; set; }
}