using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fPOP_REST.Model;

public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
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
    
    
    

    
    [ForeignKey("DefaultCategory.Name")]
    [Required(ErrorMessage = "Please provide movie genre")]
    [Display(Name = "Movie genre")]
    public required string Genre { get; set; }
}