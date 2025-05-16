using System.ComponentModel.DataAnnotations;

namespace fPOP_REST.Utilities;

public class UserProfileUpdateDto
{

    [MaxLength(50, ErrorMessage = "Name can contain up to 50 characters")]
    public string Name { get; set; } = string.Empty;
    
    
    [MaxLength(50, ErrorMessage = "Email can contain up to 50 characters")]
    public string Email { get; set; } = string.Empty;
    
    
    [MaxLength(15, ErrorMessage = "Phone can contain up to 15 characters")]
    [Phone(ErrorMessage = "Invalid phone number format")]
    public string Phone { get; set; } = string.Empty;
    
    
    [MaxLength(20, ErrorMessage = "Password can contain up to 20 characters")]
    public string Password { get; set; } = string.Empty;
    
    
    [MaxLength(15, ErrorMessage = "Birthday can contain up to 15 characters")]
    public string Birthday { get; set; } = string.Empty;
    
    
    [MaxLength(20, ErrorMessage="Language can contain up to 20 characters")]
    public string FirstLanguage { get; set; } = string.Empty;
    
    [MaxLength(500)]
    [Url(ErrorMessage = "Invalid URL format")]
    public string? ProfilePicture { get; set; }
    
    [MaxLength(10)]
    public string? Gender { get; set; }
    
    public List<string>? ChosenDefaultPreferences { get; set; }
    public List<string>? UserDefinedPreferences { get; set; }
    public List<string>? StarredMovies { get; set; }
    public List<string>? FavoriteDirectors { get; set; }
    public List<string>? FavoriteActors { get; set; }
    
    [MaxLength(20)]
    public string? Religion { get; set; }
    
    [MaxLength(20)]
    public string? CountryOfBirth { get; set; }
    
    [MaxLength(20)]
    public string? CountryOfResidence { get; set; }
    
    [MaxLength(20)]
    public string? PoliticalOrientation { get; set; }
    
    [MaxLength(20)]
    public string? SexualOrientation { get; set; }
    
    [MaxLength(20)]
    public string? SecondLanguage { get; set; }
    
    [MaxLength(20)]
    public string? FavoriteAnimal { get; set; }
}