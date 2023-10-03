using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Horarios")]
    public class Schedules
    {
        [Key]
        public int HorariosId { get; set; }

        public string TimeName { get; set; }

    }
}
