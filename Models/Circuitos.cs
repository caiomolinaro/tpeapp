using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Circuitos")]
    public class Circuitos
    {
        [Key]
        public int CircuitoId { get; set; }

        public string CircuitoNome { get; set; }
    }
}
