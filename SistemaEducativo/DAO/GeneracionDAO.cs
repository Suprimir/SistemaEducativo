using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class GeneracionDAO
    {
        public static int CrearGeneracion(int carreraId, string nombreGeneracion)
        {
            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "INSERT INTO generaciones (carrera_ID, nombre_Generacion) VALUES (@carreraID, @nombreGeneracion); SELECT LAST_INSERT_ID();";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@carreraID", carreraId);
                    cmd.Parameters.AddWithValue("@nombreGeneracion", nombreGeneracion);

                    conn.Open();

                    int generacionID = Convert.ToInt32(cmd.ExecuteScalar());

                    return generacionID;
                }
            }
        }

        public static DataTable ObtenerTabla()
        {
            DataTable tablaGeneraciones = new DataTable();

            tablaGeneraciones.Columns.Add("generacionID");
            tablaGeneraciones.Columns.Add("carrera");
            tablaGeneraciones.Columns.Add("nombreGeneracion");
            tablaGeneraciones.Columns.Add("semestreEnCurso");

            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM generacionesDatos;";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using(MySqlDataReader  reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                tablaGeneraciones.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.IsDBNull(3) ? 0 : reader.GetInt32(3));
                            }
                        }
                    }
                }
            }

            return tablaGeneraciones;
        }

        public static Generacion ObtenerPorID(int generacionID)
        {
            Generacion generacion = new Generacion();

            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM generaciones WHERE generacion_ID = @generacionID";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@generacionID", generacionID);

                    conn.Open();

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                generacion.GeneracionID = reader.GetInt32(0);
                                generacion.CarreraID = reader.GetInt32(1);
                                generacion.NombreGeneracion = reader.GetString(2);
                                generacion.SemestreActual = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                            }
                        }
                    }
                }
            }

            return generacion;
        }
    }
}
