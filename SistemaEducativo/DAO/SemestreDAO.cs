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
    internal class SemestreDAO
    {
        public static List<int> CrearSemestresGeneracion(int generacionID, int carreraID)
        {
            List<int> lstSemestreID = new List<int>();

            int total_Semestres = CarreraDAO.ObtenerTotalSemestres(carreraID);

            if(total_Semestres != 0)
            {
                using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    string query = $"INSERT INTO semestres (generacion_ID, carrera_ID, nivel_Semestral) VALUES (@generacionID, @carreraID, @nivelSemestral); SELECT LAST_INSERT_ID();";

                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        for(int i = 1; i <= total_Semestres; i++)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@generacionID", generacionID);
                            cmd.Parameters.AddWithValue("@carreraID", carreraID);
                            cmd.Parameters.AddWithValue("@nivelSemestral", i);

                            int semestre_id = Convert.ToInt32(cmd.ExecuteScalar());

                            if (semestre_id != 0)
                            {
                                lstSemestreID.Add(semestre_id);
                            }
                        }
                    }

                    return lstSemestreID;
                }
            }

            return null;
        }

        public static List<Semestre> ObtenerSemestres(int generacionID)
        {
            List<Semestre> lstSemestres = new List<Semestre>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT semestre_Id, generacion_Id, nivel_Semestral FROM semestres WHERE generacion_ID = @generacionID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@generacionID", generacionID);

                    conn.Open();

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                Semestre semestre = new Semestre();

                                semestre.SemestreId = reader.GetInt32(0);
                                semestre.GeneracionId = reader.GetInt32(1);
                                semestre.NivelSemestral = reader.GetInt32(2);

                                lstSemestres.Add(semestre);
                            }
                        }
                    }
                }
            }

            return lstSemestres;
        }
    }
}
