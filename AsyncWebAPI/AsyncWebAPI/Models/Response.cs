using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWebAPI.Models
{
    public class Response
    {
        public double TempoDeExecucaoEmSegundosPosts { get; set; }
        public double TempoDeExecucaoEmSegundosComments { get; set; }
        public double TempoDeExecucaoEmSegundosAlbums { get; set; }
        public double TempoDeExecucaoEmSegundosPhotos { get; set; }
        public double TempoDeExecucaoEmSegundosTodos { get; set; }
        public double TempoDeExecucaoEmSegundosUsers { get; set; }
        public double TempoDeExecucaoEmSegundosTotal { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Album> Albums { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public IEnumerable<Todo> Todos { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
