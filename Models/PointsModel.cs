using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Points")]
    public class PointsModel
    {
        [Key]
        [Display (Name = "ID")]
        public int PointId { get; set; }

        [Display(Name = "Nome do ponto")]
        public string PointName { get; set; }

    }
}
