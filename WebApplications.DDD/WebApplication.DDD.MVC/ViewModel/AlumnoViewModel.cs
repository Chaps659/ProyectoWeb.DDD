using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.DDD.MVC.ViewModel
{
    public class AlumnoViewModel
    {
        [Key]
        public int Alumno_ID { get; set; }

        [Required(ErrorMessage = "Rellenar")]
        [MaxLength(150, ErrorMessage = "Maximo de caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Rellenar")]
        [MaxLength(150, ErrorMessage = "Maximo de caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de caracteres")]
        public string Apellido { get; set; }

    }
}