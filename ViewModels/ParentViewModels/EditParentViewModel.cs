﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Garderie.ViewModels.ParentViewModels
{
    public class EditParentViewModel
    {
        public int ParentId { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }
        [Required]
        public string Sexe { get; set; }
        [Required]
        [Display(Name = "Date de naissance")]
        public DateTime? DateNaissance { get; set; }
        [Required]
        [Display(Name = "Numéro de sécurité sociale")]
        public string NumSecu { get; set; }
        [Required]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }
        public int NbEnfantsInscrits { get; set; }
    }
}