using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa_DAL.DAL
{
    public class PuntoCargaDAL
    {
        public EmpresaMedidoresEntities dbEntities = new EmpresaMedidoresEntities();

        //metodo agregar PuntoCarga
        public void Add(PuntoCarga p)
        {
            //equivalente al insert
            dbEntities.PuntoCarga.Add(p);
            //equivalente al commit
            dbEntities.SaveChanges();
        }
        //metodo para obtener todos los puntosCarga
        public List<PuntoCarga> GetAll()
        {
            return dbEntities.PuntoCarga.ToList();
        }
        /*metodo para obtener todaos los puntosCarga
         * que cumplan con ese parametro
        */
        public List<PuntoCarga> GetAll(int tipo)
        {
            var query = from c in dbEntities.PuntoCarga
                        where c.Tipo == tipo
                        select c;
            return query.ToList();
        }

        /*Metodo para buscar un PuntoCarga
         * recibe parametro id
         * busca puntoCarga con esa id y devuelve ese PuntoCarga
         */
        public PuntoCarga findById(int id)
        {
            return dbEntities.PuntoCarga.Find(id);
            
        }

        /*Metodo para actualizar un PuntoCarga
         * recibe parametro id
         * busca puntoCarga con esa id y remplaza atributos con los nuevos parametros
         */
        public void Update(int id, int tipo, int capacidadMax, DateTime vidaUtil)
        {
            var query = (from c in dbEntities.PuntoCarga
                         where c.Id == id
                         select c).FirstOrDefault();
            query.Tipo = tipo;
            query.CapacidadMaxima = capacidadMax;
            query.VidaUtil = vidaUtil;
            dbEntities.SaveChanges();

        }

    }
}
