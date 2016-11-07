using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;

namespace upcDistribuidos.ClienteLogica.Contrato
{
   public  interface IMaestroBL
    {
        List<Estado> ListarEstados();
        List<TipoMaterial> ListarTipoMateriales();
        List<Categoria> ListarCategorias();
    }
}
