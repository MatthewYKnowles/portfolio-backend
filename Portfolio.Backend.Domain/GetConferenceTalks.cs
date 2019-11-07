using System;
using System.Collections.Generic;
using System.Linq;
using Portfolio.Backend.Data;

namespace Portfolio.Backend.Domain
{
    public class GetConferenceTalks
    {
        private readonly IConferenceTalksRepository conferenceTalksRepository;

        public GetConferenceTalks(IConferenceTalksRepository conferenceTalksRepository)
        {
            this.conferenceTalksRepository = conferenceTalksRepository;
        }

        public IEnumerable<ConferenceTalk> Execute()
        {
            var conferenceTalks = conferenceTalksRepository.GetConferenceTalks();
            return conferenceTalks.Select(x => new ConferenceTalk
            {
                ConferenceTitle = x.ConferenceTitle,
                ConferenceCity = x.ConferenceCity,
                ConferenceUrl = x.ConferenceUrl,
                TalkTitle = x.TalkTitle,
                TalkUrl = x.TalkUrl,
                VideoUrl = x.VideoUrl,
                TalkDate = x.TalkDate
            }).OrderByDescending(x => x.TalkDate);
        }
    }

    public class ConferenceTalk
    {
        public string ConferenceTitle { get; set; }
        public string ConferenceCity { get; set; }
        public string ConferenceUrl { get; set; }
        public string TalkTitle { get; set; }
        public string TalkUrl { get; set; }
        public string VideoUrl { get; set; }
        public DateTime TalkDate { get; set; }
    }
}