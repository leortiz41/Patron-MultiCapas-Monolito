
namespace Biblioteca.Domain.Entities
{
    public class Autor  
    {
        public string Name { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataFalecimento { get; set; }
    }
}