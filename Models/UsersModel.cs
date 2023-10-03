using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Users")]
    public class UsersModel
    {
        [Key]
        [Display(Name = "ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Por favor digite o nome do irmão ou da irmã")]
        [StringLength(255, ErrorMessage = "O nome do irmão deve ter no máximo 255 caracteres")]
        [Display(Name = "Nome")]
        public string UserName { get; set; }

        [Display(Name = "Homem")]
        public bool IsMan { get; set; }

        [Display(Name = "Mulher")]
        public bool IsWoman {  get; set; }

        [Display(Name = "Data de Nascimento")]
        [Column(TypeName = "Date")]
        public DateTime UserBirthDate { get; set; }

        [Required(ErrorMessage = "Por favor digite o número de telefone do irmão ou da irmã")]
        [StringLength(11, ErrorMessage = "O número de telefone deve conter 11 caracteres e no formato 11922233333")]
        [Display(Name = "Telefone")]
        public string UserPhone { get; set; }

        [Required(ErrorMessage = "Por favor digite o email do irmão ou da irmã")]
        [StringLength(22, ErrorMessage = "O email deve conter no máximo 255 caracteres")]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

    }
}
