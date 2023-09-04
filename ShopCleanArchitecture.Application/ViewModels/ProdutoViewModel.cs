using ShopCleanArchitecture.Domain.Entities;
using System.Collections.Generic;

namespace ShopCleanArchitecture.Application.ViewModels
{
    public class ProdutoViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
