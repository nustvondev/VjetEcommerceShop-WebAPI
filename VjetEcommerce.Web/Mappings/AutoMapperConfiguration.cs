using AutoMapper;
using VjetEcommerce.Model.Models;
using VjetEcommerce.Web.Models;

namespace VjetEcommerce.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
        }
    }
}