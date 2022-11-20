﻿using PaparaSecondWeek.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PaparaSecondWeek.Models
{
   
    public class Owner
    {
        [Key]
        [ValidateModelState]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [Description("Açıklama alanı")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Tarih alanı boş geçilemez")]
        public DateTime CreateDate { get; set; }
        public ColorEnum Color { get; set; }
    }

    public enum ColorEnum
    {
        [Display(Name ="Siyah")]
        Black = 1,
        [Display(Name = "Kırmızı")]
        Red = 2,
        [Display(Name = "Yeşil")]
        Green = 3,
        [Display(Name = "Mavi")]
        Blue = 4
    }
}
