using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCRUD2_MD2.Clases;

namespace WCRUD2_MD2.UI
{
    public partial class Person : Form
    {
        public Person()
        {
            InitializeComponent();
            this.FormClosed += Person_FormClosed;
        }

        private static Person Instancia = null;

        public static Person ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new Person();
                Instancia.FormClosed += Person_FormClosed;
            }
            return Instancia;
        }

        private static void Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instancia = null;
        }

        private void Person_Load(object sender, EventArgs e)
        {
            //Verificación de la conexión con el origen de datos
            PersonaDB persona = new PersonaDB();
            if (persona.ValidarConexion())
            {
                ConexionText.Text += "Exitosa.";
                //Instancia a la clase persona
                PersonaDB oPersona = new PersonaDB();
                //Invoca al método listar personas y asigna el resultado al dataGridview respectivo
                dataGridViewPersonas.DataSource = oPersona.ListarPersonas("");
            }
            else
            {
                ConexionText.Text += "Falló!!";
            }
        }

        private void EliminarBtt_Click(object sender, EventArgs e)
        {
            DeletePerson deletePerson = new DeletePerson();
            deletePerson.ShowDialog();
        }

        private void ActualizarBtt_Click(object sender, EventArgs e)
        {
            UpdatePerson updatePerson = new UpdatePerson();
            updatePerson.ShowDialog();
        }

        private void AgregarBtt_Click(object sender, EventArgs e)
        {
            NewPerson newPerson = new NewPerson();
            newPerson.ShowDialog();
        }

        private void BuscarBtt_Click(object sender, EventArgs e)
        {
            PersonaDB oPersona = new PersonaDB();
            //Invoca al método listar personas con un parámetro de búsqueda
            dataGridViewPersonas.DataSource = oPersona.ListarPersonas(FiltarTexto.Text);
        }
 }
}
