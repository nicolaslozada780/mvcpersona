using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apiPersona.Models
{
    public enum SexType
    {
        Femenino=0,
        Masculino=1,
    }
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [StringLength(250,MinimumLength =5,ErrorMessage ="Ingresar nombres entre 5 a 250 caracteres")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime Birthdate { get; set; }
        public SexType Sex { get; set; }
    }
}