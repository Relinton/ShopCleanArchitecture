using Microsoft.AspNetCore.Mvc;
using ShopCleanArchitecture.Application.Interfaces;
using ShopCleanArchitecture.Application.ViewModels;

namespace ShopCleanArchitecture.Web.Mvc.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            ProdutoViewModel model = _produtoService.BuscarTodos();
            return View(model);
        }
    }
}
