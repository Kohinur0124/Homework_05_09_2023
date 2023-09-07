using AutoMapper;
using Models;
using Services.ViewModel;

namespace Books.AutoMapper
{
    public class AppProfile:Profile
    {
        public AppProfile()
        {
            CreateMap<Book,BookViewModel>().ReverseMap();
        }
    }
}
