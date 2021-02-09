using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CIENTIFICOS_PROYECTOS.Models {
    public class Proyecto {
        private char _id;
        private string _nombre;
        private int _horas;
        public char Id {
            get => _id;
            set => _id = value;
        }
        public string Nombre {
            get => _nombre;
            set => _nombre = value;
        }
        public int Horas {
            get => _horas;
            set => _horas = value;
        }

        public ICollection<Asignado_a> Asignaciones;
    }
}
