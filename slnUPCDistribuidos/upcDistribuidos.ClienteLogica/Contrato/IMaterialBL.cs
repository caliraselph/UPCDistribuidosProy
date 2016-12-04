using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.ClienteLogica.Contrato
{
    public interface IMaterialBL
    {
        Material ObtenerMaterial(string cod);
        Material RegistrarMaterial(Material material);
        List<MaterialListar> ListarMateriales(Material material);
        Material ModificarMaterial(Material material);
        void EliminarMaterial(string cod);
    }
}
