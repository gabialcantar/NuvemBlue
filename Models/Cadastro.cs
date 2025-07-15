using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NuvemBlue.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o seu nome")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o seu E-mail")]
        [StringLength(150)]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o seu Telefone")]
        [StringLength(20)]
        [Phone(ErrorMessage = "Telefone inválido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o seu Endereço")]
        [StringLength(200)]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Obrigatório criar uma senha com 6 digitos")]
        public string Senha { get; set; }
    }
}
