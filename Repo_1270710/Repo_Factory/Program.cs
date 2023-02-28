using Ex_03_Project_Repo_Factory.Factories;
using Repo__Factory.Factories;
using Repo_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rf = new RepoFactoryImpl();
            var pr = rf.Create<Repo_Factory.Models.Publisher>();
            var ef = new ModelFactory();
            var p1 = ef.Create< Publisher>(1, "Wrox Inc.");
            var p2 = ef.Create<Publisher>(2, "A Press");
            var p3 = ef.Create<Publisher>(3, "M Press");
            pr.Add(p1);
            pr.Add(p2);
            pr.Add(p3);
            Console.WriteLine("Read");
            pr.Get()
                .ToList()
                .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Update");
            p3.Name = "B Press";
            pr.Update(p3);
            pr.Get()
               .ToList()
               .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Delete");
            pr.Delete(3);
            pr.Get()
              .ToList()
              .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("------------------------------------");
            var br = rf.Create<Book>();
            var b1 = new Book(1, "AA", 1);
            var b2 = new Book(2, "BB", 1);
            var b3 = new Book(3, "CC", 2);
            br.Add(b1);
            br.Add(b2);
            br.Add(b3);
            Console.WriteLine("Read");
            br.Get()
                .ToList()
                .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Update");
            b2.PublisherId = 2;
            br.Update(b2);
            br.Get()
               .ToList()
               .ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Delete");
            br.Delete(2);
            br.Get()
              .ToList()
              .ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
