
using Biblioteca.Domain.Entities;

namespace Biblioteca.Domain.Validation
{
    public class AutorValidation : IAutorValidator
    {
        public void Validate(Autor autor)
        {
            if (string.IsNullOrWhiteSpace(autor.Name))
            {
                throw new ArgumentException("El nombre del autor no puede estar vacío.");
            }
        }
    }
}