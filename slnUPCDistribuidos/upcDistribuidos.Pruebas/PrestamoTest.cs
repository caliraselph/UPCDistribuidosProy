using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Entidades.Errores;
using System.Collections.Generic;

namespace upcDistribuidos.Pruebas
{
    [TestClass]
    public class PrestamoTest
    {
        [TestMethod]
        public void ObtenerPrestamoOK()
        {
            string _cod = "PR-2000";

            PrestamoWS.PrestamoServiceClient _servicio = new PrestamoWS.PrestamoServiceClient();

            Prestamo _pres = _servicio.ObtenerPrestamo(_cod);

            Assert.AreEqual(_cod, _pres.Codigo);


        }

        [TestMethod]
        public void RegistrarPrestamo()
        {
            Prestamo _prestamo = new Prestamo
            {
                Estado = 1,
                FechaDevolucion = DateTime.Now,
                FechaEntrega = DateTime.Now,
                FechaPrestamo = DateTime.Now,
                FechaReserva = DateTime.Now,
                Observacion = "test",
                Persona = 1002,
                UsuarioCreacion = 1002,
                Materiales = new List<Material>() {
                    new Material { Codigo ="HIS-101"},
                    new Material { Codigo= "CIE-101"}
                }
            };



            PrestamoWS.PrestamoServiceClient _servicio = new PrestamoWS.PrestamoServiceClient();

            Prestamo _pres = _servicio.RegistrarPrestamo(_prestamo);

        }

    }
}
