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
    public partial class UpdatePerson : Form
    {
        public UpdatePerson()
        {
            InitializeComponent();
        }

        private void BuscarPUpdate_Click(object sender, EventArgs e)
        {
            // Obtener el ID ingresado (asumiendo TextBox para el ID)
            if (!int.TryParse(FiltrarUP.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia de la clase PersonaDB
            PersonaDB personaDB = new PersonaDB();

            // Validar la conexión con la base de datos
            if (!personaDB.ValidarConexion())
            {
                MessageBox.Show("Error de conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar la persona por ID
            PersonaDB.Persona persona = personaDB.ObtenerPersonaPorId(id);

            // Mostrar la información en TextBox (asumiendo TextBox para mostrar la información)
            if (persona != null)
            {
                NombreUpdateP.Text = persona.Nombre;
                EdadUpdateP.Text = persona.Edad.ToString(); // Convertir la edad a string
            }
            else
            {
                MessageBox.Show("No existe persona", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBtt_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles (asumiendo TextBox para el nombre, la edad y el ID)
            int id;

            // Validar la entrada para el ID
            if (!int.TryParse(FiltrarUP.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoNombre = NombreUpdateP.Text;
            int nuevaEdad;

            // Validar la entrada para la nueva edad
            if (!int.TryParse(EdadUpdateP.Text, out nuevaEdad))
            {
                MessageBox.Show("Ingrese una nueva edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia de la clase PersonaDB
            PersonaDB personaDB = new PersonaDB();

            // Validar la conexión con la base de datos
            if (!personaDB.ValidarConexion())
            {
                MessageBox.Show("Error de conexión a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método para actualizar la información de la persona
            personaDB.ActualizarPersona(id, nuevoNombre, nuevaEdad);

            // Limpiar los campos
            FiltrarUP.Clear();
            NombreUpdateP.Clear();
            EdadUpdateP.Clear();

            // Cerrar la ventana modal
            this.Close();

            MessageBox.Show("Información de la persona actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
