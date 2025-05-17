using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fPOP_REST.Model;

public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    
    public string ImdbId { get; set; } = string.Empty;
    
    public string Title { get; set; } = string.Empty;
    
    public string Year { get; set; } = string.Empty;
    
    public string Rating { get; set; } = string.Empty;
    
    public string Poster { get; set; } = string.Empty;
    
    public string Plot { get; set; } = string.Empty;
    
    public string Actors { get; set; } = string.Empty;

    [ForeignKey("Language.Name")]
    public required string Language { get; set; }
    
    [ForeignKey("Country.Name")]    
    public required string Country { get; set; }
    
    [ForeignKey("Director.Name")]
    public required string Director { get; set; }
    
    
    [ForeignKey("DefaultCategory.Name")]
    public required string Genre { get; set; }
}