using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidaddeNegocioEN
{
    public class RazaEN
    {
        public byte Id { get; set; }  // TINYINT en SQL → byte en C#
        public string TipoRaza { get; set; } = string.Empty;  // VARCHAR → string
        public DateTime FechaCreacion { get; set; }  // DATE → DateTime
    }
}
