using Amazon.Lambda.Core;
using Portfolio.Backend.Data.Internal;
using Portfolio.Backend.Domain;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace Portfolio.Backend.Lambda.ConnectFour
{
    public class ConnectFourFunctions
    {
        public void AddConnectFourMatch(AddConnectFourRecordRequest request)
        {
            var connectFourMatchesRepository = new ConnectFourMatchesRepository();
            var addConnectFourMatch = new AddConnectFourMatch(connectFourMatchesRepository);
            addConnectFourMatch.Execute(request.PlayerOneName, request.PlayerTwoName, request.GameResult, request.WinningPlayer);
        }
    }

    public class AddConnectFourRecordRequest
    {
        public string PlayerOneName { get; set; }
        public string PlayerTwoName { get; set; }
        public string GameResult { get; set; }
        public string WinningPlayer { get; set; }
    }
}