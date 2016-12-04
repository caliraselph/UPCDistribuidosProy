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

        public void RegistrarEntrada(Persona entrada) {

            var ironMq = IronSharp.IronMQ.Client.New(
                new IronClientConfig { 
                    ProjectId = "58447b19d9cc19000737b8c1", 
                    Token = "Dpwg2GhZP66fZGIpyfkG",
                    Host = "mq-aws-eu-west-1-1.iron.io",
                    Scheme = "http",
                    Port = 80        
            });

            QueueClient queue = ironMq.Queue("persona");
            string messageId = queue.Post(  entrada.Codigo + "|" +entrada.Nombres + "|" + entrada.Apellidos
                + "|" + entrada.Correo + "|" + entrada.Direccion + "|" + entrada.Celular + "|" + "0" + "|" + "0.0");
            
        }

        public List<Persona> ListarEntradasCola(){

            List<Persona> _entradas = new List<Persona>();
            var ironMq = IronSharp.IronMQ.Client.New(
                new IronClientConfig
                {
                    ProjectId = "58447b19d9cc19000737b8c1",
                    Token = "Dpwg2GhZP66fZGIpyfkG",
                    Host = "mq-aws-eu-west-1-1.iron.io",
                    Scheme = "http",
                    Port = 80
                });

            

            var queues = ironMq.Queues();
            string[] _cadena;
            foreach (var queueInfo in queues) { 
                QueueClient queue = ironMq.Queue("persona");
                QueueMessage message = queue.Reserve();
                _cadena = message.Body.ToString().Split('|');

                _entradas.Add(new Persona { Codigo= _cadena[0], Nombres = _cadena[1] });

                message.Delete();
            }


            return _entradas;
        }



    }
}
