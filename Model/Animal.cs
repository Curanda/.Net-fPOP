using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;

namespace fPOP_REST.Model;

public class Animal: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please provide animal name")]
    [MaxLength(30, ErrorMessage = "Animal name can contain up to 30 characters")]
    [Display(Name = "Animal name")]
    public required string Name { get; set; }
}