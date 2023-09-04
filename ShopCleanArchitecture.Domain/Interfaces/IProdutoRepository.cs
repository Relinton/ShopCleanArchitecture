using ShopCleanArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace ShopCleanArchitecture.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> BuscarTodos();
    }
}
