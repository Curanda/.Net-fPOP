using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;

namespace fPOP_REST.Model;

public class Actor : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public required int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide actor name")]
    [MaxLength(30, ErrorMessage = "Actor name can contain up to 30 characters")]
    [Display(Name = "Actor's first & last name")]
    public required string Name { get; set; }
}