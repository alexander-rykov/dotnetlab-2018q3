using AutoMapper;

namespace MLA_task.Mapping
{
    //public class DemoMapper : Profile
    //{
    //    /// <summary>
    //    /// Initializes a new instance of the <see cref="HangmanCategoryManagementMappingProfile"/> class.
    //    /// </summary>
    //    public DemoMapper()
    //    {
    //        this.DemoMap();
    //    }

    //    private void DemoMap()
    //    {
    //        CreateMap<CategoryDb, Category>()
    //            .ForMember(category => category.CategoryId, model => model.MapFrom(categoryDb => categoryDb.Id))
    //            .ForMember(category => category.Name, model => model.MapFrom(categoryDb => categoryDb.Name))
    //            .ForMember(category => category.Words, model => model.MapFrom(categoryDb => categoryDb.Words));

    //        CreateMap<Category, CategoryDb>()
    //            .ForMember(categoryDb => categoryDb.Id, model => model.MapFrom(category => category.CategoryId))
    //            .ForMember(categoryDb => categoryDb.Name, model => model.MapFrom(category => category.Name))
    //            .ForMember(categoryDb => categoryDb.Words, model => model.MapFrom(category => category.Words))
    //            .ForMember(categoryDb => categoryDb.Created, model => model.Ignore())
    //            .ForMember(categoryDb => categoryDb.CreatorId, model => model.Ignore())
    //            .ForMember(categoryDb => categoryDb.Modified, model => model.Ignore())
    //            .ForMember(categoryDb => categoryDb.ModifierId, model => model.Ignore())
    //            .ForAllOtherMembers(wordDb => wordDb.Ignore());
    //    }
    //}
}