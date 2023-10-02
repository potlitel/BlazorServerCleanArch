using BlazorServerCleanArchitecture.Domain.Common;

namespace BlazorServerCleanArchitecture.Domain.Entities
{
    public class Stadium : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public int? Capacity { get; set; }
        public int? BuiltYear { get; set; }
        public int? PitchLength { get; set; }
        public int? PitchWidth { get; set; }
    }
}