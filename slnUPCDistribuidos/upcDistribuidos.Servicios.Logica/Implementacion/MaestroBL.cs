using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Datos.Maestros;

namespace upcDistribuidos.Servicios.Logica.Implementacion
{
    public class MaestroBL : IMaestroBL
    {
        MaestroDAO _dao = null;

        public MaestroBL()
        {
            _dao = new MaestroDAO();
        }

        public List<Categoria> ListarCategorias()
        {
            return _dao.ListarCategorias();
        }

        public List<Estado> ListarEstados()
        {
            return _dao.ListarEstados();
        }

        public List<TipoMaterial> ListarTipoMateriales()
        {
            return _dao.ListarTipoMateriales();
        }
    }
}
