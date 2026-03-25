namespace FowCampaign.Api.DTO;

public class RegisterApiDto
{
    public string Username { get; set; }
    public string Password { get; set; }

    public string ConfirmPassword { get; set; }
}