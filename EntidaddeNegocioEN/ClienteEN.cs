using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidaddeNegocioEN
{
    public class ClienteEN
    {
        public byte Id { get; set; }  // Representa TINYINT

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public long Telefono { get; set; }  // Representa BIGINT

        public DateTime FechaCreacion { get; set; }  // Representa DATE
    }
}
