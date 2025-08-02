using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace squidGamedle.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "É obrigatório ter um nome.")]
    [StringLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "É obrigatório ter uma senha.")]
    [StringLength(100, MinimumLength = 4, ErrorMessage = "A senha deve ter entre {2} e {1} caracteres.")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [StringLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
    public string Imagem { get; set; }

    [StringLength(100, ErrorMessage = "O limite máximo de caracteres é 100.")]
    public string Cargo { get; set; }
}