using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace Portfolio.Backend.Lambda.ConnectFour
{
    public class ConnectFourFunctions
    {
        public void AddConnectFourMatch(AddConnectFourRecordRequest request)
        {
            
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