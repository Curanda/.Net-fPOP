using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class PoliticalOrientation: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide political view name")]
    [MaxLength(30, ErrorMessage = "Political view name can contain up to 30 characters")]
    [Display(Name = "Political view name")]
    public required string Name { get; set; }
}