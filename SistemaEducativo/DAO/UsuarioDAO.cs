using MySql.Data.MySqlClient;
using SistemaEducativo.Models;
using SistemaEducativo.Views.Alumno;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.DAO
{
    internal class UsuarioDAO
    {
        public static Usuario IniciarSesion(string matricula, string contraseña)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("IniciarSesion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_matricula", matricula);
                    cmd.Parameters.AddWithValue("@p_pass", contraseña);

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
                                usuario.GrupoId = reader.IsDBNull(7) ? null : reader.GetInt32(7);
                                usuario.Carrera = reader.IsDBNull(8) ? null : reader.GetString(8);
                                usuario.Rol = reader.GetString(9);
                                usuario.PathFotoPerfil = reader.IsDBNull(10) ? null : reader.GetString(10);

                                return usuario;
                            }
                        }
                    }
                }
            }

            return null;
        }

        public static List<Usuario> ObtenerUsuarios(string? filtro)
        {
            List<Usuario> lstUsuarios = new List<Usuario>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("ObtenerUsuarios", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_filtro_Rol", filtro);

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while(reader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.Id = reader.GetInt32(0);
                                usuario.Matricula = reader.GetString(1);
                                usuario.Pass = reader.GetString(2);
                                usuario.Nombre = reader.GetString(3);
                                usuario.ApellidoP = reader.GetString(4);
                                usuario.ApellidoM = reader.GetString(5);
                                usuario.Correo = reader.GetString(6);
                                usuario.Rol = reader.GetString(7);
                                usuario.GrupoId = reader.IsDBNull(8) ? null : reader.GetInt32(8);

                                lstUsuarios.Add(usuario);
                            }
                        }
                    }
                }
            }

            return lstUsuarios;
        }

        public static bool CrearActualizarUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("CrearActualizarUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_usuario_ID", usuario.Id); // Pueden ser nulos
                        cmd.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@p_apellido_P", usuario.ApellidoP);
                        cmd.Parameters.AddWithValue("@p_apellido_M", usuario.ApellidoM);
                        cmd.Parameters.AddWithValue("@p_mat", usuario.Matricula);
                        cmd.Parameters.AddWithValue("@p_contraseña", usuario.Pass);
                        cmd.Parameters.AddWithValue("@p_correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@p_rol", usuario.Rol);
                        cmd.Parameters.AddWithValue("@p_grupo_ID", usuario.GrupoId); // Pueden ser nulos
                        cmd.Parameters.AddWithValue("@p_path_foto_Perfil", usuario.PathFotoPerfil);

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
        } // Funcion crear y actualizar usuario terminada 😎

        public static bool EliminarUsuario(Usuario usuario)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("EliminarUsuario", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_usuario_ID", usuario.Id);

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
        } // Ocupa explicacion ?? bueno elimina un usuario 

        public static List<Usuario> ObtenerAlumnos(Grupo grupo)
        {
            try
            {
                List<Usuario> lstAlumnos = new List<Usuario>();
                
                using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM alumnosPorGrupo WHERE grupo_ID = @grupoID", conn))
                    {
                        cmd.Parameters.AddWithValue("@grupoID", grupo.Id);

                        conn.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.Id = reader.GetInt32(0);
                                usuario.Matricula = reader.GetString(1);
                                usuario.NombreCompleto = reader.GetString(2);
                                usuario.GrupoId = reader.GetInt32(3);

                                lstAlumnos.Add(usuario);
                            }

                            return lstAlumnos;
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
