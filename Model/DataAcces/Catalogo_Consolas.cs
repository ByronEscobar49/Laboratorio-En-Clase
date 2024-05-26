using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_En_Clase.Data.DataAcces
{
    internal class Catalogo_Consolas
    {
        public int Id_consola { get; set; }
        public string Nombre_consola { get; set; }
        public string Compania { get; set; }
        public DateTime Anio_lanzamiento { get; set; }
        public int Generacion { get; set; }


        // Constructor sin parámetros
        public Catalogo_Consolas() { }

        // Constructor con parámetros
        public Catalogo_Consolas(int id_consola, string nombre_consola, string compania, DateTime anio_lanzamiento, int generacion)
    {
            Id_consola = id_consola;
            Nombre_consola = nombre_consola;
            Compania = compania;
            Anio_lanzamiento = anio_lanzamiento;
            Generacion = generacion;

        }
    }
}



