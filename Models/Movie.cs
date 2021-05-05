using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcc.Models
{
    public class Movie
    {
        public int ID {get; set;}

        [StringLength(60, MinimumLength= 3)]//Tamanho mínimo: 3 caracteres; Máximo: 60
        [Required]
        public string Title {get; set;}

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get; set;}


        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]//Essa validação é uma expressão regular e precisa estar de uma forma específica (limita os caracteres que podem ou não ser utilizados)
        //Só podem ser utilizadas letras e a primeira deve ser MAIÚSCULA; números, espaços em branco e carcteres especiais não são permitidos
        [Required]
        [StringLength(30)]
        public string Genre {get; set;}


        [Range(1, 100)]//Tamanho vai de 1 a 100
        [DataType(DataType.Currency)]//O dado é do tipo MOEDA
        [Column(TypeName = "decimal(18,2)")]//Vai mapear e nos trazer no formato de moeda
        public decimal Price {get; set;}

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]//O primeiro deve ser maiúsculo e o resto tanto faz
        [StringLength(5)]
        [Required]
        public string Rating {get; set;}
    }
}