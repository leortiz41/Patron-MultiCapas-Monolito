
namespace Biblioteca.Domain.Entities
{
    public class Libro 
    {
        public required string Titulo { get; set; }
        public required string Genero { get; set; }
        public required DateTime DataPublicacion { get; set; }
        public required int AutorId { get; set; }
        public required Autor Autor { get; set; }
    }
}