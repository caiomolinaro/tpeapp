using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Congregations")]
    public class CongregationsModel
    {
        [Key]
        [Display(Name = "ID")]
        public int CongregationId { get; set; }

        [Display(Name = "Nome da congregação")]
        public string CongregationName { get; set; }

        [Display(Name = "Nome do circuito")]
        public int CircuitId { get; set; }

        public virtual CircuitsModel Circuits { get; set; }

        //ENTENDER PQ NA VIEW ELE NÃO DEIXA SELECIONAR O NOME DO CIRCUITO

    }
}
