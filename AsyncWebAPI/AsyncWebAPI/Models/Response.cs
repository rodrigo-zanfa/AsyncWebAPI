using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWebAPI.Models
{
    public class Response
    {
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<Todo> Todos { get; set; }
        public IEnumerable<User> Users { get; set; }
        public double TempoDeExecucaoEmSegundos { get; set; }
    }
}
