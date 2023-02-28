using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Factory.Models
{
    public interface IEntity
    {
        int Id { get; set; }
    }
    public class Publisher : IEntity
    {
        public Publisher() { }
        public Publisher(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
       
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }
    }
    public class Book : IEntity
    {
        public Book() { }
        public Book(int id, string title, int publisherId)
        {
            this.Id = id;
            this.Title = title;
            this.PublisherId = publisherId;

        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublisherId { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Title} Pub. Id: {PublisherId}";
        }
    }
}
