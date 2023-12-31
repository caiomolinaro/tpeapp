﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tpeapp.Models
{
    [Table("Users")]
    public class UsersModel
    {
        public UsersModel()
        {
            UsersSchedules = new Collection<UsersSchedulesModel>();
        }
        [Key]
        [Display(Name = "ID")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Por favor digite o nome do irmão ou da irmã")]
        [StringLength(255, ErrorMessage = "O nome do irmão deve ter no máximo 255 caracteres")]
        [Display(Name = "Nome")]
        public string UserName { get; set; }

        [Display(Name = "Homem")]
        public bool IsMan { get; set; }

        [Display(Name = "Mulher")]
        public bool IsWoman {  get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateOnly UserBirthDate { get; set; }

        [Display(Name = "Data de Batismo")]
        public DateOnly UserBaptismDate { get; set; }

        [Required(ErrorMessage = "Por favor digite o número de telefone do irmão ou da irmã")]
        [StringLength(11, ErrorMessage = "O número de telefone deve conter 11 caracteres e no formato 11922233333")]
        [Display(Name = "Telefone")]
        public string UserPhone { get; set; }

        [Required(ErrorMessage = "Por favor digite o email do irmão ou da irmã")]
        [StringLength(22, ErrorMessage = "O email deve conter no máximo 255 caracteres")]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [Display(Name = "Publicador(a)")]
        public bool IsPublisher { get; set; }

        [Display(Name = "Pioneiro(a)")]
        public bool IsPioneer { get; set; }

        [Display(Name = "Servo Ministerial")]
        public bool IsMinisterialServant { get; set; }

        [Display(Name = "Ancião")]
        public bool IsElder { get; set; }

        [Display(Name = "Pioneiro e Servo Ministerial")]
        public bool IsPioneerAndMinisterialServant { get; set; }

        [Display(Name = "Pioneiro e Ancião")]
        public bool IsPioneerAndElder { get; set; }

        [Display(Name = "Congregação:")]
        public int CongregationId { get; set; }

        public virtual CongregationsModel Congregations { get; set; }

        public ICollection<UsersSchedulesModel> UsersSchedules { get; set; }

    }
}
