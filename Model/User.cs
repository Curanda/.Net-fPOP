using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Nodes;
using fPOP_REST.Interface;

namespace fPOP_REST.Model;

public class User: IEntity
{
    [Key]
    [Required(ErrorMessage = "Id is required")]
    public required int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(50, ErrorMessage = "Name can contain up to 50 characters")]
    public required string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Email is required")]
    [MaxLength(50, ErrorMessage = "Email can contain up to 50 characters")]
    public required string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Phone is required")]
    [MaxLength(15, ErrorMessage = "Phone can contain up to 15 characters")]
    [Phone(ErrorMessage = "Invalid phone number format")]
    public required string Phone { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Password is required")]
    [MaxLength(20, ErrorMessage = "Password can contain up to 20 characters")]
    public required string Password { get; set; } = string.Empty;
    
    [Column(TypeName = "nvarchar(4000)")]
    public List<string>? ChosenDefaultPreferences { get; set; }
    [Column(TypeName = "nvarchar(4000)")]
    public List<string>? UserDefinedPreferences { get; set; }
    
    [Required(ErrorMessage = "Birthday is required")]
    [Column(TypeName = "Date")]
    public required DateTime Birthday { get; set; }
    
    [Url(ErrorMessage = "Invalid URL format")]
    [MaxLength(200, ErrorMessage = "Profile picture URL can contain up to 50 characters")]
    public string? ProfilePicture { get; set; }
    
    [ForeignKey("Gender.Name")]
    [MaxLength(10, ErrorMessage= "Gender can contain up to 10 characters")]
    public string? Gender { get; set; } = string.Empty;
    
    [Column(TypeName = "nvarchar(4000)")]
    public List<string>? StarredMovies { get; set; }
    
    [Column(TypeName = "nvarchar(4000)")]
    public List<string>? FavoriteDirectors { get; set; }
    [Column(TypeName = "nvarchar(4000)")]
    public List<string>? FavoriteActors { get; set; }
    
    [ForeignKey("Religion.Name")]
    [MaxLength(20, ErrorMessage = "Religion can contain up to 20 characters")]
    public string? Religion { get; set; }
    [MaxLength(20, ErrorMessage="Country can contain up to 20 characters")]
    [ForeignKey("Country.Name")]
    public string? CountryOfBirth { get; set; }
    [MaxLength(20, ErrorMessage="Country can contain up to 20 characters")]
    [ForeignKey("Country.Name")]
    public string? CountryOfResidence { get; set; }
    [MaxLength(20, ErrorMessage="PoliticalOrientation can contain up to 20 characters")]
    [ForeignKey("PoliticalOrientation.Name")]
    public string? PoliticalOrientation { get; set; }
    [MaxLength(20, ErrorMessage="SexualOrientation can contain up to 20 characters")]
    [ForeignKey("SexualOrientation.Name")]
    public string? SexualOrientation { get; set; }
    [ForeignKey("Language.Name")]
    [Required(ErrorMessage = "Please provide first language")]
    [MaxLength(20, ErrorMessage="Language can contain up to 20 characters")]
    public required string FirstLanguage { get; set; }
    [ForeignKey("Language.Name")]
    [MaxLength(20, ErrorMessage="Language can contain up to 20 characters")]
    public string? SecondLanguage { get; set; }
    [MaxLength(20, ErrorMessage="Animal can contain up to 20 characters")]
    [ForeignKey("Animal.Name")]
    public string? FavoriteAnimal { get; set; }
}