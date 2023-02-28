using Repo_Method.Models;
using Repo_Method.Repoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepoCreator creator = new RepoCreator();
            var pr = creator.GetRepo<Publisher>();
            var p1 = new Publisher(1, "Wrox Inc.");
            var p2 = new Publisher(2, "A Press");
            var p3 = new Publisher(3, "M Press");
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
            var br = creator.GetRepo<Book>();
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
