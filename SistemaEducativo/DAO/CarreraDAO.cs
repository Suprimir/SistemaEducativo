using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1;
using SistemaEducativo.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class CarreraDAO
    {
        public static List<Carrera> ObtenerCarreras()
        {
            try
            {
                List<Carrera> lstCarreras = new List<Carrera>();

                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    string query = "SELECT * FROM carreras;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Carrera carrera = new Carrera();

                                carrera.Id = reader.GetInt32(0);
                                carrera.NombreCarrera = reader.GetString(1);
                                carrera.Descripcion = reader.GetString(2);
                                carrera.TotalSemestres = reader.GetInt32(3);

                                lstCarreras.Add(carrera);
                            }

                            return lstCarreras;
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un problema | ERROR {ex}");
                return null;
            }
        }

        public static bool CrearActualizarCarrera(Carrera carrera)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CrearActualizarCarrera", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_carrera_ID", carrera.Id);
                        cmd.Parameters.AddWithValue("@p_nombre_Carrera", carrera.NombreCarrera);
                        cmd.Parameters.AddWithValue("@p_descripcion", carrera.Descripcion);
                        cmd.Parameters.AddWithValue("@p_total_Semestres", carrera.TotalSemestres);

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool EliminarCarrera(Carrera carrera)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("EliminarCarrera", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_carrera_ID", carrera.Id);

                        conn.Open();

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
