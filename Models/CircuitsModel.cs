using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Circuits")]
    public class CircuitsModel
    {
        public CircuitsModel()
        {
            Congregations = new Collection<CongregationsModel>();       
        }

        [Key]
        [Display(Name = "ID")]
        public int CircuitId { get; set; }

        [Display(Name = "Nome do circuito")]
        public string CircuitName { get; set; }
        public ICollection<CongregationsModel> Congregations { get; set;}
    }
}
