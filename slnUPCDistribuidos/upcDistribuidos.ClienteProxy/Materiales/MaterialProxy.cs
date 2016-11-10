using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.ClienteProxy.Materiales
{
    public class MaterialProxy
    {
        MaterialService.MaterialServiceClient services;

        public MaterialProxy()
        {
            services = new MaterialService.MaterialServiceClient();
        }

        public Material ObtenerMaterial(string cod)
        {
         return  services.ObtenerMaterial(cod);
        }
        public Material RegistrarMaterial(Material material)
        {
            return services.RegistrarMaterial(material);
        }
        public List<MaterialListar> ListarMateriales(Material material)
        {
            return services.ListarMateriales(material).ToList();
        }

    }
}
