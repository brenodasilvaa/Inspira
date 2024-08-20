using Inspira.Domain.Entities;

namespace Inspira.Api.Dtos
{
    public class CreateTrackRelationDto
    {
        public Track TrackSource { get; set; }
        public Track TrackDest { get; set; }
    }
}
