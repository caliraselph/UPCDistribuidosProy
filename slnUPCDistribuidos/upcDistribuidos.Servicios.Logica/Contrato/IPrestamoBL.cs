using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Servicios.Datos.Prestamos;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.Servicios.Logica.Contrato
{
    public interface IPrestamoBL
    {
        List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, DateTime fechaPresIni,
                                                   DateTime fechaPresFin, DateTime fechaDevIni, DateTime fechaDevFin);

        Prestamo ObtenerPrestamo(string cod);

        Prestamo RegistrarPrestamo(Prestamo prestamo);

        bool AnularPrestamo(string cod);

        bool DevolverPrestamo(string cod);
    }
}
