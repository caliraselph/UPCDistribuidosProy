using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.ClienteProxy.Prestamos;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.ClienteLogica.Contrato;

namespace upcDistribuidos.ClienteLogica.Implementacion
{
    public class PrestamoBL : IPrestamoBL
    {
        PrestamoProxy _PrestamoProxy = new PrestamoProxy();
        public List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, string fechaPresIni,
                                           string fechaPresFin, string fechaDevIni, string fechaDevFin)
        {
            try
            {
                return _PrestamoProxy.BuscarPrestamo(codigo, estado, persona, fechaPresIni, fechaPresFin, fechaDevIni, fechaDevFin);
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
            
        }

        public Prestamo ObtenerPrestamo(string cod)
        {
            try
            {
                return _PrestamoProxy.ObtenerPrestamo(cod);
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
                return _PrestamoProxy.RegistrarPrestamo(prestamo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
