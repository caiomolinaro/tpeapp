using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Circuits")]
    public class CircuitsModel
    {
        [Key]
        [Display(Name = "ID")]
        public int CircuitId { get; set; }

        [Display(Name = "Nome do circuito")]
        public string CircuitName { get; set; }

        public List<CongregationsModel> Congregations { get; set; }
        //ENTENDER PQ NA VIEW ELE NÃO DEIXA SELECIONAR O NOME DO CIRCUITO
    }
}
