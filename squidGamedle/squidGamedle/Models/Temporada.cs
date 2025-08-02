using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("Temporada")]
public class Temporada
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório cadastrar o número da temporada.")]
    public int Numero { get; set; }
}