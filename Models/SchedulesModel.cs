using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Schedules")]
    public class SchedulesModel
    {
        public SchedulesModel()
        {
            Points = new Collection<PointsModel>();
        }

        [Key]
        [Display(Name = "ID")]
        public int SchedulesId { get; set; }

        [Display(Name = "Nome do Horário")]
        public string SchedulesNamePrincipal { get; set; }

        [Display(Name ="Horário")]
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

        public ICollection<PointsModel> Points { get; set; }   
    }
}
