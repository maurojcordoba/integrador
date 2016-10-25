using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    class AdmClientes
    {
        public List<ClienteIndividuo> ListarClienteIndividuo()
        {
            List<ClienteIndividuo> lista = new List<ClienteIndividuo>();

            return lista;
        }

        public ClienteIndividuo ListarClienteIndividuo(string CUIT)
        {
            
            return new ClienteIndividuo() ;
        }

        public List<Empresa> ListarClienteEmpresa()
        {
            return new List<Empresa>(); 
        }

        public Empresa ListarClienteEmpresa(string CUIT)
        {
            return new Empresa();
        }


    }
}
