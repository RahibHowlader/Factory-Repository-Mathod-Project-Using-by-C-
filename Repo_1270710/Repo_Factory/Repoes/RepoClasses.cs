using Repo_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Factory.Repoes
{
    public interface IGenericRepo<T> where T : class, IEntity, new()
    {
        IList<T> Get();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
    public class GenericRepo<T> : IGenericRepo<T> where T : class, IEntity, new()
    {
        IList<T> data;
        public GenericRepo(IList<T> data)
        {
            this.data = data;
        }
        public T Get(int id)
        {
            return this.data.FirstOrDefault(x => x.Id == id);
        }
        public IList<T> Get()
        {
            return this.data;
        }
        public void Add(T obj)
        {
            this.data.Add(obj);
        }

        public void Update(T obj)
        {
            var x = this.data.FirstOrDefault(o => o.Id == obj.Id);
            if (x != null)
            {
                var i = this.data.IndexOf(x);
                this.data.RemoveAt(i);
                this.data.Insert(i, obj);
            }
        }
        public void Delete(int id)
        {
            var x = this.data.FirstOrDefault(o => o.Id == id);
            if (x != null)
            {
                var i = this.data.IndexOf(x);
                this.data.RemoveAt(i);
            }
        }


    }
    
}
