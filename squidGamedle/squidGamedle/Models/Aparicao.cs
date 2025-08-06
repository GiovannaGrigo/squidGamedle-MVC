using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("Aparicao")]
public class Aparicao
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório informar a descrição.")]
    public string Descricao { get; set; }

    [Required]
    [ForeignKey("Episodio")]
    public int Episodio_Id { get; set; }
    public Episodio Episodio { get; set; }

    [Required]
    [ForeignKey("Temporada")]
    public int Temporada_Id { get; set; }
    public Temporada Temporada { get; set; }
}