using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Congregacoes")]
    public class Congregacoes
    {
        [Key]
        public int CongregacaoId { get; set; }

        public string CongregacaoNome { get; set; }
    }
}
