using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFServices.Dominio
{
    [DataContract]
    public class Persona
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Celular { get; set; }
        [DataMember]
        public byte NroLibros { get; set; }
        [DataMember]
        public decimal Deuda { get; set; }

    }
}