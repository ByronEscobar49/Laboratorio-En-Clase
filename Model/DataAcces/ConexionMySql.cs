
using Laboratorio_En_Clase.Data.DataAcces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_En_Clase.Model.DataAcces
{
    internal class ConexionMySql
    {
       
            string connectionString = "server=localhost;database=db_mi_primerabasededatos;user=root;password=1234byto";
            MySqlConnection connection;

        //constructor
        public ConexionMySql()
        {
            connection = new MySqlConnection(connectionString);
        }
    }
    public List<Catalogo_Consolas> ObtenerTodasLasConsolas()
    {
        List<Catalogo_Consolas> consola = new List<Catalogo_Consolas>();

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "SELECT * FROM Catalago_Consolas";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Catalogo_Consolas usuario = new Catalogo_Consolas
                    (
                        id: reader.GetInt32("ID"),
                        nombre: reader.GetString("Nombre"),
                        apellido: reader.GetString("Apellido"),
                        fechaNacimiento: reader.GetDateTime("FechaNacimiento"),
                        email: reader.GetString("Email"),
                        saldo: reader.GetDecimal("Saldo"),
                        activo: reader.GetBoolean("Activo")
                    );

                    Catalogo_Consolas.Add(consola);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        return consola;
    }



}
