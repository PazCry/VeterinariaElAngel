using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidaddeNegocioEN
{
    public class GeneroEN
    {
        public byte Id { get; set; }  // TINYINT

        public string TipoGen { get; set; } = string.Empty;  // VARCHAR(10)

        public DateTime FechaCreacion { get; set; }  // DATE
    }
}
