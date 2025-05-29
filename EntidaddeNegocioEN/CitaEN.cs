using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidaddeNegocioEN
{
        public class CitaEN
    {
        public byte Id { get; set; }
        public byte IdExpe{ get; set; }
        public DateTime? FechaCita { get; set; }
        public TimeSpan? Hora { get; set; }
    }
}
