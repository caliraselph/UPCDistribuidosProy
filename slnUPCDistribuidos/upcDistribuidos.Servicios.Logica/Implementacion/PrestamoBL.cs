using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Comun;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Datos.Prestamos;

namespace upcDistribuidos.Servicios.Logica.Implementacion
{
    public class PrestamoBL : IPrestamoBL
    {
        PrestamoDAO _dao = null;

        public PrestamoBL()
        {
            _dao = new PrestamoDAO();
        }

        public List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, DateTime fechaPresIni, DateTime fechaPresFin, DateTime fechaDevIni, DateTime fechaDevFin)
        {
            return _dao.BuscarPrestamo(codigo, estado, persona, fechaPresIni, fechaPresFin, fechaDevIni, fechaDevFin);
        }

        public Prestamo ObtenerPrestamo(string cod)
        {
            return _dao.ObtenerPrestamo(cod);
        }

        public Prestamo RegistrarPrestamo(Prestamo prestamo)
        {
            return _dao.RegistrarPrestamo(prestamo);
        }
    }
}
