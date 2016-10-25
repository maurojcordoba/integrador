using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        public string Tipo { get; set; }
        
        public Factura(string Tipo, string Numero, DateTime Fecha, string Cliente, string Direccion, string CondicionIVA, string Detalle, decimal Total)
        {
            this.Tipo = Tipo;
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Cliente = Cliente;
            this.Direccion = Direccion;
            this.CondicionIVA = CondicionIVA;
            this.Detalle = Detalle;
            this.Total = Total;
        }
    }

    
}
