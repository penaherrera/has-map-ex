namespace has_map_ex
{
    public partial class Form1 : Form
    {
        // HashMap
        private Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();
        public Form1()
        {
            InitializeComponent();

            usuarios.Add("1", new Usuario("1", "Mac Miller", "mac@example.com"));
            usuarios.Add("2", new Usuario("2", "Cliff Burton", "cliff@example.com"));

            MessageBox.Show("Datos iniciales cargados");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("ID y Nombre son campos obligatorios.");
                return;
            }

            if (usuarios.ContainsKey(id))
            {
                MessageBox.Show("¡El ID ya existe!");
                return;
            }

            usuarios.Add(id, new Usuario(id, nombre, email));
            MessageBox.Show("Usuario agregado correctamente.");
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtBuscarId.Text.Trim();

            if (usuarios.TryGetValue(id, out Usuario usuario))
            {
                MessageBox.Show($"Usuario encontrado:\nID: {usuario.Id}\nNombre: {usuario.Nombre}\nEmail: {usuario.Email}");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (usuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados.");
                return;
            }

            string lista = "Usuarios registrados:\n\n";
            foreach (var usuario in usuarios.Values)
            {
                lista += $"ID: {usuario.Id}, Nombre: {usuario.Nombre}, Email: {usuario.Email}\n";
            }

            MessageBox.Show(lista);
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
        }

    }
}
