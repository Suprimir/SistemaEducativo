using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using SistemaEducativo.Sesion;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class CalificacionDAO
    {
        public static List<Calificacion> ObtenerCalificacionesParciales(int? nivelSemestral, string matricula, string? nombreMateria)
        {
            try
            {
                List<Calificacion> lstCalificaciones = new List<Calificacion>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ObtenerCalificacionesParciales", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_matricula_Alumno", matricula);
                        cmd.Parameters.AddWithValue("@p_nivelSemestral", nivelSemestral);
                        cmd.Parameters.AddWithValue("@p_materiaNombre", nombreMateria);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Calificacion calificacion = new Calificacion();

                                calificacion.Semestre = reader.GetInt32(0);
                                calificacion.Materia = reader.GetString(1);
                                calificacion.Parcial = reader.GetInt32(2);
                                calificacion.CalificacionNumero = reader.GetDouble(3);

                                lstCalificaciones.Add(calificacion);
                            }

                            return lstCalificaciones;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static List<Calificacion> ObtenerCalificacionesSemestral(int? nivelSemetral, string matricula)
        {
            try
            {
                List<Calificacion> lstCalificaciones = new List<Calificacion>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ObtenerCalificacionesSemestral", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_matricula_Alumno", matricula);
                        cmd.Parameters.AddWithValue("@p_nivelSemestral", nivelSemetral);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Calificacion calificacion = new Calificacion();

                                calificacion.Semestre = reader.GetInt32(0);
                                calificacion.Materia = reader.GetString(1);
                                calificacion.CalificacionNumero = reader.GetDouble(2);

                                lstCalificaciones.Add(calificacion);
                            }

                            return lstCalificaciones;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static List<Calificacion> ObtenerCalificacionesFinales(string matricula)
        {
            try
            {
                List<Calificacion> lstCalificaciones = new List<Calificacion>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("ObtenerCalificacionesFinales", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_matricula_Alumno", matricula);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Calificacion calificacion = new Calificacion();

                                calificacion.Semestre = reader.GetInt32(0);
                                calificacion.CalificacionNumero = reader.GetDouble(1);

                                lstCalificaciones.Add(calificacion);
                            }

                            return lstCalificaciones;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
