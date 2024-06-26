﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Narzedzia.Models
{
    public class Uzytkownik : IdentityUser
    {

        [Display(Name ="Imię użytkownika:")]
        [Required(ErrorMessage = "Pole Imię użytkownika jest wymagane.")]
        [MaxLength(20)]
        public string? Imie { get; set; }

        [Display(Name = "Nazwisko użytkownika:")]
        [Required(ErrorMessage = "Pole Nazwisko użytkownika jest wymagane.")]

        [MaxLength(50)]
        public string? Nazwisko { get; set; }

        [NotMapped]
        [Display(Name ="Pan/Pani:")]
        public string Imie_Nazwisko
        {
            get { return Imie + " " + Nazwisko; }
        }
        [Required(ErrorMessage = "Pole Numer kontrolny jest wymagane.")]
        [Display(Name ="Numer kontrolny:")]
        public int NrKontrolny { get; set; }

        [Display(Name = "Wydzial:")]
        public int WydzialId { get; set; }

        [Display(Name = "Stanowisko:")]
        public int StanowiskoId { get; set; }


        [ForeignKey("WydzialId")]
        public virtual Wydzial? Wydzialy { get; set; }

        [ForeignKey("StanowiskoId")]
        public virtual Stanowisko? Stanowiska { get; set; }

        public virtual List<Narzedzie>? Narzedzia { get; set; }

        public virtual List<Awaria>? Awarie { get; set; }
    }
}
