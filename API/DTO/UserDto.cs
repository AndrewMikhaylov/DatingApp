namespace API.DTO;

public class UserDto
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string DisplayName { get; set; }
    
    public required string Token { get; set; }

    public string? ImageURL { get; set; }

}