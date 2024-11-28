using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class UsuarioDAO
    {
        public static Usuario ValidarUsuario(string matricula, string contraseña)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = $"SELECT * FROM usuarios WHERE matricula=@matricula AND contraseña=@contraseña;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.Id = reader.GetInt32(0);
                                usuario.Matricula = reader.GetString(1);
                                usuario.Nombre = reader.GetString(3);
                                usuario.ApellidoP = reader.GetString(4);
                                usuario.ApellidoM = reader.GetString(5);
                                usuario.Correo = reader.GetString(6);
                                usuario.Rol = reader.GetString(7);

                                if(!reader.IsDBNull(8))
                                {
                                    usuario.GeneracionId = reader.GetInt32(8);
                                }

                                return usuario;
                            }
                        }
                    }
                }
            }

            return null;
        }

        public static List<UsuarioGeneral> ObtenerUsuarios()
        {
            List<UsuarioGeneral> lstUsuarios = new List<UsuarioGeneral>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM usuariosGeneral;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                UsuarioGeneral usuario = new UsuarioGeneral();

                                usuario.Id = reader.GetInt32(0);
                                usuario.Matricula = reader.GetString(1);
                                usuario.Pass = reader.GetString(2);
                                usuario.NombreCompleto = reader.GetString(3);
                                usuario.Correo = reader.GetString(4);
                                usuario.Rol = reader.GetString(5);

                                lstUsuarios.Add(usuario);
                            }
                        }
                    }
                }
            }

            return lstUsuarios;
        }

        public static bool CrearUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    string query = "INSERT INTO usuarios ";
                    return true;
                }
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}
