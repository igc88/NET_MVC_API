using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CLIENTES.Models {
    public class Video {
        private int _id;
        private string _title;
        private string _director;
        private Cliente _cliente;
        public int Id {
            get => _id;
            set => _id = value;
        }
        public string Title {
            get => _title;
            set => _title = value;
        }
        public string Director {
            get => _director;
            set => _director = value;
        }
        public Cliente Cliente {
            get => _cliente;
            set => _cliente = value;
        }
    }
}
