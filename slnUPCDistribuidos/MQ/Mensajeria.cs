using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using IronSharp.Core;
using IronSharp.IronMQ;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace MQ
{
    public class Mensajeria
    {

        public void RegistrarEntrada(Material entrada) {

            var ironMq = IronSharp.IronMQ.Client.New(
                new IronClientConfig { 
                    ProjectId = "583f8901bccbd80006c37d9c", 
                    Token = "D6DMW91CkzSnVPxH4PXM",
                    Host = "mq-aws-eu-west-1-1.iron.io",
                    Scheme = "http",
                    Port = 80        
            });

            QueueClient queue = ironMq.Queue("EntradasColas");
            string messageId = queue.Post(  entrada.Anio + "|" +entrada.Autor );
            
        }

        public List<Material> ListarEntradasCola(){

            List<Material> _entradas = new List<Material>();
            var ironMq = IronSharp.IronMQ.Client.New(
                new IronClientConfig
                {
                    ProjectId = "583f8901bccbd80006c37d9c",
                    Token = "D6DMW91CkzSnVPxH4PXM",
                    Host = "mq-aws-eu-west-1-1.iron.io",
                    Scheme = "http",
                    Port = 80
                });

            

            var queues = ironMq.Queues();
            string[] _cadena;
            foreach (var queueInfo in queues) { 
                QueueClient queue = ironMq.Queue("EntradasColas");
                QueueMessage message = queue.Reserve();
                _cadena = message.Body.ToString().Split('|');

                _entradas.Add(new Material {Autor= _cadena[0], Codigo = _cadena[1] });

                message.Delete();
            }


            return _entradas;
        }



    }
}
