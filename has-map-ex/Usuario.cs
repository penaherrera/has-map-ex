using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace has_map_ex
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Usuario(string id, string nombre, string email)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
        }
    }
}
