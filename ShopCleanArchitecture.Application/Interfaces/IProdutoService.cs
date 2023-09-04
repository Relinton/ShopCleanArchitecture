using ShopCleanArchitecture.Application.ViewModels;

namespace ShopCleanArchitecture.Application.Interfaces
{
    public interface IProdutoService
    {
        ProdutoViewModel BuscarTodos();
    }
}
