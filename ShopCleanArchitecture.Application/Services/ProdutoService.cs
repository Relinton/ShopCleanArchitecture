using ShopCleanArchitecture.Application.Interfaces;
using ShopCleanArchitecture.Application.ViewModels;
using ShopCleanArchitecture.Domain.Interfaces;

namespace ShopCleanArchitecture.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        public IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ProdutoViewModel BuscarTodos()
        {
            return new ProdutoViewModel()
            {
                Produtos = _produtoRepository.BuscarTodos()
            };
        }
    }
}
