using Repo_Factory.Models;
using Repo_Factory.Repoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03_Project_Repo_Factory.Factories
{
    public interface IRepoFactory
    {
        IGenericRepo<T> Create<T>() where T : class, IEntity, new();
    }
    public class RepoFactoryImpl : IRepoFactory
    {
        public IGenericRepo<T> Create<T>() where T : class, IEntity, new()
        {
            return Activator.CreateInstance(typeof(GenericRepo<T>),
            new object[] { new List<T>() }) as GenericRepo<T>;
        }
    }
}
