using AbpProject.Products;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpProject.Map
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ProductDto > ();
            CreateMap<UpdateProductDto, Product> ();
        }
    }
}
