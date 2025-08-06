using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("PersonagemMortes")]
public class PersonagemMortes
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey("Assassino")]
    public int Assassino_Id { get; set; }
    public Personagem Assassino { get; set; }

    [Required]
    [ForeignKey("Vitima")]
    public int Vitima_Id { get; set; }
    public Personagem Vitima { get; set; }
}