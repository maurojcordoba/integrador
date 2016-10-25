using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class DocumentoComercial
    {
        public string Numero;
        public DateTime Fecha;
        public string Cliente;
        public string Direccion;
        public string CondicionIVA;
        public string CondicionVenta;
        public string Detalle;
        public decimal Total;

        public DocumentoComercial()
        {
               
        }

    }
}
