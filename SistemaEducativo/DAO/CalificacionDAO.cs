using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class CalificacionDAO
    {
        public static List<CalificacionAlumno> ObtenerCalificacionesPorParcial(int materiaID, int parcialID)
        {
            List<CalificacionAlumno> lstCalificaciones = new List<CalificacionAlumno>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString)) 
            {
                string query = "SELECT * FROM calificacionAlumno WHERE materia_ID = @materiaID AND parcial_ID = @parcialID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@materiaID", materiaID);
                    cmd.Parameters.AddWithValue("@parcialID", parcialID);

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CalificacionAlumno calificacion = new CalificacionAlumno();

                                calificacion.CalificacionId = reader.IsDBNull(0) ? null : reader.GetInt32(0);
                                calificacion.Matricula = reader.GetString(3);
                                calificacion.NombreCompleto = reader.GetString(4);
                                calificacion.CalificacionValor = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);

                                lstCalificaciones.Add(calificacion);
                            }
                        }
                    }
                }
            }

                return lstCalificaciones;
        }
    }
}
