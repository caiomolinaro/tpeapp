using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Privilegios")]
    public class Privilegios
    {
        public int PrivilegiosId { get; set; }
        public bool IsPublicador { get; set; }
        public bool IsPioneiro { get; set; }
        public bool IsServo { get; set; }
        public bool IsAnciao { get; set; }
        public bool IsPioneiroAndServo { get; set; }
        public bool IsPioneroAndAnciao { get; set; }

    }
}
