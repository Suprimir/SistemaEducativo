using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using System.Configuration;
using System.Data;
using System.Linq.Expressions;


namespace SistemaEducativo.DAO
{
    internal class TotalRegistrosDAO
    {
        public static TotalRegistros ObtenerRegistros()
        {
            TotalRegistros totalRegistros = new TotalRegistros();

            try
            {
                using(MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("totalRegistros", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                totalRegistros.TotalGrupos = reader.GetInt32(0);
                                totalRegistros.TotalUsuarios = reader.GetInt32(1);
                                totalRegistros.TotalAlumnos = reader.GetInt32(2);
                                totalRegistros.TotalMaestros = reader.GetInt32(3);
                                totalRegistros.TotalAdmins = reader.GetInt32(4);
                                totalRegistros.TotalMaterias = reader.GetInt32(5);
                            }

                            return totalRegistros;
                        }
                    }
                } 
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return null;
            }
        }

        public static TotalRegistros DatosMenuMaestro()
        {
            try
            {
                TotalRegistros totalRegistros = new TotalRegistros();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM datosMenuMaestro WHERE maestro_ID = @maestroID", conn)) 
                    {
                        cmd.Parameters.AddWithValue("@maestroID", SesionUsuario.Instancia.Id);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                totalRegistros.TotalGrupos = reader.GetInt32(1);
                                totalRegistros.TotalTareas = reader.GetInt32(2);
                            }

                            return totalRegistros;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static TotalRegistros DatosMenuAlumno()
        {
            try
            {
                TotalRegistros totalRegistros = new TotalRegistros();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM datosMenuAlumno WHERE alumno_ID = @alumnoID", conn))
                    {
                        cmd.Parameters.AddWithValue("@alumnoID", SesionUsuario.Instancia.Id);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalRegistros.TotalTareas = reader.GetInt32(1);
                            }

                            return totalRegistros;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
