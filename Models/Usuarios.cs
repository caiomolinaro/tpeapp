using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Por favor digite o nome do irmão ou da irmã")]
        [StringLength(255, ErrorMessage = "O nome do irmão deve ter no máximo 255 caracteres")]
        [Display(Name = "Nome")]
        public string UsuarioNome { get; set; }

        [Display(Name = "Homem")]
        public bool isHomem { get; set; }

        [Display(Name = "Mulher")]
        public bool isMulher {  get; set; }

        //public DateTime UsuarioDataNascimento { get; set; }

        [Required(ErrorMessage = "Por favor digite o número de telefone do irmão ou da irmã")]
        [StringLength(11, ErrorMessage = "O número de telefone deve conter 11 caracteres e no formato 11922233333")]
        [Display(Name = "Telefone")]
        public string UsuarioTelefone { get; set; }

        [Required(ErrorMessage = "Por favor digite o email do irmão ou da irmã")]
        [StringLength(22, ErrorMessage = "O email deve conter no máximo 255 caracteres")]
        [Display(Name = "Email")]
        public string UsuarioEmail { get; set; }

    }
}
