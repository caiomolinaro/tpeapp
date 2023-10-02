using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Pontos")]
    public class Pontos
    {
        [Key]
        public int PontosId { get; set; }
        public string pontosNome { get; set; }

    }
}
