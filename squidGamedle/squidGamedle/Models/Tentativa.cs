using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("Tentativa")]
public class Tentativa
{
    [Key]
    public int Id { get; set; }

    public DateTime Data { get; set; }

    [Required]
    public bool Acertou { get; set; }

    public int Qtde_Tentativas { get; set; }

    [Required]
    [ForeignKey("Personagem")]
    public int Personagem_Id { get; set; }
    public Personagem Personagem { get; set; }

    [Required]
    [ForeignKey("Usuario")]
    public int Usuario_Id { get; set; }
    public Usuario Usuario { get; set; }
}