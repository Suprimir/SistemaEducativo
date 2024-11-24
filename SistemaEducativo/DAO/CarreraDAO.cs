using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using SistemaEducativo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class CarreraDAO
    {
        public static List<Carrera> ObtenerTodas()
        {
            List<Carrera> lstCarreras = new List<Carrera>();

            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM carreras;";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                Carrera carrera = new Carrera();

                                carrera.CarreraID = reader.GetInt32(0);
                                carrera.NombreCarrera = reader.GetString(1);
                                carrera.Descripcion = reader.GetString(2);

                                lstCarreras.Add(carrera);
                            }

                            return lstCarreras;
                        }
                    }
                }
            }

            return null;
        }

        public static int ObtenerTotalSemestres(int carreraID)
        {
            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT total_Semestres FROM carreras WHERE carrera_ID = @carreraID";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@carreraID", carreraID);

                    conn.Open();

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                int total_Semestres = reader.GetInt32(0);

                                return total_Semestres;
                            }
                        }
                    }
                }

                return 0;
            }
        }
    }
}
