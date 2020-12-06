using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopapp.dataaccess.Absract;

namespace shopapp.dataaccess.Concrete.EfCoreRepository {
    public class EfCoreGerenericRepository<Tentity, TContext> : IRepository<Tentity>
        where Tentity : class
    where TContext : DbContext, new () {
        public void Create (Tentity entity) {
            using (var context = new TContext ()) {
                context.Set<Tentity>().Add (entity);
                context.SaveChanges();
            }
        }

        public void Delete (Tentity entity) {
            using (var context = new TContext()) {
                context.Set<Tentity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Tentity> GetAll() {
            using (var context = new TContext()){
                return context.Set<Tentity>().ToList();
            }
        }

        public Tentity GetById(int id) {
            using (var context = new TContext()){   
                return context.Set<Tentity>().Find(id);
            }
        }

        public void Update (Tentity entity) {
            using (var context = new TContext ()) {
                context.Entry(entity).State=EntityState.Modified;
              //  context.Set<Tentity>().Update(entity);
                context.SaveChanges();
            }
        }
    }
}