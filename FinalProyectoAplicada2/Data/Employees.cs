using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProyectoAplicada2.Data
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio")]

        [StringLength(50, ErrorMessage = "No se permite un nombre tan largo")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        [StringLength(10, ErrorMessage = "El campo cedula tiene 11 numeros")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string Nacionalidad { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public string EstadoCivil { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]

        public decimal Salario { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        public DateTime FechaIngreso { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]

        [StringLength(10, ErrorMessage = "Un celular solo tiene 10 numeros")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]

        [StringLength(10, ErrorMessage = "Un telefono solo tiene 10 numeros")]
        public string Telefono { get; set; }
        public Employees()
        {
            EmployeeId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            FechaNacimiento = DateTime.Now;
            Nacionalidad = string.Empty;
            EstadoCivil = string.Empty;
            Salario = 0;
            FechaIngreso = DateTime.Now;
            Celular = string.Empty;
            Telefono = string.Empty;
        }
    }
}
