using EntidaddeNegocioEN;
using LogicadeAccesoaDatosDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicadeNegocioBL
{
    public class EspecieBL
    {


        public List<EspecieEN> MostrarEspecie()
        {
            return EspecieDAL.MostrarEspecie();
        }

        public int GuardarEspecie(EspecieEN pEspecieEN)
        {
            return EspecieDAL.AgregarEspecie(pEspecieEN);
        }

        public int EliminarEspecie(EspecieEN pEspecieEN)
        {
            return EspecieDAL.EliminarEspecie(pEspecieEN);
        }

        public int ModificarEspecie(EspecieEN pEspecieEN)
        {
            return EspecieDAL.ModificarEspecie(pEspecieEN);
        }
    }
}
