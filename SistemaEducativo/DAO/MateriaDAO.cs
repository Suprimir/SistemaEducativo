using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class MateriaDAO
    {
        public static bool CrearActualizarMateria(Materia materia)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CrearActualizarMateria", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_materia_ID", materia.Id);
                        cmd.Parameters.AddWithValue("@p_nombre_Materia", materia.NombreMateria);
                        cmd.Parameters.AddWithValue("@p_descripcion", materia.Descripcion);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return false;
            }
        }
        public static bool EliminarMateria(int materiaId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("EliminarMateria", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_materia_ID", materiaId);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return false;
            }
        }
        public static List<Materia> ObtenerMaterias(string nombreCarrera)
        {
            try
            {
                List<Materia> lstMaterias = new List<Materia>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ObtenerMaterias", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_nombre_Carrera", nombreCarrera);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Materia materia = new Materia();

                                materia.Id = reader.GetInt32(0);
                                materia.NombreMateria = reader.GetString(1);
                                materia.Descripcion = reader.GetString(2);
                                
                                if (nombreCarrera != null)
                                {
                                    materia.Semestre = reader.GetInt32(3);
                                }

                                lstMaterias.Add(materia);
                            }

                            return lstMaterias;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return null;
            }
        }
        public static bool AsignarMateriaCarrera(Materia materia)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("AsignarMateriaCarrera", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_nombre_Carrera", materia.NombreCarrera);
                        cmd.Parameters.AddWithValue("@p_materia_ID", materia.Id);
                        cmd.Parameters.AddWithValue("@p_semestre", materia.Semestre);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return false;
            }
        }
        public static bool DesasignarMateriaCarrera(Materia materia, Carrera carrera)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("DesasignarMateriaCarrera", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_carrera_ID", carrera.Id);
                        cmd.Parameters.AddWithValue("@p_materia_ID", materia.Id);
                        cmd.Parameters.AddWithValue("@p_semestre", materia.Semestre);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return false;
            }
        }
    }
}
