namespace fPOP_REST.Utilities;
using System.ComponentModel.DataAnnotations;

public class MovieRequierementsDto
{
    public string Birthday { get; set; } = string.Empty;
    
    public string FirstLanguage { get; set; } = string.Empty;
    
    public string? Gender { get; set; }
    
    public List<string>? ChosenDefaultPreferences { get; set; }
    public List<string>? UserDefinedPreferences { get; set; }
    public List<string>? FavoriteDirectors { get; set; }
    public List<string>? FavoriteActors { get; set; }
    

    public string? Religion { get; set; }
    

    public string? CountryOfBirth { get; set; }
    

    public string? CountryOfResidence { get; set; }
    

    public string? PoliticalOrientation { get; set; }
    

    public string? SexualOrientation { get; set; }

    public string? SecondLanguage { get; set; }
    
    public string? FavoriteAnimal { get; set; }
}