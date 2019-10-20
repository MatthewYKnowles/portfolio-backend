using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace Portfolio.Backend.Data.Internal
{
    public class ConferenceTalksRepository : IConferenceTalksRepository
    {
        public void SaveTalk(string id, string conferenceTitle, string conferenceCity, string conferenceUrl, string talkTitle, string talkUrl,
            string videoUrl)
        {
            var dbClient = new AmazonDynamoDBClient();
            var context = new DynamoDBContext(dbClient);
            var conferenceTalk = new ConferenceTalk
            {
                Id = id,
                ConferenceTitle = conferenceTitle,
                ConferenceCity = conferenceCity,
                ConferenceUrl = conferenceUrl,
                TalkTitle = talkTitle,
                TalkUrl = talkUrl,
                VideoUrl = videoUrl
            };
            context.SaveAsync(conferenceTalk).Wait();
        }
    }

    [DynamoDBTable("ConferenceTalks")]
    public class ConferenceTalk
    {
        [DynamoDBHashKey] public string Id { get; set; }
        [DynamoDBProperty] public string ConferenceTitle { get; set; }
        [DynamoDBProperty] public string ConferenceCity { get; set; }
        [DynamoDBProperty] public string ConferenceUrl { get; set; }
        [DynamoDBProperty] public string TalkTitle { get; set; }
        [DynamoDBProperty] public string TalkUrl { get; set; }
        [DynamoDBProperty] public string VideoUrl { get; set; }
    }
}