using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using WCRUD2_MD2.UI;

namespace WCRUD2_MD2.Clases
{
    internal class PersonaDB : ConexionBD
    {
        public class Persona
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        public bool ValidarConexion()
        {
            try
            {
                Conexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                Conexion.Close();
            }
        }

        public List<Persona> ListarPersonas(string condicion = "")
        {
            List<Persona> personas = new List<Persona>();
            string sql = $"SELECT * FROM Persona {condicion}";
            using (Conexion)
            {
                try
                {
                    Conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql, Conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Persona oPersona = new Persona();
                                oPersona.Id = reader.GetInt32(0);
                                oPersona.Nombre = reader.GetString(1);
                                oPersona.Edad = reader.GetInt32(2);
                                personas.Add(oPersona);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return personas;
        }

        public void CrearPersona(string nombre, int edad)
        {
            string sql = "INSERT INTO Persona (Nombre, Edad) VALUES (@Nombre, @Edad)";
            using (Conexion)
            {
                try
                {
                    Conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql, Conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear persona: " + ex.Message);
                }
            }
        }

        public void ActualizarPersona(int id, string nuevoNombre, int nuevaEdad)
        {
            string sql = "UPDATE Persona SET Nombre = @Nombre, Edad = @Edad WHERE Id = @Id";
            using (Conexion)
            {
                try
                {
                    Conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql, Conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nuevoNombre);
                        comando.Parameters.AddWithValue("@Edad", nuevaEdad);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar persona: " + ex.Message);
                }
            }
        }

        public void EliminarPersona(string nombre, int edad)
        {
            string sql = "DELETE FROM Persona WHERE Nombre = @Nombre AND Edad = @Edad";
            using (Conexion)
            {
                try
                {
                    Conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql, Conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Edad", edad);
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar persona: " + ex.Message);
                }
            }
        }

        public Persona ObtenerPersonaPorId(int id)
        {
            Persona persona = null;
            string sql = "SELECT * FROM Persona WHERE Id = @Id";

            using (Conexion)
            {
                try
                {
                    Conexion.Open();
                    using (SqlCommand comando = new SqlCommand(sql, Conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                persona = new Persona();
                                persona.Id = reader.GetInt32(0);
                                persona.Nombre = reader.GetString(1);
                                persona.Edad = reader.GetInt32(2);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener persona por ID: " + ex.Message);
                }
            }

            return persona;
        }

    }
}
