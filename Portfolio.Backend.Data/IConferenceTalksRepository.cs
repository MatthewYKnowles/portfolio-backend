namespace Portfolio.Backend.Data.Internal
{
    public interface IConferenceTalksRepository
    {
        void SaveTalk(string id, string conferenceTitle, string conferenceCity, string conferenceUrl, string talkTitle, string talkUrl, string videoUrl);
    }
}