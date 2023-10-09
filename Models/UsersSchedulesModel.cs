using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("UsersSchedules")]
    public class UsersSchedulesModel
    {
        [Key]
        [Display(Name = "ID")]
        public int SchedulesId { get; set; }

        [Display(Name = "Nome:")]
        public int UserId { get; set; }
        public virtual UsersModel Users { get; set; }

        [Display(Name = "Horário")]
        public string SchedulesName { get; set; }

        [Display(Name = "Segunda-Feira")]
        public bool Monday { get; set; }

        [Display(Name = "Terça-Feira")]
        public bool Tuesday { get; set; }

        [Display(Name = "Quarta-Feira")]
        public bool Wednesday { get; set; }

        [Display(Name = "Quinta-Feira")]
        public bool Thursday { get; set; }

        [Display(Name = "Sexta-Feira")]
        public bool Friday { get; set; }

        [Display(Name = "Sabado")]
        public bool Saturday { get; set; }

        [Display(Name = "Domingo")]
        public bool Sunday { get; set; }
    }
}
