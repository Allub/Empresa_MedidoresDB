using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_DAL.DAL
{
    public class EstacionServicioDAL
    {
        public EmpresaMedidoresEntities dbEntities = new EmpresaMedidoresEntities();

        //metodo agregar EstacionServicio 
        public void Add(EstacionServicio e)
        {
            //equivalente al insert
            dbEntities.EstacionServicio.Add(e);
            //equivalente al commit
            dbEntities.SaveChanges();
        }
        //metodo para obtener todas las estaciones 
        public List<EstacionServicio> GetAll()
        {
            return dbEntities.EstacionServicio.ToList();
        }
        /*metodo que elimina una estacion de servicio
        */
        public void Remove(int id)
        {
            //busca al objeto a eliminar
            EstacionServicio e = dbEntities.EstacionServicio.Find(id);
            dbEntities.EstacionServicio.Remove(e);
            dbEntities.SaveChanges();
        }
        /*Metodo para buscar una estacion
         * recibe parametro id
         * busca estacion con esa id y devuelve esta estacion
         */ 
        public EstacionServicio FindById(int id)
        {
            return dbEntities.EstacionServicio.Find(id);
        }
    }
}
