using KutuphaneOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.BLL.Repository
{
    public class RepositoryBase<T,TId>where T:class
    {

        protected static Context db;

        public RepositoryBase()
        {
            db = db ?? new Context();
        }

        public virtual List<T> GetAll()
        {
            try
            {
                return db.Set<T>().ToList();
            }
            catch
            {

                throw;
            }
        }


        public virtual T GetById(TId id)
        {

            try
            {
                return db.Set<T>().Find(id);
            }
            catch 
            {

                throw;
            }
        }


        public virtual int Insert(T entity)
        {

            try
            {

                db.Set<T>().Add(entity);
                return db.SaveChanges();
            }
            catch 
            {

                throw;
            }
        }

        public virtual int Delete(T entity)
        {

            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges();
            }
            catch 
            {

                throw;
            }
        }

        public virtual int Update()
        {
            try
            {
                return db.SaveChanges();
            }
            catch 
            {

                throw;
            }

        }




    }
}
