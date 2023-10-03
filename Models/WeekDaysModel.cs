using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("WeekDays")]

    public class WeekDaysModel
    {
        [Key]
        [Display(Name = "ID")]
        public int WeekDayId { get; set;}

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
