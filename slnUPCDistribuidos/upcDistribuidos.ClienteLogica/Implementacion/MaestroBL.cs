using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upcDistribuidos.Entidades.Entidades;
using upcDistribuidos.ClienteProxy.Maestros;
using upcDistribuidos.ClienteLogica.Contrato;
using upcDistribuidos.Comun;

namespace upcDistribuidos.ClienteLogica.Implementacion
{
    public class MaestroBL : IMaestroBL
    {
        MaestroProxy proxy;
        public MaestroBL()
        {
            proxy = new MaestroProxy();
        }

        public List<Categoria> ListarCategorias(int def)
        {
            List<Categoria> _lista = new List<Categoria>();

            if (def == 1) // Deault Seleccionar
                _lista.Add(new Categoria {Id = Convert.ToInt16(Estados.Seleccionar_Cod), Descripcion = Estados.Seleccionar_Value });
            else // default Todos
                _lista.Add(new Categoria { Id = Convert.ToInt16(Estados.Todos_Cod), Descripcion = Estados.Todos_Value });

            _lista.AddRange(proxy.ListarCategorias());

            return _lista;
        }

        public List<Estado> ListarEstados(int def)
        {
            List<Estado> _lista = new List<Estado>();

            if (def == 1) // Deault Seleccionar
                _lista.Add(new Estado { Id = Convert.ToInt16(Estados.Seleccionar_Cod), Descripcion = Estados.Seleccionar_Value });
            else // default Todos
                _lista.Add(new Estado { Id = Convert.ToInt16(Estados.Todos_Cod), Descripcion = Estados.Todos_Value });

            _lista.AddRange(proxy.ListarEstados());

            return _lista;
        }

        public List<Estado> ListarFlags(int def)
        {
            List<Estado> _lista = new List<Estado>();
            
            if (def == 1) // Deault Seleccionar
                _lista.Add(new Estado { Id = Convert.ToInt16(Estados.Seleccionar_Cod), Descripcion = Estados.Seleccionar_Value });
            else // default Todos
                _lista.Add(new Estado { Id = Convert.ToInt16(Estados.Todos_Cod), Descripcion = Estados.Todos_Value });

            _lista.Add(new Estado { Id = Convert.ToInt16(Estados.FLAG_ALTA), Descripcion = Estados.ALTA_Value });
            _lista.Add(new Estado { Id = Convert.ToInt16(Estados.FLAG_BAJA), Descripcion = Estados.BAJA_VALUE });

            return _lista;
        }

        public List<TipoMaterial> ListarTipoMateriales(int def)
        {

            List<TipoMaterial> _lista = new List<TipoMaterial>();

            if (def == 1) // Deault Seleccionar
                _lista.Add(new TipoMaterial { Id = Convert.ToInt16(Estados.Seleccionar_Cod), Descripcion = Estados.Seleccionar_Value });
            else // default Todos
                _lista.Add(new TipoMaterial { Id = Convert.ToInt16(Estados.Todos_Cod), Descripcion = Estados.Todos_Value });

            _lista.AddRange(proxy.ListarTipoMateriales());

            return _lista;
            
        }
    }
}
