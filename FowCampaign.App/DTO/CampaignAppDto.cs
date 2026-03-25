namespace FowCampaign.App.DTO;

public class CampaignAppDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime LastPlayed { get; set; }
    public string Status { get; set; }
    public string JoinCode { get; set; } = string.Empty;
}