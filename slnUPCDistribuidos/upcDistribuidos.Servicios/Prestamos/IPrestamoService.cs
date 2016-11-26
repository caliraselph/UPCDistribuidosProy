﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;

namespace upcDistribuidos.Servicios.Prestamos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPrestamoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPrestamoService
    {
        [OperationContract]
        List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, DateTime fechaPresIni,
                                                   DateTime fechaPresFin, DateTime fechaDevIni, DateTime fechaDevFin);
        [OperationContract]
        Prestamo ObtenerPrestamo(string cod);

        [OperationContract]
        Prestamo RegistrarPrestamo(Prestamo prestamo);
    }
}