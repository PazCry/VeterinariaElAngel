using EntidaddeNegocioEN;
using LogicadeAccesoaDatosDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicadeNegocioBL
{
    /// <summary>
    /// / <para>Clase de lógica de negocio para manejar las operaciones relacionadas con las citas.</para>
    /// </summary>
    public class CitaBL
    {
        public List<CitaEN> MostrarCita()
        {
            return CitaDAL.MostrarCita();
        }
        public static List<CitaEN> BuscarCita(string id)
        {
            return CitaDAL.BuscarCita(id);
        }

        public int GuardarCita(CitaEN pCitaEN)
        {
            return CitaDAL.AgregarCita(pCitaEN);
        }

        public int EliminarCita(CitaEN pCitaEN)
        {
            return CitaDAL.EliminarCita(pCitaEN);
        }
        public int ModificarCita(CitaEN pCitaEN)
        {
            return CitaDAL.ModificarCita(pCitaEN);
        }
    }
}
