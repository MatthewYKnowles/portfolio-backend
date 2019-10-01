namespace Portfolio.Backend.Data
{
    public interface IConnectFourMatchesRepository
    {
        void SaveConnectFourMatch(string playerOneName, string playerTwoName, string gameResult, string winningPlayer);
    }
}