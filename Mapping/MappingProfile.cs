using System.Linq;
using AutoMapper;
using vega.Controllers.Resources;
using vega.Models;

namespace vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<Vehicle, VehicleResource>()
                .ForMember(vr => vr.Contact,
                    opt => opt.MapFrom(v => new ContactResource
                    {
                        Name = v.ContactName,
                        Email = v.ContactEmail,
                        Phone = v.ContactPhone
                    }))
                .ForMember(vr => vr.Features, 
                    opt => opt.MapFrom(
                        v => v.Features.Select(vf => vf.FeatureId)));
            
            // API Resource to Domain
            CreateMap<VehicleResource, Vehicle>()
                .ForMember(x => x.ContactName,
                    opt => opt.MapFrom(vr => vr.Contact.Name))
                .ForMember(x => x.ContactEmail,
                    opt => opt.MapFrom(vr => vr.Contact.Email))
                .ForMember(x => x.ContactPhone,
                    opt => opt.MapFrom(vr => vr.Contact.Phone))
                .ForMember(x => x.Features,
                    opt => opt.MapFrom(vr => 
                                            vr.Features.Select(id => new VehicleFeature { FeatureId = id })));
        }
    }
}