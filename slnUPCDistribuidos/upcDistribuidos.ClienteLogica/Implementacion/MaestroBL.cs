using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.ClienteProxy.Maestros;
using upcDistribuidos.ClienteLogica.Contrato;

namespace upcDistribuidos.ClienteLogica.Implementacion
{
    public class MaestroBL : IMaestroBL
    {
        MaestroProxy proxy;
        public MaestroBL()
        {
            proxy = new MaestroProxy();
        }

        public List<Categoria> ListarCategorias()
        {
            return proxy.ListarCategorias();
        }

        public List<Estado> ListarEstados()
        {
            return proxy.ListarEstados();
        }

        public List<TipoMaterial> ListarTipoMateriales()
        {
            return proxy.ListarTipoMateriales();
        }
    }
}
