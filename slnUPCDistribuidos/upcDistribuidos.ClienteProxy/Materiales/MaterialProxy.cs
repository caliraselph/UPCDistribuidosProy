using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
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

        public Material ModificarMaterial(Material material)
        {
            Material _mat = null;
            try
            {
                string postdata = "{\"Codigo\":\"" + material.Codigo +
                                "\",\"Titulo\":\"" + material.Titulo +
                                "\",\"Autor\":\"" + material.Autor +
                                "\",\"Anio\":\"" + material.Anio +
                                "\",\"Editorial\":\"" + material.Editorial +
                                "\",\"Flag\":" + material.Flag +
                                ",\"Stock\":" + material.Stock +
                                ",\"Cantidad\":" + material.Cantidad +
                                ",\"TipoId\":" + material.TipoId + "}"; //JSON
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest
                    .Create("http://localhost:1594/Materiales/MaterialRESTService.svc/Material");
                req.Method = "PUT";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string materialJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();

                Material MaterialModificado = js.Deserialize<Material>(materialJson);
                _mat = MaterialModificado;
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string mensaje = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
            }
            return _mat;
        }

        public void EliminarMaterial(string cod)
        {
            try
            {
                HttpWebRequest req2 = (HttpWebRequest)WebRequest
               .Create("http://localhost:1594/Materiales/MaterialRESTService.svc/Material/" + cod);

                req2.Method = "DELETE";

                HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
                StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                string materialJson2 = reader2.ReadToEnd();
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string mensaje = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
            }
            
        }
    }
}
