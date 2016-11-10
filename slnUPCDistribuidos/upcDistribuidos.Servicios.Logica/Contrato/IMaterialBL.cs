using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Servicios.Datos.Materiales;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.Servicios.Logica.Contrato
{
    public interface IMaterialBL
    {
        Material ObtenerMaterial(string cod);
        Material RegistrarMaterial(Material material);
        List<MaterialListar> ListarMateriales(Material material);
    }
}
