using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.ClienteProxy.Maestros
{
    public class MaestroProxy
    {
        MaestroService.MaestroServiceClient services;

        public MaestroProxy()
        {
            services = new MaestroService.MaestroServiceClient();
        }
        public List<Estado> ListarEstados()
        {
            return services.ListarEstados().ToList();
        }
        public List<TipoMaterial> ListarTipoMateriales()
        {
            return services.ListarTipoMateriales().ToList();
        }
        public List<Categoria> ListarCategorias()
        {
            return services.ListarCategorias().ToList();
        }
    }
}
