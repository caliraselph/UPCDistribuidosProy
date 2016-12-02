using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace upcDistribuidos.Entidades.Mapper
{
    [DataContract]
    public class MaterialListar
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string Autor { get; set; }
        [DataMember]
        public string Anio { get; set; }
        [DataMember]
        public string Editorial { get; set; }
        [DataMember]
        public string Flag { get; set; }
        [DataMember]
        public string TipoMaterial { get; set; }

        [DataMember]
        public int stock { get; set; }

    }
}
