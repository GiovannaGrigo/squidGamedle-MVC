using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("PersonagemDiario")]
public class PersonagemDiario
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime Data { get; set; }
    
    [Required]
    [ForeignKey("Personagem")]
    public int Personagem_Id { get; set; }
    public Personagem Personagem { get; set; }
}