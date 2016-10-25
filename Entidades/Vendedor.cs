using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Clase Vendedor
    public class Vendedor : Persona
    {
        public string DNI { get; set; }

        public Vendedor(string pNombre, string pApellido, string pDNI, string pEmail, string pTelefono, string pDireccion)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = pDNI;
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }

        
    }
}
