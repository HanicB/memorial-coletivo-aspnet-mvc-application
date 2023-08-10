using Microsoft.AspNetCore.Builder;
using MemorialColetivo.Models;
using Microsoft.Extensions.DependencyInjection;
namespace MemorialColetivo.Data;
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

            //Usuario
            if (!context.Usuario.Any())
            {
                context.Usuario.AddRange(new List<Usuario>(){
                    new Usuario()
                    {
                        FullName = "Will",
                        ProfilePictureURL = "https://dotnethow.net/images/actors/actor-5.jpeg",
                        Bio = "Descricao usuario"
                    },
                    new Usuario()
                    {
                        FullName = "Jim",
                        ProfilePictureURL = "https://dotnethow.net/images/actors/actor-4.jpeg",
                        Bio = "Descricao usuario"
                    }
                });
                context.SaveChanges();
            }
            //Memorial
            if (!context.Memorial.Any())
            {
                context.Memorial.AddRange(new List<Memorial>(){
                    new Memorial()
                    {
                        Name = "July",
                        MemorialPictureURL = "https://dotnethow.net/images/actors/actor-3.jpeg",
                        DataNascimento = DateTime.Now.AddDays(-10),
                        DataFalecimento = DateTime.Now.AddDays(-2),
                        Historia = "Historia do homenageado",
                        Formacao = "Atriz",
                        Religiao = "Sem religião",
                        Hobbies = "Cozinhar"
                    },
                    new Memorial()
                    {
                        Name = "Matt",
                        MemorialPictureURL = "https://dotnethow.net/images/actors/actor-1.jpeg",
                        DataNascimento = DateTime.Now.AddDays(3),
                        DataFalecimento = DateTime.Now.AddDays(20),
                        Historia = "Historia do homenageado",
                        Formacao = "Ator",
                        Religiao = "Cristianismo",
                        Hobbies = "Cozinhar"
                    }
                });
                context.SaveChanges();
            }
            //Usuario_Memorial
            if (!context.Usuario_Memorial.Any())
            {
                context.Usuario_Memorial.AddRange(new List<Usuario_Memorial>(){
                    new Usuario_Memorial()
                    {
                        UsuarioId = 1,
                        MemorialId = 1
                    },
                    new Usuario_Memorial()
                    {
                        UsuarioId = 2,
                        MemorialId = 2
                    }
                });
                context.SaveChanges();
            }
        }
        }
    }