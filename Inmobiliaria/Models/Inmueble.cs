using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inmobiliaria.Models
{
    public class Inmueble
    {
        [Key]
        public int IdInmueble { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; }
        public string TipoInmueble { get; set; }
        public string Uso { get; set; }
        public int CantHambientes { get; set; }
        public decimal Precio { get; set; }
        //[System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int IdPropietario { get; set; }
        //[System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [ForeignKey("IdPropietario")]

        public Propietario Propietario { get; set; }

        
    }
}
