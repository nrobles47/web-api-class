using AutoMapper;
using EmployeesApi.Data;

namespace EmployeesApi.MapperProfiles;

public class EmployeeMaps : Profile
{
    public EmployeeMaps()
    {
        CreateMap<EmployeeEntity, EmployeeSummaryListItemResponse>()
            .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id.ToString()));

        CreateMap<EmployeeEntity, EmployeeDetailsItemResponse>()
            .ForMember(dest => dest.Id, opts => opts.MapFrom(src => src.Id.ToString()));
    }
}
