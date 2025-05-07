using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class TrendingMovie: IEntity
{
    [Key]
    [Required(ErrorMessage = "IMDB Id is required")]
    [Display(Name = "IMDB ID")]
    public required int Id { get; set; }
    
    [ForeignKey("Language.Name")]
    [Required(ErrorMessage = "Please provide movie language")]
    [Display(Name = "Language name")]
    public required string Language { get; set; }
    
    [ForeignKey("Country.Name")]    
    [Required(ErrorMessage = "Please provide movie country")]
    [Display(Name = "Country of origin")]
    public required string Country { get; set; }
    
    [ForeignKey("Director.Name")]
    [Required(ErrorMessage = "Please provide movie director. Choose unknown if the director is unknown")]
    [Display(Name = "Director name")]
    public required string Director { get; set; }
    
    [ForeignKey("Actor.Name")]
    [Required(ErrorMessage = "Please provide movie lead actor")]
    [Display(Name = "Lead actor's name. Choose none is case there are no actors. Choose unknown if the actor is unknown")]
    public required string Actor { get; set; }
    
    [ForeignKey("StreamingService.Name")]
    [Display(Name = "Streaming service name (optional)")]
    public string? StreamingService { get; set; }
    
    [Required(ErrorMessage = "Please set movie active/inactive status")]
    [Display(Name = "Trending status")]
    public required bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    [ForeignKey("DefaultCategory.Name")]
    [Required(ErrorMessage = "Please provide movie genre")]
    [Display(Name = "Movie genre")]
    public required string Genre { get; set; }
}