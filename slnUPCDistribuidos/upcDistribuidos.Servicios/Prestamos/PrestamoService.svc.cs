using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.Entidades.Mapper;
using upcDistribuidos.Servicios.Logica.Contrato;
using upcDistribuidos.Servicios.Logica.Implementacion;
using upcDistribuidos.Entidades.Errores;
using upcDistribuidos.Servicios.Materiales;
using upcDistribuidos.Servicios.Personas;

namespace upcDistribuidos.Servicios.Prestamos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PrestamoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PrestamoService.svc o PrestamoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PrestamoService : IPrestamoService
    {

        IPrestamoBL _prestamoBL = new PrestamoBL();

        public bool AnularPrestamo(string cod)
        {
            if (_prestamoBL.ObtenerPrestamo(cod) == null)
            { 
                throw new FaultException<RepetidoException>(
                            new RepetidoException { Codigo = "101", Mensaje = "Codigo Erroneo" },
                            new FaultReason("Codigo Erroneo")
                        );
            }
            return _prestamoBL.AnularPrestamo(cod);

        }

        public List<PrestamoListar> BuscarPrestamo(string codigo, string estado, string persona, string fechaPresIni,
                                                   string fechaPresFin, string fechaDevIni, string fechaDevFin)
        {
            DateTime _fechaActual;
            if (
                (string.IsNullOrEmpty(codigo) || string.IsNullOrWhiteSpace(codigo))
                && (string.IsNullOrEmpty(estado) || string.IsNullOrWhiteSpace(estado) || estado.Equals("-1")) 
                && (string.IsNullOrEmpty(persona) || string.IsNullOrWhiteSpace(persona))
                && (string.IsNullOrEmpty(fechaPresIni) || string.IsNullOrWhiteSpace(fechaPresIni) )
                && (string.IsNullOrEmpty(fechaPresFin) || string.IsNullOrWhiteSpace(fechaPresFin))
                && (string.IsNullOrEmpty(fechaDevIni) || string.IsNullOrWhiteSpace(fechaDevIni) )
                && (string.IsNullOrEmpty(fechaDevFin) || string.IsNullOrWhiteSpace(fechaDevFin) )
               )
            {
                throw new FaultException<ParametroException>(
                        new ParametroException { Codigo = "202", Mensaje = "Debe ingresar al menos un filtro" },
                        new FaultReason("Debe ingresar al menos un filtro")
                     );
            }

            if (
                (!string.IsNullOrEmpty(fechaPresIni) && !DateTime.TryParse(fechaPresIni, out _fechaActual) )
                || (!string.IsNullOrEmpty(fechaPresFin) && !DateTime.TryParse(fechaPresFin, out _fechaActual))
                || (!string.IsNullOrEmpty(fechaDevIni) && !DateTime.TryParse(fechaDevIni, out _fechaActual) )
                || (!string.IsNullOrEmpty(fechaDevFin) && !DateTime.TryParse(fechaDevFin, out _fechaActual))
                )
            {
                throw new FaultException<ParametroException>(
                        new ParametroException { Codigo = "203", Mensaje = "Tipo de dato Fecha es incorrecto" },
                        new FaultReason("Tipo de dato Fecha es incorrecto")
                     );
            }

            _fechaActual = DateTime.Now;
            int Year = _fechaActual.Year;
            int Mount = _fechaActual.Month;
            int Day = _fechaActual.Day;
            string fechafind = string.Concat(Day, "/", Mount, "/", Year, " 00:00");


            DateTime _fechaInicioDefault = DateTime.Parse("01/01/1753 00:00");
            DateTime _fechaFinDefault = DateTime.Parse(fechafind).AddDays(100);
                
            DateTime _fechaPresIni = (string.IsNullOrEmpty(fechaPresIni) || string.IsNullOrWhiteSpace(fechaPresIni)) ? _fechaInicioDefault : DateTime.Parse(fechaPresIni) ;
            DateTime _fechaPresFin = (string.IsNullOrEmpty(fechaPresFin) || string.IsNullOrWhiteSpace(fechaPresFin)) ? _fechaFinDefault : DateTime.Parse(fechaPresFin);
            DateTime _fechaDevIni = (string.IsNullOrEmpty(fechaDevIni) || string.IsNullOrWhiteSpace(fechaDevIni)) ? _fechaInicioDefault : DateTime.Parse(fechaDevIni);
            DateTime _fechaDevFin = (string.IsNullOrEmpty(fechaDevFin) || string.IsNullOrWhiteSpace(fechaDevFin)) ? _fechaFinDefault : DateTime.Parse(fechaDevFin);
            
            return _prestamoBL.BuscarPrestamo(codigo, estado, persona, _fechaPresIni, _fechaPresFin, _fechaDevIni, _fechaDevFin);
            
        }

        public bool DevolverPrestamo(string cod)
        {
            if (_prestamoBL.ObtenerPrestamo(cod) == null)
            {
                throw new FaultException<RepetidoException>(
                            new RepetidoException { Codigo = "101", Mensaje = "Codigo Erroneo" },
                            new FaultReason("Codigo Erroneo")
                        );
            }
            return _prestamoBL.DevolverPrestamo(cod);
        }

        public Prestamo ObtenerPrestamo(string cod)
        {
            if (!string.IsNullOrEmpty(cod))
            {
                return _prestamoBL.ObtenerPrestamo(cod);
            }
            else
            {
                throw new FaultException<ParametroException>(
                      new ParametroException { Codigo = "201", Mensaje = "Parametro vacio" },
                      new FaultReason("Parametro vacio")
                );

            }
        }

        public Prestamo RegistrarPrestamo(Prestamo prestamo)
        {
            if ((prestamo == null ) ||
                (prestamo.Persona == null) ||
                (prestamo.Estado == null || prestamo.Estado <= 0 ) ||
                (string.IsNullOrEmpty( prestamo.Persona.Codigo) || string.IsNullOrWhiteSpace(prestamo.Persona.Codigo)) ||
                (prestamo.Materiales == null )
                
               )
            {
                throw new FaultException<ParametroException>(
                                   new ParametroException { Codigo = "201", Mensaje = "Datos incompletos" },
                                   new FaultReason("Datos incompletos")
                             );
            }

            IPersonaService _servicesPersona = new PersonaService();

            if (_servicesPersona.ObtenerPersona(prestamo.Persona.Codigo) == null) {
                throw new FaultException<RepetidoException>(
                      new RepetidoException { Codigo = "101", Mensaje = "Código de Persona no Existe."  },
                      new FaultReason("Código de Persona no Existe.")
                  );
            }


            if (prestamo.Materiales.Count <=0)
            {
                throw new FaultException<ParametroException>(
                               new ParametroException { Codigo = "202", Mensaje = "No existe Materiales" },
                               new FaultReason("No existe Materiales")
                         );
            }

            if (prestamo.Materiales.Count > 3)
            {
                throw new FaultException<ParametroException>(
                               new ParametroException { Codigo = "203", Mensaje = "Solo se permite hasta 3 materiales por registro" },
                               new FaultReason("Solo se permite hasta 3 materiales por registro")
                         );
            }

            IMaterialService _MaterialService = new MaterialService();
            foreach (Material item in prestamo.Materiales)
            {
                Material _material = _MaterialService.ObtenerMaterial(item.Codigo);
                if (_material == null)
                {
                    throw new FaultException<RepetidoException>(
                       new RepetidoException { Codigo = "101", Mensaje = "Código de material no Existe. Material : " + item.Codigo },
                       new FaultReason("Código de material no Existe. Material : " + item.Codigo)
                   );
                }

                if (_material.Flag == 0)
                {
                    throw new FaultException<ParametroException>(
                       new ParametroException { Codigo = "103", Mensaje = "Material Inactivo. Material : " + item.Codigo },
                       new FaultReason("Material Inactivo. Material : " + item.Codigo)
                   );
                }

                if (_material.Stock < 1)
                {
                    throw new FaultException<ParametroException>(
                             new ParametroException { Codigo = "203", Mensaje = "No hay stock para el material : " + item.Codigo },
                             new FaultReason("No hay stock para el material : " + item.Codigo)
                       );
                }
            }
            
            return _prestamoBL.RegistrarPrestamo(prestamo);
        }
    }
}
