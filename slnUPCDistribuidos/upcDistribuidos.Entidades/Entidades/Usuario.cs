using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace upcDistribuidos.Entidades.Entidades
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public String codUsuario { get; set; }

        [DataMember]
        public String password { get; set; }

        [DataMember]
        public String perfil_id { get; set; }

        [DataMember]
        public Boolean estado { get; set; }

        [DataMember]
        public int per_id { get; set; }

        [DataMember]
        public String nombre { get; set; }
    }
}
