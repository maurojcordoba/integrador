using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto
        {
            get
            {
                return PrecioCosto +  Convert.ToDecimal(Margen);
            }
        }
        public decimal PrecioVenta
        {
            get
            {
                return PrecioBruto + Convert.ToDecimal(IVA);
            }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

        public Producto(string Nombre, string Descripcion, decimal PrecioCosto, double Margen, double IVA, string Proveedor, string Categoria, string SubCategoria)
        {
            this.Nombre = Nombre;
            this.PrecioCosto = PrecioCosto;
            this.Margen = Margen;
            this.IVA = IVA;
            this.Proveedor = Proveedor;
            this.Categoria = Categoria;
            this.SubCategoria = SubCategoria;
        }

    }
}
