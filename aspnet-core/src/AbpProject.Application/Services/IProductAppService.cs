using AbpProject.Products;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AbpProject.Services
{
    public interface IProductAppService : IApplicationService
    {
        Task<Product> CreateProductAsync(Product createProduct);
    }
}