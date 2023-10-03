using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Privileges")]
    public class PrivilegesModel
    {
        [Key]
        [Display (Name = "ID")]
        public int PrivilegesId { get; set; }

        [Display(Name = "Publicador")]
        public bool IsPublisher { get; set; }

        [Display(Name = "Pioneiro")]
        public bool IsPioneer { get; set; }

        [Display(Name = "Servo Ministerial")]
        public bool IsMinisterialServant { get; set; }

        [Display(Name = "Ancião")]
        public bool IsElder { get; set; }

        [Display(Name = "Pioneiro e Servo Ministerial")]
        public bool IsPioneerAndMinisterialServant { get; set; }

        [Display(Name = "Pioneiro e Ancião")]
        public bool IsPioneerAndElder { get; set; }
    }
}
