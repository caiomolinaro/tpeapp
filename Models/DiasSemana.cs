using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("DiasSemana")]

    public class DiasSemana
    {
        [Key]
        public int DiaSemanaId { get; set;}

        [Display(Name = "Segunda Feira")]
        public bool SegundaFeira { get; set; }

        [Display(Name = "Terça Feira")]
        public bool TercaFeira { get; set; }

        [Display(Name = "Quarta Feira")]
        public bool QuartaFeira { get; set; }

        [Display(Name = "Quinta Feira")]
        public bool QuintaFeira { get; set; }

        [Display(Name = "Sexta Feira")]
        public bool SextaFeira { get; set; }

        [Display(Name = "Sabado")]
        public bool Sabado { get; set; }

        [Display(Name = "Domingo")]
        public bool Domingo { get; set; }

    }
}
