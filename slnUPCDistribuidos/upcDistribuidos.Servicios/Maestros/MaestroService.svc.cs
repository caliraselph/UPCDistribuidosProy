using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Logica.Implementacion;

namespace upcDistribuidos.Servicios.Maestros
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MaestroService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MaestroService.svc or MaestroService.svc.cs at the Solution Explorer and start debugging.
    public class MaestroService : IMaestroService
    {
        IMaestroBL _Logica = new MaestroBL();

        public List<Categoria> ListarCategorias()
        {
            return _Logica.ListarCategorias();
        }

        public List<Estado> ListarEstados()
        {
            return _Logica.ListarEstados();
        }

        public List<TipoMaterial> ListarTipoMateriales()
        {
            return _Logica.ListarTipoMateriales();
        }
    }
}
