using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Errores;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.Pruebas
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void Test1RegistrarUsuarioOk()
        {
            UsuarioWS.UsuarioServiceClient proxy = new UsuarioWS.UsuarioServiceClient();
            Usuario usuarioCreado = proxy.RegistrarUsuario(new Usuario()
            {
                codUsuario = "RRIOS",
                password = "1234",
                perfil_id = "USU",
                estado = true,
                per_id = 1001
            });
            Assert.AreEqual("RRIOS", usuarioCreado.codUsuario);
        }

        [TestMethod]
        public void Test2CrearUsuarioRepetido()
        {
            UsuarioWS.UsuarioServiceClient proxy = new UsuarioWS.UsuarioServiceClient();
            try
            {
                Usuario usuarioCreado = proxy.RegistrarUsuario(new Usuario()
                {
                    codUsuario = "SARIZACA",
                    password = "1234",
                    perfil_id = "USU",
                    estado = true,
                    per_id = 1001
                });
            }
            catch (FaultException<RepetidoException> error)
            {
                Assert.AreEqual("Error Registrar Usuario", error.Reason.ToString());
                Assert.AreEqual(error.Detail.Codigo, "SARIZACA");
                Assert.AreEqual(error.Detail.Mensaje, "Código ya Existe");
            }

        }
    }
}
