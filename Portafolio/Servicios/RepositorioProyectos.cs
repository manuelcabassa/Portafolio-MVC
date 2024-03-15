using Portafolio.Models;

namespace Portafolio.Servicios
{

    public interface IRepositorioProyectos
    {
        List<ProyectoViewModel> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>()
            {
                new ProyectoViewModel
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenUrl = "/imagenes/amazon.png"
                },
                                new ProyectoViewModel
                {
                    Titulo = "New York Times",
                    Descripcion = "Pãgina de noticias en JavaScript",
                    Link = "https://amazon.com",
                    ImagenUrl = "/imagenes/nyt.png"
                },
                   new ProyectoViewModel
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenUrl = "/imagenes/reddit.png"
                },                new ProyectoViewModel
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar video juegos.",
                    Link = "https://amazon.com",
                    ImagenUrl = "/imagenes/steam.png"
                }
            };
        }
    }
}
