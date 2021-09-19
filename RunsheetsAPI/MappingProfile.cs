using AutoMapper;
using Entities.Models;
using Entities.DataTransferObjects;

namespace RunsheetsAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DataField, DataFieldDto>();
            CreateMap<InputType, InputTypeDto>();
            CreateMap<Runsheet, RunsheetDto>();
            CreateMap<SubSection, SubSectionDto>();
        }
    }
}
