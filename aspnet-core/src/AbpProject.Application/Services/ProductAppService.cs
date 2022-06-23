using AbpProject.Products;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;

namespace AbpProject.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public ProductAppService(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Product> CreateProductAsync(Product createProduct)
        {
            Check.NotNullOrWhiteSpace(createProduct.Name, nameof(createProduct.Name));

            var existingProduct = await _repository.FirstOrDefaultAsync(x => x.Name == createProduct.Name);
            if (existingProduct != null)
            {
                throw new ProductAlreadyExistsException();
            }
            var create = new ProductDto
            {
                Name = createProduct.Name,
                Type = createProduct.Type,
                Price =createProduct.Price,
                CreatedDate = DateTime.Now,
            };
            await _repository.InsertAsync(createProduct);
            return createProduct;
        }
    }
}
