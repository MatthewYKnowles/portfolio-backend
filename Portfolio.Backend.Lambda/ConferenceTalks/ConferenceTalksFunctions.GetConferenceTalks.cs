using System.Collections.Generic;
using Portfolio.Backend.Data.Internal;
using Portfolio.Backend.Domain;
using ConferenceTalk = Portfolio.Backend.Domain.ConferenceTalk;

namespace Portfolio.Backend.Lambda.ConferenceTalks
{
    public partial class ConferenceTalksFunctions
    {
        public GetConferenceTalksResponse GetConferenceTalks()
        {
            var conferenceTalksRepository = new ConferenceTalksRepository();
            var getConferenceTalks = new GetConferenceTalks(conferenceTalksRepository);
            var conferenceTalks = getConferenceTalks.Execute();
            return new GetConferenceTalksResponse
            {
                ConferenceTalks = conferenceTalks
            };
        }
    }

    public class GetConferenceTalksResponse
    {
        public IEnumerable<ConferenceTalk> ConferenceTalks { get; set; }
    }
}