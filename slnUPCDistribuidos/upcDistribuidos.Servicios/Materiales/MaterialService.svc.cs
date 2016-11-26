using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Entidades.Errores;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Logica.Implementacion;
using System.ServiceModel.Web;
using System.Net;

namespace upcDistribuidos.Servicios.Materiales
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MaterialService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MaterialService.svc or MaterialService.svc.cs at the Solution Explorer and start debugging.
    public class MaterialService : IMaterialService
    {
        IMaterialBL logica = new MaterialBL();



        public List<MaterialListar> ListarMateriales(Material material)
        {
            if (material != null)
            {
                //if (!string.IsNullOrEmpty(material.Anio) ||!string.IsNullOrEmpty(material.Autor) ||
                //    !string.IsNullOrEmpty(material.Codigo) || material.Flag>0 || 
                //    !string.IsNullOrEmpty(material.Titulo))
                //{
                return logica.ListarMateriales(material);
                //}
                //else
                //{
                //    throw new FaultException<ParametroException>(
                //            new ParametroException { Codigo = "202", Mensaje = "Debe ingresar al menos un filtro" },
                //            new FaultReason("Error Listar Material")
                //        );

                //}
            }
            else
            {
                throw new FaultException<ParametroException>(
                            new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                            new FaultReason("Error Listar Material")
                       );
            }
            
        }

        public Material ModificarMaterial(Material material)
        {
            if (logica.ObtenerMaterial(material.Codigo) == null)
            {
                throw new WebFaultException<RepetidoException>(
                 new RepetidoException { Codigo = "102", Mensaje = "El material no existe" }, HttpStatusCode.InternalServerError
                 );

                //throw new FaultException<RepetidoException>(
                //    new RepetidoException
                //    {
                //        Codigo = "102",
                //        Descripcion = "El material no existe"
                //    },
                //    new FaultReason("Error al modificar Material")

                //    );

            }
            else
            {
                return logica.ModificarMaterial(material);
            }
        }

        public Material ObtenerMaterial(string cod)
        {
            if (!string.IsNullOrEmpty(cod))
            {
                return logica.ObtenerMaterial(cod);
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Error Obtener Material")
                );
            }
        }

        public Material RegistrarMaterial(Material material)
        {
            if (material != null)
            {
                if (!string.IsNullOrEmpty(material.Anio) || !string.IsNullOrEmpty(material.Autor) ||
                    !string.IsNullOrEmpty(material.Codigo) || !string.IsNullOrEmpty(material.Editorial) ||
                    material.Flag > 0 || !string.IsNullOrEmpty(material.Titulo) || material.TipoId > 0)
                {
                    if (logica.ObtenerMaterial(material.Codigo) != null)
                    {
                        throw new FaultException<RepetidoException>(
                            new RepetidoException { Codigo = "101", Mensaje = "Código ya Existe" },
                            new FaultReason("Error Registrar Material")
                        );
                    }
                    else
                    {
                        return logica.RegistrarMaterial(material);
                    }
                }
                else
                {
                    throw new FaultException<ParametroException>(
                            new ParametroException { Codigo = "203", Mensaje = "Faltan datos de materiales" },
                            new FaultReason("Error Registrar Material")
                        );
                }
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Error Registrar Material")
                );
            }
        }
    }
}
