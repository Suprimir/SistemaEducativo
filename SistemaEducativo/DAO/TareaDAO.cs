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

                        cmd.Parameters.AddWithValue("@p_MatriculaMaestro", SesionUsuario.Instancia.Matricula);
                        cmd.Parameters.AddWithValue("@p_nombreGrupo", grupo.NombreGrupo);
                        cmd.Parameters.AddWithValue("@p_nombreMateria", grupo.Materia);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Tarea tarea = new Tarea();

                                tarea.ID = reader.GetInt32(0);
                                tarea.Parcial = reader.GetInt32(1);
                                tarea.Titulo = reader.GetString(2);
                                tarea.Descripcion = reader.GetString(3);
                                tarea.Fecha_Limite = reader.GetDateTime(4);

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
    }
}
