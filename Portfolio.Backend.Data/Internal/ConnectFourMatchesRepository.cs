using System;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace Portfolio.Backend.Data.Internal
{
    public class ConnectFourMatchesRepository : IConnectFourMatchesRepository
    {
        public void SaveConnectFourMatch(string id, string playerOneName, string playerTwoName, string gameResult, string winningPlayer)
        {
            var dbClient = new AmazonDynamoDBClient();
            var context = new DynamoDBContext(dbClient);
            var connectFourMatch = new ConnectFourMatch
            {
                MatchId = id,
                PlayerOneName = playerOneName,
                PlayerTwoName = playerTwoName,
                GameResult = gameResult,
                WinningPlayer = winningPlayer
            };
            context.SaveAsync(connectFourMatch).Wait();
        }
    }

    [DynamoDBTable("ConnectFourMatches")]
    public class ConnectFourMatch
    {
        [DynamoDBHashKey] public string MatchId { get; set; }
        [DynamoDBProperty] public string PlayerOneName { get; set; }
        [DynamoDBProperty] public string PlayerTwoName { get; set; }
        [DynamoDBProperty] public string GameResult { get; set; }
        [DynamoDBProperty] public string WinningPlayer { get; set; }
    }
}