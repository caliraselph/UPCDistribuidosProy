using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Servicios.Prestamos;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Logica.Implementacion;

namespace upcDistribuidos.Servicios.Prestamos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PrestamoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PrestamoService.svc o PrestamoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PrestamoService : IPrestamoService
    {

        IPrestamoBL _prestamoBL = new PrestamoBL();

        public List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, DateTime fechaPresIni, DateTime fechaPresFin, DateTime fechaDevIni, DateTime fechaDevFin)
        {
            return _prestamoBL.BuscarPrestamo(codigo,estado,persona,fechaPresIni,fechaPresFin,fechaDevIni,fechaDevFin);
        }

        public Prestamo ObtenerPrestamo(string cod)
        {
            return _prestamoBL.ObtenerPrestamo(cod);
        }

        public Prestamo RegistrarPrestamo(Prestamo prestamo)
        {
            return _prestamoBL.RegistrarPrestamo(prestamo);
        }
    }
}
