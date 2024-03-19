using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public class Repository : IRepository<T> where T : class

    {
        private readonly Exaconection dbcontext;

        public Repository()
        {
            this.dbcontext = new Exaconection();
        }

        public void Agregar(T entidad)
        {
            dbcontext.Set<T>().Add(entidad);
            dbcontext.SaveChanges();
        }

        public void AgregarRango(IEnumerable<T> entidades)
        {
            dbcontext.Set<T>.AddRange(entidades);
            dbcontext.SaveChanges();
        }

        public void Buscar(T entidad)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }

        public void Editar(T entidad)
        {
            dbcontext.Set<T>();
            dbcontext.SaveChanges();
        }

        public void Eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
            dbcontext.SaveChanges();
        }
    }
}
