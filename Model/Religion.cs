using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class Religion: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide religion name")]
    [MaxLength(30, ErrorMessage = "Religion name can contain up to 50 characters")]
    [Display(Name = "Religion name")]
    public required string Name { get; set; } = string.Empty;
}