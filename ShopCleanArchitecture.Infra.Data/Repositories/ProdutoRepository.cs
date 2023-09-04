using ShopCleanArchitecture.Domain.Entities;
using ShopCleanArchitecture.Domain.Interfaces;
using ShopCleanArchitecture.Infra.Data.Context;
using System.Collections.Generic;

namespace ShopCleanArchitecture.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> BuscarTodos()
        {
            return _context.Produtos;
        }
    }
}
