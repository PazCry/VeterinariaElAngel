using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidaddeNegocioEN
{
        public class UsuarioEN
    {
        public byte Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contra { get; set; }
        public long Telefono { get; set; }
        public byte IdRol { get; set; }
    }
}
