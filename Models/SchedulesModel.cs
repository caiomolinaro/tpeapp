using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Schedules")]
    public class SchedulesModel
    {
        [Key]
        [Display(Name = "ID")]
        public int SchedulesId { get; set; }

        [Display(Name ="Horário")]
        public string SchedulesName { get; set; }

    }
}
