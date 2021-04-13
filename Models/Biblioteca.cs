using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prova_Ex6_5_Sem.Models
{
    [Table("Biblioteca")]
    public class Biblioteca
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome do Livro:")]
        public string NomeLivro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome do Autor:")]
        public string Autor { get; set; }

        [Display(Name = "Genero do livro:")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Numero de paginas do livro:")]
        public int NPaginas { get; set; }

        [Display(Name = "Prefácio do Livro:")]
        public string Prefacio { get; set; }

        [Display(Name = "Data de criação do livro:")]
        public int AnoLivro { get; set; }

    }
}
