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
        public static List<Materia> ObtenerMaterias()
        {
            List<Materia> lstMaterias = new List<Materia>();

            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT materia_ID, nombre_Carrera, semestre, nombre_Materia, descripcion FROM materiasRelacionCarrera;";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Materia materia = new Materia();

                                materia.MateriaId = reader.GetInt32(0);
                                materia.NombreCarrera = reader.IsDBNull(1) ? "No Asignada" : reader.GetString(1);
                                materia.Semestre = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                                materia.NombreMateria = reader.GetString(3);
                                materia.Descripcion = reader.GetString(4);

                                lstMaterias.Add(materia);
                            }
                        }
                    }
                }
            }

            return lstMaterias;
        }

        public static bool RegistrarMateria(string nombreMateria, string descripcion)
        {
            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "INSERT INTO materias (nombre_Materia, descripcion) VALUES (@nombreMateria, @descripcion);";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombreMateria", nombreMateria);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);

                    conn.Open();

                    if(cmd.ExecuteNonQuery() != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool ActualizarMateria(Materia materia)
        {

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "UPDATE materias SET nombre_Materia = @nombreMateria, descripcion = @descripcion WHERE materia_ID = @materiaID;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombreMateria", materia.NombreMateria);
                    cmd.Parameters.AddWithValue("@descripcion", materia.Descripcion);
                    cmd.Parameters.AddWithValue("@materiaID", materia.MateriaId);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
