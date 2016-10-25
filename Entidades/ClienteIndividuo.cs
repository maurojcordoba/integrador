using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteIndividuo : Persona
    {
        public string CUIT { get; set; }

        public ClienteIndividuo(string Nombre, string Apellido, string CUIT, string Email, string Telefono, string Direccion)
        {
            this.Nombre = Nombre;
            this.CUIT = CUIT;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }

        public ClienteIndividuo()
        {

        }
    }
}
