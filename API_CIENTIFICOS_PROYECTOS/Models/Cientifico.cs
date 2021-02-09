using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CIENTIFICOS_PROYECTOS.Models {
    public class Cientifico {
        private string _dni;
        private string _nomApels;

        public string DNI {
            get => _dni;
            set => _dni = value;
        }
        public string NomApels {
            get => _nomApels;
            set => _nomApels = value;
        }

        public ICollection<Asignado_a> Asignaciones;
    }
}
