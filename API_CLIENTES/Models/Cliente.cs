using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CLIENTES.Models {
    public class Cliente {
        private int _id;
        private string _nombre = string.Empty;
        private string _apellido = string.Empty;
        private string _direccion = string.Empty;
        private string _dni = string.Empty;
        private DateTime _fecha;
        private ICollection<Video> _videos;

        public int Id {
            get => _id;
            set => _id = value;
        }
        public string Nombre {
            get => _nombre;
            set => _nombre = value;
        }
        public string Apellido {
            get => _apellido;
            set => _apellido = value;
        }
        public string Direccion {
            get => _direccion;
            set => _direccion = value;
        }
        public string DNI {
            get => _dni;
            set => _dni = value;
        }
        public DateTime Fecha {
            get => _fecha;
            set => _fecha = value;
        }
        public ICollection<Video> Videos {
            get => _videos;
            set => _videos = value;
        }
    }
}
