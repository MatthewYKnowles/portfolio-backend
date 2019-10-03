namespace Portfolio.Backend.Data
{
    public interface IConnectFourMatchesRepository
    {
        void SaveConnectFourMatch(string id, string playerOneName, string playerTwoName, string gameResult, string winningPlayer);
    }
}