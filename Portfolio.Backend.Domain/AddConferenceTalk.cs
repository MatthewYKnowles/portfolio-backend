using System;
using Portfolio.Backend.Data;
using Portfolio.Backend.Data.Internal;

namespace Portfolio.Backend.Domain
{
    public class AddConferenceTalk
    {
        private readonly IConferenceTalksRepository conferenceTalksRepository;

        public AddConferenceTalk(IConferenceTalksRepository conferenceTalksRepository)
        {
            this.conferenceTalksRepository = conferenceTalksRepository;
        }

        public void Execute(string conferenceTitle, string conferenceCity, string conferenceUrl, string talkTitle,
            string talkUrl, string videoUrl, DateTime talkDate)
        {
            var id = Guid.NewGuid().ToString();
            conferenceTalksRepository.SaveTalk(id, conferenceTitle, conferenceCity, conferenceUrl, talkTitle, talkUrl, videoUrl, talkDate);
        }
    }
}