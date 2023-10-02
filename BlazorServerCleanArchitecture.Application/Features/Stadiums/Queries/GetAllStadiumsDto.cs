using BlazorServerCleanArchitecture.Application.Common.Mappings;
using BlazorServerCleanArchitecture.Domain.Entities;

namespace BlazorServerCleanArchitecture.Application.Features.Stadiums.Queries
{
    public class GetAllStadiumsDto : IMapFrom<Stadium>
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public string City { get; set; }
        public int? Capacity { get; set; }
        public int? BuiltYear { get; set; }
        public int? PitchLength { get; set; }
        public int? PitchWidth { get; set; }
    }
}