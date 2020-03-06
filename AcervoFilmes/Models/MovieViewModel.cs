using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
namespace AcervoFilmes.Models
{
    public class MovieViewModel
    {
        public MovieViewModel()
        {
        }

        public Int32 MovieId { get; set; }

        [Required(ErrorMessage = "O titulo do filme é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Titulo")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Informe a sinopse", AllowEmptyStrings = false)]
        [Display(Name = "Sinopse")]
        public String Sinopse { get; set; }

        [Required(ErrorMessage = "Informe o preço do produto", AllowEmptyStrings = false)]
        [Display(Name = "Duração")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "Informe um ano", AllowEmptyStrings = false)]
        [Display(Name = "Ano Lançamento")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Informe o tipo de midia", AllowEmptyStrings = false)]
        [Display(Name = "Tipo de Midia")]
        public String TypeMidia { get; set; }

        [Required(ErrorMessage = "Informe uma direção", AllowEmptyStrings = false)]
        [Display(Name = "Direção")]
        public String Direction { get; set; }

        [Required(ErrorMessage = "Informe os atores participantes", AllowEmptyStrings = false)]
        [Display(Name = "Elenco")]
        public String Elenco { get; set; }
    
    }
}
