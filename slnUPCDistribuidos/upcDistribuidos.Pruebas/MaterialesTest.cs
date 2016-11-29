using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using upcDistribuidos.Entidades.Entidades;
using System.Text;

namespace upcDistribuidos.Pruebas
{
    [TestClass]
    public class MaterialesTest
    {
        [TestMethod]
        public void Test1RegistrarMaterialOk()
        {
            MaterialesWS.MaterialServiceClient proxy = new MaterialesWS.MaterialServiceClient();
            MaterialesWS.Material materialCreado = proxy.RegistrarMaterial(new MaterialesWS.Material()
            {
                Codigo = "M007",
                Titulo = "Los Gallinazos Sin Plumas",
                Autor = "Julio Ramon Ribeyro",
                Editorial = "Norma",
                TipoId = 1,
                Cantidad = 4,
                Flag = 1,
                Anio = "2002",
                Stock = 5

            });
            Assert.AreEqual("M007", materialCreado.Codigo);
            Assert.AreEqual("Los Gallinazos Sin Plumas", materialCreado.Titulo);
            Assert.AreEqual("Julio Ramon Ribeyro", materialCreado.Autor);
        }

        [TestMethod]
        public void Test2CrearMaterialRepetido()
        {
            MaterialesWS.MaterialServiceClient proxy = new MaterialesWS.MaterialServiceClient();
            try
            {
                MaterialesWS.Material materialCreado = proxy.RegistrarMaterial(new MaterialesWS.Material()
                {
                    Codigo = "M003",
                    Titulo = "Los Gallinazos Sin Plumas",
                    Autor = "Julio Ramon Ribeyro",
                    Editorial = "Norma",
                    TipoId = 1,
                    Cantidad = 4,
                    Flag = 1,
                    Anio = "2002",
                    Stock = 5

                });
            }
            catch (FaultException<MaterialesWS.RepetidoException> error)
            {
                Assert.AreEqual("Error Registrar Material", error.Reason.ToString());
                Assert.AreEqual(error.Detail.Codigo, "101");
                Assert.AreEqual(error.Detail.Mensaje, "Código ya Existe");
            }

        }

        [TestMethod]
        public void Test3BuscarMaterialOk()
        {
            //MaterialesWS.MaterialServiceClient proxy = new MaterialesWS.MaterialServiceClient();
            //MaterialesWS.Material material = new MaterialesWS.Material();

            //material.Codigo = "M003";
            //material.Anio = "2001";
            //material.Autor = "Julio";
            //material.Flag = 1;
            //material.Titulo = "La";

            //MaterialesWS.MaterialListar materiales = proxy.ListarMateriales(new MaterialesWS.Material()
            //{
            //    Codigo = "M003",
            //    Titulo = "La Palabra del Mudo",
            //    Autor = "Julio Ramon Ribeyro",
            //    Anio = "2001",
            //    Stock = 10
            //});

            //Assert.AreEqual("La Palabra del Mudo", material.Titulo);
            //Assert.AreEqual("Bruno", materiales.Editorial);
            //Assert.AreEqual(10, materiales.Stock);
        }

        [TestMethod]
        public void Test4BuscarMaterialRepetido()
        {
            //MaterialesWS.MaterialServiceClient proxy = new MaterialesWS.MaterialServiceClient();
            //try
            //{
            //    MaterialesWS.Material materialModificado = proxy.ModificarMaterial(new MaterialesWS.Material()
            //    {
            //        Codigo = "M004",
            //        Titulo = "ZZZ",
            //        Autor = "Julio Ramon Ribeyro",
            //        Editorial = "Norma",
            //        Tipo = 1,
            //        Stock = 0

            //    });
            //}
            //catch (FaultException<MaterialesWS.RepetidoException> error)
            //{
            //    Assert.AreEqual("Error al intentar la modificación", error.Reason.ToString());
            //    Assert.AreEqual(error.Detail.Codigo, "102");
            //    Assert.AreEqual(error.Detail.Descripcion, "El material no existe");
            //}
        }

        [TestMethod]
        public void Test5ModificarOk()
        {

                string postdata = "{\"Codigo\":\"M002\",\"Titulo\":\"Apple Ni mas ni Menos\",\"Autor\":\"Steve Jobs\",\"Anio\":\"2014\",\"Editorial\":\"Apple Inc.\",\"Flag\":1,\"Stock\":20,\"Cantidad\":5,\"TipoId\":1}"; //JSON
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

                Material MaterialCreado = js.Deserialize<Material>(materialJson);

                Assert.AreEqual("2014", MaterialCreado.Anio);
                Assert.AreEqual("Steve Jobs", MaterialCreado.Autor);
                Assert.AreEqual("M002", MaterialCreado.Codigo);
                Assert.AreEqual("Apple Ni mas ni Menos", MaterialCreado.Titulo);

        }
    }
}