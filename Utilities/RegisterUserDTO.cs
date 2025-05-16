using System.ComponentModel.DataAnnotations;

namespace fPOP_REST.Utilities;

public class RegisterUserDto
{
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(50)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    [Phone]
    public string Phone { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(20)]
    public string Password { get; set; } = string.Empty;
    
    [Required]
    public string Birthday { get; set; } = string.Empty;
    
    [Required]
    public string FirstLanguage { get; set; } = string.Empty;
    
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
    
    [MaxLength(10)]
    public string? Gender { get; set; }
    
    public List<string>? ChosenDefaultPreferences { get; set; }
    public List<string>? UserDefinedPreferences { get; set; }
    public List<string>? FavoriteDirectors { get; set; }
    public List<string>? FavoriteActors { get; set; }
}
