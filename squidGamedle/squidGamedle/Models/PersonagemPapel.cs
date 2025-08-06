using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("PersonagemPapel")]
public class PersonagemPapel
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Personagem")]
    public int Personagem_Id { get; set; }
    public Personagem Personagem { get; set; }

    [Required]
    [ForeignKey("Papel")]
    public int Papel_Id { get; set; }
    public Papel Papel { get; set; }
}