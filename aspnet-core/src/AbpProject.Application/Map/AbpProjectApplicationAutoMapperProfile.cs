using AbpProject.Books;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpProject.Map
{
    public class AbpProjectApplicationAutoMapperProfile : Profile
    {
        public AbpProjectApplicationAutoMapperProfile()
        {
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
