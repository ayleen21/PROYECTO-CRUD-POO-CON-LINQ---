using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUDLINQ_POO.Entities
{
    public class Nomina
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public DateTime Fecha { get; set; }

        [ForeignKey("IdEmpleado")]
        public int IdEmpleado { get; set; }
        public decimal Sueldo { get; set; }
        public int Dias { get; set; }

        public decimal TotalBasico { get; set; }

        public decimal Comisiones { get; set;}

        public decimal TotalDevengado  {get; set;}
        public string VDevengado()
        {
            if (TotalDevengado > 1000000)
            {
                return "Sueldo superior a un salario minimo";
            }
            else
            {
                return "Sueldo igual o inferior a un salario minimo";
            }
        }
    }
}
