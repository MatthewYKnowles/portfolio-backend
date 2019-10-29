using System;
using System.Collections.Generic;
using Portfolio.Backend.Data.Internal;

namespace Portfolio.Backend.Data
{
    public interface IConferenceTalksRepository
    {
        void SaveTalk(string id, string conferenceTitle, string conferenceCity, string conferenceUrl, string talkTitle,
            string talkUrl, string videoUrl, DateTime talkDate);

        IEnumerable<ConferenceTalk> GetConferenceTalks();
    }
}