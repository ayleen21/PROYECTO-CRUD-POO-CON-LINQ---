using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRUDLINQ_POO.Entities
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_Ingreso { get; set; }

        [ForeignKey("IdArea")]
        public int IdArea { get; set; }

        //Crar un constructor vacio
        public Empleado()
        {

        }
        //Constructor con argumentos

        public Empleado(int pId, string pNombre, string pApellidos,string pDireccion, string pTelefono, DateTime pFecha_Ingreso, int pIdArea)
        {
            //Llamar las propiedades de la clase

            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellidos = pApellidos;
            this.Direccion = pDireccion;
            this.Telefono = pTelefono;
            this.Fecha_Ingreso = pFecha_Ingreso;
            this.IdArea = pIdArea;
        }
    }
}
