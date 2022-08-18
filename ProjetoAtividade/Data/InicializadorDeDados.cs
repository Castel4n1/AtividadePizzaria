
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProjetoAtividade.Data;
using ProjetoAtividade.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IngressoMVC.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope
                    .ServiceProvider
                    .GetService<PizzariaDbContext>();

                context.Database.EnsureCreated();

                if (!context.Tamanhos.Any())
                {
                    context.Tamanhos.AddRange(new List<Tamanho>()
                    {
                        new Tamanho("Grande"),
                        new Tamanho("Média"),
                        new Tamanho("Pequeno"),
                    });
                    context.SaveChanges();
                }

                if (!context.Sabores.Any())
                {
                    context.Sabores.AddRange(new List<Sabor>()
                    {
                        new Sabor("Mussarela","https://media.gettyimages.com/photos/grated-cheese-picture-id155396168?s=2048x2048"),
                        new Sabor("Atum","https://media.gettyimages.com/photos/tuna-salad-picture-id175602146?s=2048x2048"),
                        new Sabor("Peperoni","https://media.gettyimages.com/photos/slices-of-salami-on-a-cutting-board-picture-id168269008?s=2048x2048")
                    });
                    context.SaveChanges();
                }

                if (!context.Pizzas.Any())
                {
                    context.Pizzas.AddRange(new List<Pizza>()
                    {
                        new Pizza("Pizza de Peperoni",100,"https://static8.depositphotos.com/1328914/862/i/600/depositphotos_8629462-stock-photo-pepperoni-pizza.jpg",1),
                        new Pizza("Pizza de Mussarela",300,"https://media.gettyimages.com/photos/cooking-italian-vegetarian-pizza-with-vegetables-and-mushrooms-at-on-picture-id1253249913?s=2048x2048",1),
                        new Pizza("Pizza de Atum",500,"https://media.gettyimages.com/photos/pizza-tuna-onion-herbs-on-plate-picture-id182878095?s=2048x2048",1)
                    });
                    context.SaveChanges();
                }

                if (!context.PizzaSabores.Any())
                {
                    context.PizzaSabores.AddRange(new List<PizzaSabor>()
                    {
                        new PizzaSabor(3, 1),
                        new PizzaSabor(1, 2),
                        new PizzaSabor(2, 3)
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}