using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using System.Configuration;
using System.Data;


namespace SistemaEducativo.DAO
{
    internal class GrupoDAO
    {
        public static bool CrearActualizarGrupo(Grupo grupo, Carrera carrera)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CrearActualizarGrupo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_grupo_ID", grupo.Id);
                        cmd.Parameters.AddWithValue("@p_carrera_ID", carrera.Id);
                        cmd.Parameters.AddWithValue("@p_nombre_Grupo", grupo.NombreGrupo);
                        cmd.Parameters.AddWithValue("@p_semestre_Actual", grupo.SemestreActual);
                        cmd.Parameters.AddWithValue("@p_fechaInicio", grupo.FechaInicio);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro Exitoso");
                        return true;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex.ToString()}");
                return false;
            }
        }

        public static List<Grupo> ObtenerGrupos()
        {
            List<Grupo> lstGrupos = new List<Grupo>();

            using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM gruposDatos;";

                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using(MySqlDataReader  reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                Grupo grupo = new Grupo();

                                grupo.Id = reader.GetInt32(0);
                                grupo.Carrera = reader.GetString(1);
                                grupo.NombreGrupo = reader.GetString(2);
                                grupo.SemestreActual = reader.GetInt32(3);
                                grupo.FechaInicio = reader.GetDateTime(4);

                                lstGrupos.Add(grupo);
                            }
                        }
                    }
                }
            }

            return lstGrupos;
        }

        public static List<GrupoProfesor> ObtenerGruposAsignados(int maestroID)
        {
            try
            {
                List<GrupoProfesor> lstGrupos = new List<GrupoProfesor>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ObtenerGruposAsignados", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@maestroID", maestroID);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GrupoProfesor grupo = new GrupoProfesor();

                                grupo.NombreGrupo = reader.GetString(0);
                                grupo.Materia = reader.GetString(1);
                                grupo.SemestreActual = reader.GetInt32(2);

                                lstGrupos.Add(grupo);
                            }
                        }
                    }
                }

                return lstGrupos;

            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex.ToString()}");
                return null;
            }
        }

        public static bool EliminarGrupo(Grupo grupo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("EliminarGrupo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_grupo_ID", grupo.Id);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Eliminacion exitosa");
                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex.ToString()}");
                return false;
            }
        }

        public static bool AsignarMaestroGrupo(Usuario maestro, Grupo grupo, Materia materia)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("AsignarMaestroGrupo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_grupo_ID", grupo.Id);
                        cmd.Parameters.AddWithValue("@p_maestro_ID", maestro.Id);
                        cmd.Parameters.AddWithValue("@p_materia_ID", materia.Id);
                        cmd.Parameters.AddWithValue("@p_semestre", materia.Semestre);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex.Message}");
                return false;
            }
        }
    }
}
