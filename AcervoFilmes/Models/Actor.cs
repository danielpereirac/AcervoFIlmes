using System;
namespace AcervoFilmes.Models
{
    public class Actor
    {
        public Actor()
        {
        }
        public int actorId { get; set; }
        public int movieId { get; set; }
        public string actor { get; set; }
    }
}
