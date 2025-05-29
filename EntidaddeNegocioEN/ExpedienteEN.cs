using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidaddeNegocioEN
{
    public class ExpedienteEN
    {
        public byte Id { get; set; }
        public byte IdCliente { get; set; }
        public byte IdMascota { get; set; }
        public string DescripcionConsulta { get; set; }
        public string Estado { get; set; }
        public DateTime FechaAtencion { get; set; }
    }
}
