using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace upcDistribuidos.Entidades.Entidades
{
    [DataContract]
    public class Material
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
        [DataMember]
        public int TipoId { get; set; }
        [DataMember]
        public string Codigo{ get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string Autor { get; set; }
        [DataMember]
        public string Anio { get; set; }
        [DataMember]
        public string Editorial { get; set; }
        [DataMember]
        public bool Flag{ get; set; }

    }
}
