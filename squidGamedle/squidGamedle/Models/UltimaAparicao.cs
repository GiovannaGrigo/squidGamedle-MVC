using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("UltimaAparicao")]
public class UltimaAparicao
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório cadastrar o nome em Inglês.")]
    [StringLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
    public string Nome_En { get; set; }

    [Required(ErrorMessage = "É obrigatório cadastrar o nome em Português.")]
    [StringLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
    public string Nome_Pt { get; set; }
}