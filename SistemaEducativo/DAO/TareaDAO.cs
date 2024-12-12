using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEducativo.Sesion;

namespace SistemaEducativo.DAO
{
    internal class TareaDAO
    {
        public static bool CrearActualizarTarea(GrupoProfesor grupo, Tarea tarea)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CrearActualizarTarea", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_tareaID", tarea.ID);
                        cmd.Parameters.AddWithValue("@p_nombreGrupo", grupo.NombreGrupo);
                        cmd.Parameters.AddWithValue("@p_nombreMateria", grupo.Materia);
                        cmd.Parameters.AddWithValue("@p_matriculaMaestro", SesionUsuario.Instancia.Matricula);
                        cmd.Parameters.AddWithValue("@p_nivelParcial", tarea.Parcial);
                        cmd.Parameters.AddWithValue("@p_titulo", tarea.Titulo);
                        cmd.Parameters.AddWithValue("@p_descripcion", tarea.Descripcion);
                        cmd.Parameters.AddWithValue("@p_fechaLimite", tarea.Fecha_Limite);
                        
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

        public static bool EliminarTarea(Tarea tarea)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("EliminarTarea", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_tarea_ID", tarea.ID);

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

        public static List<Tarea> ObtenerTareas(GrupoProfesor grupo)
        {
            try
            {
                List<Tarea> lstTareas = new List<Tarea>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ObtenerTareas", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_MatriculaUsuario", SesionUsuario.Instancia.Matricula);
                        cmd.Parameters.AddWithValue("@p_nombreGrupo", grupo.NombreGrupo);
                        cmd.Parameters.AddWithValue("@p_nombreMateria", grupo.Materia);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Tarea tarea = new Tarea();

                                tarea.ID = reader.GetInt32(0);
                                tarea.Semestre = reader.IsDBNull(1) ? null : reader.GetInt32(1);
                                tarea.Parcial = reader.GetInt32(2);
                                tarea.Titulo = reader.GetString(3);
                                tarea.Descripcion = reader.GetString(4);
                                tarea.Fecha_Limite = reader.GetDateTime(5);
                                tarea.MateriaNombre = reader.IsDBNull(6) ? null : reader.GetString(6);

                                lstTareas.Add(tarea);
                            }

                            return lstTareas;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return null;
            }
        }

        public static bool EntregarTarea(TareaPorAlumno tarea)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("EntregarTarea", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_matricula_Alumno", SesionUsuario.Instancia.Matricula);
                        cmd.Parameters.AddWithValue("@p_tarea_ID", tarea.ID);
                        cmd.Parameters.AddWithValue("@p_tarea_Path", tarea.PathArchivoTarea);
                        cmd.Parameters.AddWithValue("@p_fecha_Entrega", tarea.FechaEntregada);

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

        public static bool CancelarEntregaTarea(TareaPorAlumno tarea)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CancelarEntregaTarea", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_tarea_alumno_ID", tarea.ID);

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

        public static TareaPorAlumno ValidarTareaAlumno(Tarea tarea)
        {
            try
            {
                TareaPorAlumno tareaObtenida = new TareaPorAlumno();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ValidarTareaAlumno", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_matricula_Alumno", SesionUsuario.Instancia.Matricula);
                        cmd.Parameters.AddWithValue("@p_tareaID", tarea.ID);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    tareaObtenida.ID = reader.GetInt32(0);
                                    tareaObtenida.PathArchivoTarea = reader.GetString(3);
                                    tareaObtenida.FechaEntregada = reader.GetDateTime(4);
                                    tareaObtenida.Estado = reader.GetString(5);
                                    tareaObtenida.Calificacion = reader.IsDBNull(6) ? null : reader.GetDouble(6);
                                }

                                return tareaObtenida;
                            }

                            return null;
                        }
                    }
                }
            } catch (Exception ex)
            {
                return null;
            }
        }

        public static List<TareaPorAlumno> ObtenerTareasAlumno(GrupoProfesor grupoSeleccionado, Tarea tareaSeleccionada)
        {
            try
            {
                List<TareaPorAlumno> lstTareas = new List<TareaPorAlumno>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ObtenerTareasAlumno", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_Matricula_Usuario", SesionUsuario.Instancia.Matricula);
                        cmd.Parameters.AddWithValue("@p_tarea_ID", tareaSeleccionada.ID);
                        cmd.Parameters.AddWithValue("@p_grupo_ID", grupoSeleccionado.Id);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TareaPorAlumno tarea = new TareaPorAlumno();

                                tarea.ID = reader.IsDBNull(0) ? null : reader.GetInt32(0);
                                tarea.NombreAlumno = reader.GetString(1);
                                tarea.PathArchivoTarea = reader.IsDBNull(2) ? null : reader.GetString(2);
                                tarea.FechaEntregada = reader.IsDBNull(3) ? null : reader.GetDateTime(3);
                                tarea.Estado = reader.GetString(4);
                                tarea.Calificacion = reader.IsDBNull(5) ? null : reader.GetDouble(5);
                                
                                lstTareas.Add(tarea);
                            }

                            return lstTareas;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"error: {ex}");
                return null;
            }
        }

        public static bool CalificarTarea(TareaPorAlumno tarea)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CalificarTarea", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_tarea_por_alumno_ID", tarea.ID);
                        cmd.Parameters.AddWithValue("@p_calificacion", tarea.Calificacion);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
                return false;
            }
        }
    }
}
