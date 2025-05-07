using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class Gender: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide gender name")]
    [MaxLength(30, ErrorMessage = "Gender name can contain up to 50 characters")]
    [Display(Name = "Gender name")]
    public required string Name { get; set; }
}