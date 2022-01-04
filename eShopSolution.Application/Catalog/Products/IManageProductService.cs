
using eShopSolution.ViewModels.Catalog.Products;

using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task <int> Create(ProductCreateRequest request);

        Task <int> Update(ProductUpdateRequest request);
        Task <int> Delete(int productId);

        Task <bool> UpdatePrice(int productId, decimal newPrice);
        Task <List<ProductViewModel>> GetAll();

        Task <bool> UpdateStock(int productId, int addedQuantity);
        Task AđViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImages(int productId, List<IFormFile> files);

        Task<int> RemoveImages(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);

    }
}
