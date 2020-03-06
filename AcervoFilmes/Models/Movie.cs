using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AcervoFilmes.Models
{
    public class Movie
    {
        public Movie()
        {
        }
    public int movieId { get; set; }

        [Display(Name = "Titulo")]
        public string title { get; set; }

        [Display(Name = "Sinopse")]
        public string sinopse { get; set; }

        [Display(Name = "Duração")]
        public int duration { get; set; }

        [Display(Name = "Ano Lançamento")]
        public int yearMovie { get; set; }

        [Display(Name = "Tipo de Midia")]
        public string typeMidia { get; set; }

        [Display(Name = "Direção")]
        public string direction { get; set; }

        [Display(Name = "Elenco")]
        public String elenco  { get; set; }

    }
}
