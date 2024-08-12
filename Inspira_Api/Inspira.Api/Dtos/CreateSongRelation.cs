namespace Inspira_Music.Api.Dtos
{
    public class CreateSongRelation
    {
        public Guid OriginalSongId { get; set; }
        public Guid InspiredSongId { get; set; }
    }
}
