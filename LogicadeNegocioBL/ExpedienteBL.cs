using EntidaddeNegocioEN;
using LogicadeAccesoaDatosDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicadeNegocioBL
{
    public class ExpedienteBL
    {

        public List<ExpedienteEN> MostrarExpe()
        {
            return ExpedienteDAL.MostrarExpe();
        }
        public  static List<ExpedienteEN> BuscarExpe(string id)
        {
            return ExpedienteDAL.BuscarExpe(id);
        }

        public int GuardarExpe(ExpedienteEN pRegistroEN)
        {
            return ExpedienteDAL.AgregarExpe(pRegistroEN);
        }

        public int EliminarExpe(ExpedienteEN pRegistroEN)
        {
            return ExpedienteDAL.EliminarExpe(pRegistroEN);
        }

        public int ModificarExpe(ExpedienteEN pRegistroEN)
        {
            return ExpedienteDAL.ModificarExpe(pRegistroEN);
        }

    }
}

