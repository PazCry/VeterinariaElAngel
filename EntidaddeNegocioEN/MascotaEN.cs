using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidaddeNegocioEN
{
    public class MascotaEN
    {
        public byte Id { get; set; }  // TINYINT

        public string Nombre { get; set; } = string.Empty;

        public string Color { get; set; } = string.Empty;

        public DateTime FechaNaci { get; set; }

        public byte IdSexo { get; set; }

        public byte IdRaza { get; set; }

        public byte IdEspecie { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
