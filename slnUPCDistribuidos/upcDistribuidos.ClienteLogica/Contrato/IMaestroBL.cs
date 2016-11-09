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
        List<Estado> ListarEstados(int def);
        List<TipoMaterial> ListarTipoMateriales(int def);
        List<Categoria> ListarCategorias(int def);
    }
}
