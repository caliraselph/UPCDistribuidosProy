using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.ClienteLogica.Contrato
{
    public interface IPrestamoBL
    {
        
        List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, string fechaPresIni,
                                           string fechaPresFin, string fechaDevIni, string fechaDevFin);

        Prestamo ObtenerPrestamo(string cod);

        Prestamo RegistrarPrestamo(Prestamo prestamo);

        bool AnularPrestamo(string cod);

        bool DevolverPrestamo(string cod);
    }
}
