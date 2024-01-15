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
    public partial class DeletePerson : Form
    {
        public DeletePerson()
        {
            InitializeComponent();
        }

        private void BuscarBttD_Click(object sender, EventArgs e)
        {
            // Obtener el ID ingresado (asumiendo TextBox para el ID)
            if (!int.TryParse(FiltrarDP.Text, out int id))
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
                NombreDText.Text = persona.Nombre;
                EdadDText.Text = persona.Edad.ToString(); // Convertir la edad a string
            }
            else
            {
                MessageBox.Show("No existe persona", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBtt_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles (asumiendo TextBox para el nombre y la edad)
            string nombre = NombreDText.Text;
            int edad;

            // Validar la entrada para la edad
            if (!int.TryParse(EdadDText.Text, out edad))
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Llamar al método para eliminar una persona por nombre y edad
            personaDB.EliminarPersona(nombre, edad);

            // Limpiar los campos
            NombreDText.ResetText();
            EdadDText.ResetText();

            // Cerrar la ventana modal
            this.Close();

            MessageBox.Show("Persona eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
