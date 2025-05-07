using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class Country: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide country name")]
    [MaxLength(30, ErrorMessage = "Country name can contain up to 30 characters")]
    [Display(Name = "Country name")]
    public required string Name { get; set; }
}