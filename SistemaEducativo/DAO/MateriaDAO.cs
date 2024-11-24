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
    internal class MateriaDAO
    {
        public static List<Materia> ObtenerMateriasPorSemestre(int carreraID, int semestre)
        {
            List<Materia> lstMaterias = new List<Materia>();

            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT materia_ID, nombre_Materia, descripcion FROM materiasRelacionCarrera WHERE carrera_ID = @carreraID AND semestre = @semestre;";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@carreraID", carreraID);
                    cmd.Parameters.AddWithValue("@semestre", semestre);

                    conn.Open();

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Materia materia = new Materia();

                                materia.MateriaId = reader.GetInt32(0);
                                materia.NombreMateria = reader.GetString(1);
                                materia.Descripcion = reader.GetString(2);

                                lstMaterias.Add(materia);
                            }
                        }
                    }
                }
            }

            return lstMaterias;
        }
    }
}
