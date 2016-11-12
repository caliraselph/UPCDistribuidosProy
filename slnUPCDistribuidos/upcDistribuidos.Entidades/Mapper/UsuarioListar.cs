using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace upcDistribuidos.Entidades.Mapper
{
    [DataContract]
    public class UsuarioListar
    {
        [DataMember]
        public string CodUsuario { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Perfil { get; set; }
        [DataMember]
        public string NombreCompleto { get; set; }
    }
}
