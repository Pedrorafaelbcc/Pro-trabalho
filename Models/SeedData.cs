using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bcc.Data;
using System;
using System.Linq;


namespace bcc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new BccContext(
            
                serviceProvider.GetRequiredService<
                DbContextOptions<BccContext>>()))

            {
                //Ver se tem algum filme cadastrado
                if(context.Movie.Any())//Se tiver algum filme cadastrado
                {
                    return;//retorno toos os filmes cadastrados
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Interestelar",
                        ReleaseDate = DateTime.Parse("2014-11-6"),
                        Genre = "Ficção Científica",
                        Price = 14.99M
                    },
                    new Movie
                    {
                        Title = "Como Treinar Seu Dragão",
                        ReleaseDate = DateTime.Parse("2010-3-26"),
                        Genre = "Animação",
                        Price = 10M
                    },
                    new Movie
                    {
                        Title = "Bastardos Inglórios",
                        ReleaseDate = DateTime.Parse("2009-10-9"),
                        Genre = "Ação",
                        Price = 30M
                    },
                    new Movie
                    {
                        Title = "Luca",
                        ReleaseDate = DateTime.Parse("2021-6-16"),
                        Genre = "Animação",
                        Price = 133M
                    }
                );
                context.SaveChanges();
            }    
        }
    }
}