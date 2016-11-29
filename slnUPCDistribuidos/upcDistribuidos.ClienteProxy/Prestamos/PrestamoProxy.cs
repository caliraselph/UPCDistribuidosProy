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

namespace upcDistribuidos.ClienteProxy.Prestamos
{
    public class PrestamoProxy
    {
        PrestamoService.PrestamoServiceClient _services = new PrestamoService.PrestamoServiceClient();

        public PrestamoProxy()
        {
            _services = new PrestamoService.PrestamoServiceClient();
        }

        public List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, string fechaPresIni,
                                           string fechaPresFin, string fechaDevIni, string fechaDevFin)
        {
            try
            {
                return _services.BuscarPrestamo(codigo, estado, persona, fechaPresIni, fechaPresFin, fechaDevIni, fechaDevFin).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Prestamo ObtenerPrestamo(string cod)
        {
            try
            {
                return _services.ObtenerPrestamo(cod);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Prestamo RegistrarPrestamo(Prestamo prestamo)
        {
            try
            {
                return _services.RegistrarPrestamo(prestamo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
