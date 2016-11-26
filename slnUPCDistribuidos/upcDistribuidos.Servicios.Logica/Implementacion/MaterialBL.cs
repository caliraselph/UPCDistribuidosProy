using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Servicios.Datos.Materiales;
using upcDistribuidos.Servicios.Logica.Contrato;

namespace upcDistribuidos.Servicios.Logica.Implementacion
{
    public class MaterialBL : IMaterialBL
    {
        MaterialDAO _dao = null;

        public MaterialBL()
        {
            _dao = new MaterialDAO();
        }

        public List<MaterialListar> ListarMateriales(Material material)
        {
            return _dao.ListarMateriales(material);
        }

        public Material ObtenerMaterial(string cod)
        {
            return _dao.ObtenerMaterial(cod);
        }

        public Material RegistrarMaterial(Material material)
        {
            return _dao.RegistrarMaterial(material);
        }
    }
}
