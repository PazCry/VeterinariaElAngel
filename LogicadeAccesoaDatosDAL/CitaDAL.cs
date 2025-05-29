using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidaddeNegocioEN;

namespace LogicadeAccesoaDatosDAL
{
    public class CitaDAL
    {


        public static List<CitaEN> MostrarCita()
        {
            List<CitaEN> lista = new List<CitaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("ListarCita", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    lista.Add(new CitaEN
                    {
                        Id = _reader.GetByte(0),
                        IdExpe = _reader.GetByte(1),
                        FechaCita = _reader.GetDateTime(2),
                        Hora = (TimeSpan)_reader["Hora"] // Solo esta línea cambia de método a indexador
                    });
                }
                _conn.Close();
            }
            return lista;
        }


        public static List<CitaEN> BuscarCita(String Id)
        {
            List<CitaEN> _Lista = new List<CitaEN>();
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("BuscarCliente", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.AddWithValue("@Id", Id);

                IDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    _Lista.Add(new CitaEN
                    {
                        Id = _reader.GetByte(0),
                        IdExpe = _reader.GetByte(1),
                        FechaCita = _reader.GetDateTime(2),  
                        Hora = _reader.GetDateTime(3).TimeOfDay         
                    });
                }
                _conn.Close();
            }
            return _Lista;
        }
        public static int AgregarCita(CitaEN pCitaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("GuardarCita", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@IdExpe", pCitaEN.IdExpe));
                _comando.Parameters.Add(new SqlParameter("@FechaCita", pCitaEN.FechaCita)); // No acepta null
                _comando.Parameters.Add(new SqlParameter("@Hora", pCitaEN.Hora));           // No acepta null

                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }

        public static int EliminarCita(CitaEN pCitaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("EliminarCita", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCitaEN.Id));

                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }

        public static int ModificarCita(CitaEN pCitaEN)
        {
            using (IDbConnection _conn = ComunBD.ObtenerConexion(ComunBD.TipoBD.SqlServer))
            {
                _conn.Open();
                SqlCommand _comando = new SqlCommand("ModificarCita", _conn as SqlConnection);
                _comando.CommandType = CommandType.StoredProcedure;
                _comando.Parameters.Add(new SqlParameter("@Id", pCitaEN.Id));
                _comando.Parameters.Add(new SqlParameter("@IdRegistro", pCitaEN.IdExpe));
                _comando.Parameters.Add(new SqlParameter("@FechaCita", pCitaEN.FechaCita)); // No acepta null
                _comando.Parameters.Add(new SqlParameter("@Hora", pCitaEN.Hora));           // No acepta null

                int resultado = _comando.ExecuteNonQuery();
                _conn.Close();
                return resultado;
            }
        }

    }
}

    