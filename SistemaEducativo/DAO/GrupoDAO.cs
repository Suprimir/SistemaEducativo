using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using System.Configuration;
using System.Data;


namespace SistemaEducativo.DAO
{
    internal class GrupoDAO
    {
        public static bool CrearGeneracion(int carreraId, string nombreGrupo, DateTime fechaInicio)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CrearGruposConSemestresYParciales", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@carreraID", carreraId);
                        cmd.Parameters.AddWithValue("@nombreGrupo", nombreGrupo);
                        cmd.Parameters.AddWithValue("@semestreActual", 1);
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro Exitoso");
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

                                grupo.GrupoID = reader.GetInt32(0);
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

        public static bool EliminarGrupo(int grupoID)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    string query = "DELETE FROM grupos WHERE grupo_ID = @grupoID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@grupoID", grupoID);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Eliminacion exitosa");
                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return false;
            }
        }

        public static bool EditarGrupo(string nombreGrupo, int grupoID)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    string query = "UPDATE grupos SET nombre_Grupo = @nombreGrupo WHERE grupo_ID = @grupoID;";

                    using (MySqlCommand cmd = new MySqlCommand (query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreGrupo", nombreGrupo);
                        cmd.Parameters.AddWithValue("@grupoID", grupoID);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Edicion exitosa");
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
