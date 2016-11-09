using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace upcDistribuidos.Entidades.Errores
{
    public class ParametroException
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Mensaje { get; set; }
    }
}
