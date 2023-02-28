
using Repo_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo__Factory.Factories
{
    public interface IModelFactory
    {
        T Create<T>(params object[] args) where T : class, IEntity, new();
    }
    public class ModelFactory : IModelFactory
    {
        public T Create<T>(params object[] args) where T : class, IEntity, new()
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }

    }
}
