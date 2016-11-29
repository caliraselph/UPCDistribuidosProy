using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace upcDistribuidos.Entidades.Entidades
{
    [DataContract]
    public class Prestamo
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public int? Estado { get; set; }
        [DataMember]
        public DateTime? FechaReserva { get; set; }
        [DataMember]
        public DateTime? FechaPrestamo{ get; set; }
        [DataMember]
        public DateTime? FechaEntrega { get; set; }
        [DataMember]
        public DateTime? FechaDevolucion { get; set; }
        [DataMember]
        public String Observacion { get; set; }
        [DataMember]
        public int? PersonaId { get; set; }
        [DataMember]
        public int? UsuarioCreacion { get; set; }
        [DataMember]
        public List<Material> Materiales { get; set; }
        [DataMember]
        public Persona Persona { get; set; }


    }
}
