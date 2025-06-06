using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class StreamingService : IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please provide streaming service name")]
    [MaxLength(30, ErrorMessage = "Streaming service name can contain up to 30 characters")]
    [Display(Name = "Streaming service name")]
    public required string Name { get; set; }
}