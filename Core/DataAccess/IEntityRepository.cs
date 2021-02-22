using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // T için referans tip class olabilir ancak diyoruz. artık int,string gelemez T yerine. 
    //Ayrıca T IEntity ya da ondan implemente olan nesne olabilir diyoruz.
    //ARtık kafasına göre her şey gelemeyecektir.
    //new diyerek de IENtity olmasını engelliyoruz.. IEntity newlenemeyeceği için gelmesi engellendi.
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre=null filtre gelmese de olur
        T Get(Expression<Func<T, bool>> filter); // ilgili entitynin dönebilmesi için expression yazabilmemizi sağlasın diye
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
