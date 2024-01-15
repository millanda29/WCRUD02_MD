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
    public partial class NewPerson : Form
    {
        public NewPerson()
        {
            InitializeComponent();
        }

        private void AgregarBtt_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles (asumiendo TextBox para el nombre y la edad)
            string nombre = NombreText.Text;
            int edad;

            // Validar la entrada para la edad
            if (!int.TryParse(EdadText.Text, out edad))
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

            // Llamar al método para agregar una persona
            personaDB.CrearPersona(nombre, edad);

            // Limpiar los campos
            NombreText.Clear();
            EdadText.Clear();

            // Cerrar la ventana modal
            this.Close();

            MessageBox.Show("Persona agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
