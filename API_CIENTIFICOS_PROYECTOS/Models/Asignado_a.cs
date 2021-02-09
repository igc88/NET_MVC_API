using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_CIENTIFICOS_PROYECTOS.Models {
    public class Asignado_a {
        [Key, Column(Order = 1)]
        public string Cientifico_dni { get; set; }
        [Key, Column(Order = 2)]
        public char Proyecto_id { get; set; }

        public Cientifico Cientifico { get; set; }
        public Proyecto Proyecto { get; set; }
    }
}
