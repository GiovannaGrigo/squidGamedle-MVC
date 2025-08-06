using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("Personagem")]
public class Personagem
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o nome.")]
    [StringLength(50, ErrorMessage = "O limite máximo de caracteres é 50.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "É obrigatório que o personagem tenha uma imagem.")]
    [StringLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
    public string Imagem { get; set; }

    public bool Vivo { get; set; }

    public bool Matou { get; set; }

    [Required]
    [ForeignKey("Genero")]
    public int Genero_Id { get; set; }
    public Genero Genero { get; set; }

    [Required]
    [ForeignKey("Aparicao")]
    public int Aparicao_Id { get; set; }
    public Aparicao Aparicao { get; set; }

    [Required]
    [ForeignKey("UltimaAparicao")]
    public int UltimaAparicao_Id { get; set; }
    public UltimaAparicao UltimaAparicao { get; set; }
}