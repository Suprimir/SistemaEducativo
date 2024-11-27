using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
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
    }
}
