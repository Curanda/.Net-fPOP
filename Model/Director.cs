using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class Director: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide director name")]
    [MaxLength(30, ErrorMessage = "Director name can contain up to 30 characters")]
    [Display(Name = "Director's first & last name")]
    public required string Name { get; set; }
}