using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("Episodio")]
public class Episodio
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório cadastrar o número do episódio.")]
    public int Numero { get; set; }
}
