using Laboratorio_En_Clase.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Laboratorio_En_Clase
{
    public partial class Form1 : Form
    {
        ConexionMySql Clscone = new ConexionMySql();
        Catalogo_Consolas consola= new Catalogo_Consolas();
        List<Catalogo_Consolas> Todos;
        Cursor cursor1 = new Cursor();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            //insertar usando la clase Catalogo_Consola
            consola.Nombre_consola = textBoxconsola.Text;
            consola.Compania = textBoxcompania.Text;
            consola.Anio_lanzamiento = dateTimePickerlanzamiento.Value;
            consola.Generacion = (int)numericUpDowngeneracion.Value;   
        }

        private void todos_Click(object sender, EventArgs e)
        {
            Todos = Clscone.ObtenerTodasLasConsolas();
            if (Todos.Count > 0)
            {
                cursor1.totalRegistros = todos.Count;
                cursor1.current = 0;
                MostrarRegistro();
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }
    }

    internal class ConexionMySql
    {
    }
}
