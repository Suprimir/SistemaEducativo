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
    internal class ParcialDAO
    {
        public static bool CrearParcialesGeneracion(int semestreID)
        {
            bool exito;

            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "INSERT INTO parciales (semestre_ID, nivel_Parcial) VALUES (@semestreID, @nivelParcial);";

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    int insertExitosos = 0;

                    for (int i = 1; i <= 3; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@semestreID", semestreID);
                        cmd.Parameters.AddWithValue("@nivelParcial", i);

                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            insertExitosos++;
                        }
                    }

                    exito = (insertExitosos == 3);
                }
            }

            return exito;
        }

        public static List<Parcial> ObtenerParcialesPorSemestre(int semestreID)
        {
            List<Parcial> lstParciales = new List<Parcial>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM parciales WHERE semestre_ID = @semestreID";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@semestreID", semestreID);

                    conn.Open();

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                Parcial parcial = new Parcial();

                                parcial.ParcialId = reader.GetInt32(0);
                                parcial.SemestreId = reader.GetInt32(1);
                                parcial.NivelParcial = reader.GetInt32(2);

                                lstParciales.Add(parcial);
                            }
                        }
                    }
                }
            }

            return lstParciales;
        }
    }
}
