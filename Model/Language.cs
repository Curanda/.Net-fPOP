using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class Language: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide language name")]
    [MaxLength(30, ErrorMessage = "Language name can contain up to 30 characters")]
    [Display(Name = "Language name")]
    public required string Name { get; set; }
}