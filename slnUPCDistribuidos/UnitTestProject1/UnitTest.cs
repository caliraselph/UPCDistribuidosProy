using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrearPersonaOK()
        {
            contratoPersona.PersonasClient conPersona = new contratoPersona.PersonasClient();
            contratoPersona.Persona persona = new contratoPersona.Persona
            {
                Id = 0,
                Nombres = "C1",
                Apellidos = "C2",
                Celular = "123",
                Codigo = "U201",
                Correo = "CCCCC",
                Deuda = 0,
                Direccion = "XX",
                NroLibros = 0
            };


            contratoPersona.Persona nuevaPersona = conPersona.PersonaCrearAsync(persona);

            Assert.AreEqual("U201",);



        }
    }
}
