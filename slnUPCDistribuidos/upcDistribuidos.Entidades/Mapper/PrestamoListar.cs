using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace upcDistribuidos.Entidades.Mapper
{
    [DataContract]
    public class PrestamoListar
    {
        [DataMember]
        public string Codigo {get;set;}
        [DataMember]
        public string CodPersona { get;set;}
        [DataMember]
        public string Persona { get;set;}
        [DataMember]
        public string FechaReserva { get;set;}
        [DataMember]
        public string FechaPrestamo { get;set;}
        [DataMember]
        public string FechaEntrega { get;set;}
        [DataMember]
        public string FechaDevolucion { get;set;}
        [DataMember]
        public string CodEstado { get;set;}
        [DataMember]
        public string Estado { get;set;}

    }
}
