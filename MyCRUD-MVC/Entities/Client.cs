using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace MyCRUD_MVC.Entities
{
    public class Client
    {
        [Key] //esto hace que este campo sea primary key en la BD
        public int Id { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "El campo nombres es obligatorio")]
        public string Nombres { get; set; }

        [Column(TypeName = "varchar(75)")]
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Apellidos { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Fecha de Ingreso")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaIngreso { get; set; }

    }
}
