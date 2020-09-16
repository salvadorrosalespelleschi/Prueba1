using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;

namespace Pregunta1.Models
{
    public enum placeType { 
        Casco_Viejo,
        Burtown,
        Plaza_24_de_septiembre,
        Mangales,
        Paradise
    }

    public class rosales
    {
        [Key]
        public int rosalesID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(30, MinimumLength = 2)]
        public string Friendofrosales { get; set; }
        
        [Required]
        public placeType Place { get; set; }
        

        public string Email { get; set; }

        [Display(Name = "Feliz Cumpleaños")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date]
        public DateTime Birthdate { get; set; }
        
    }
}