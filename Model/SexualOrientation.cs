using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class SexualOrientation: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide sexual orientation name")]
    [MaxLength(30, ErrorMessage = "Sexual orientation name can contain up to 30 characters")]
    [Display(Name = "Sexual orientation name")]
    public required string Name { get; set; }
}