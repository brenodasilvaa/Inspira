using Inspira_Music.Domain.Entities;

namespace Inspira_Music.Api.Dtos
{
    public class CreateTrackInspiration
    {
        public Track Track { get; set; }
        public Track TrackInspired { get; set; }
    }
}
