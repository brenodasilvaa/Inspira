using Inspira_Music.Domain.Entities;
using Inspira_Music.Domain.Interfaces.Repository;
using Inspira_Music.Domain.Models;
using Neo4j.Driver;

namespace Inspira_Music.Infrastructure.Repository
{
    internal class SongRelationRepository : ISongRelationRepository
    {
        private IDriver _driver;

        public SongRelationRepository(IDriver driver)
        {
            _driver = driver;
        }

        public async Task<Guid> Create(SongRelation songRelation)
        {
            var uuid = Guid.NewGuid();

            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"MATCH (m:Song {{uuid: '{songRelation.OriginalSongId}'}}), (d:Song {{uuid: '{songRelation.InspiredSongId}'}}) " +
                    $"CREATE (p:SongRelation {{uuid: '{uuid}', created: datetime()}}) " +
                    $"CREATE (m)-[:BELONGS_TO]->(p) " +
                    $"CREATE (d)-[:BELONGS_TO]->(p) RETURN p");

                var result = await session.RunAsync(query);
            }

            return uuid;
        }

        public async Task<SongRelation> GetByIds(Guid original, Guid inspired, FilterBase filter)
        {
            var songRelation = new SongRelation();

            await using (var session = _driver.AsyncSession())
            {
                var query = new Query($"MATCH (a:Song {{uuid: '{original}'}})-[:BELONGS_TO]->(c)<-[:BELONGS_TO]-(b:Song {{uuid: '{inspired}'}}) RETURN c");

                var result = await session.RunAsync(query);

                foreach (var item in await result.ToListAsync())
                {
                    songRelation.Id = item["uuid"].As<Guid>();
                };
            }

            return songRelation;
        }
    }
}
