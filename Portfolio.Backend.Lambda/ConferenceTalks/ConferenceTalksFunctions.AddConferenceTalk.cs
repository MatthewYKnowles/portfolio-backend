using System;
using Portfolio.Backend.Data.Internal;
using Portfolio.Backend.Domain;

namespace Portfolio.Backend.Lambda.ConferenceTalks
{
    public partial class ConferenceTalksFunctions
    {
        public void AddConferenceTalk(AddConferenceTalkRequest request)
        {
            var conferenceTalksRepository = new ConferenceTalksRepository();
            var addConferenceTalk = new AddConferenceTalk(conferenceTalksRepository);
            addConferenceTalk.Execute(request.ConferenceTitle, request.ConferenceCity, request.ConferenceUrl,
                request.TalkTitle, request.TalkUrl, request.VideoUrl, request.TalkDate);
        }
    }
    
    public class AddConferenceTalkRequest
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