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
    }
}