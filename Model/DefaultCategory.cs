using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class DefaultCategory: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide default preferences name")]
    [MaxLength(30, ErrorMessage = "Default preferences name can contain up to 30 characters")]
    [Display(Name = "Default preferences name")]
    public required string Name { get; set; }
}