using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Errores;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Logica.Implementacion;

namespace upcDistribuidos.Servicios.Materiales
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MaterialRESTService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MaterialRESTService.svc o MaterialRESTService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MaterialRESTService : IMaterialRESTService
    {
        IMaterialBL logica = new MaterialBL();
        public void EliminaMaterial(string cod)
        {
            if (logica.ObtenerMaterial(cod) == null)
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
                logica.EliminarMaterial(cod);
            }
        }

        public Material ModificarMaterial(Material material)
        {
            int num = 0;
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
            else if (!int.TryParse(material.Anio,out num))
            {
                throw new WebFaultException<RepetidoException>(
                 new RepetidoException { Codigo = "103", Mensaje = "Formato de Año no permitido" }, HttpStatusCode.PreconditionFailed
                 );
            }
            else
            {
                return logica.ModificarMaterial(material);
            }
        }
    }
}
