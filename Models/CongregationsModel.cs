using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Congregations")]
    public class CongregationsModel
    {
        public CongregationsModel()
        {
            Users = new Collection<UsersModel>();  
        }

        [Key]
        [Display(Name = "ID")]
        public int CongregationId { get; set; }

        [Display(Name = "Nome da congregação")]
        public string CongregationName { get; set; }

        [Display(Name = "Circuito")]
        public int CircuitId { get; set; }

        public virtual CircuitsModel Circuits { get; set; }

        public ICollection<UsersModel> Users { get; set; }
         
    }
}
