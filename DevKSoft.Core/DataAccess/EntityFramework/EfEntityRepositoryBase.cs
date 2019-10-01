using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Core.Entities;

namespace DevKSoft.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> :IEntityRepository<TEntity> 
    where TEntity:class,IEntity,new()
    where TContext:DbContext,new()
    {
        public List<TEntity> GelList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context= new TContext())
            {
                return filter==null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context= new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var context= new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }

        public TEntity Delete(TEntity entity)
        {
            using (var context= new TContext())
            {
                var deleteUpdate = context.Entry(entity);
                deleteUpdate.State = EntityState.Deleted;
                context.SaveChanges();
                return entity;
            }
        }
    }
}
