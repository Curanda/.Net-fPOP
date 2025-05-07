using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using fPOP_REST.Interface;
namespace fPOP_REST.Model;

public class ImageStore: IEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Column(TypeName = "varbinary(max)")]
    public required byte[] ImageData { get; set; }
    
    public required string Name { get; set; }
}