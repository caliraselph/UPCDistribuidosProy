using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.ClienteProxy;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.ClienteProxy.Materiales;

namespace upcDistribuidos.ClienteLogica.Implementacion
{
    public class MaterialBL : IMaterialBL
    {
        MaterialProxy proxy;

        public MaterialBL()
        {
            proxy = new MaterialProxy();
        }

        public List<MaterialListar> ListarMateriales(Material material)
        {
            List<MaterialListar> lista = new List<MaterialListar>();

            lista = proxy.ListarMateriales(material);

            return lista;
        }

        public Material ObtenerMaterial(string cod)
        {
            Material materialObtenido = new Material();

            materialObtenido = proxy.ObtenerMaterial(cod);

            return materialObtenido;
        }

        public Material RegistrarMaterial(Material material)
        {
            Material materialCreado;

            materialCreado = proxy.RegistrarMaterial(material);

            return materialCreado;
        }

        public Material ModificarMaterial(Material material)
        {
            Material materialModificado;

            materialModificado = proxy.ModificarMaterial(material);

            return materialModificado;
        }

        public void EliminarMaterial(string cod)
        {
            proxy.EliminarMaterial(cod);
        }
    }
}
