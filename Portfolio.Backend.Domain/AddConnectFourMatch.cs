using Portfolio.Backend.Data;

namespace Portfolio.Backend.Domain
{
    public class AddConnectFourMatch
    {
        private readonly IConnectFourMatchesRepository connectFourMatchesRepository;

        public AddConnectFourMatch(IConnectFourMatchesRepository connectFourMatchesRepository)
        {
            this.connectFourMatchesRepository = connectFourMatchesRepository;
        }

        public void Execute(string playerOneName, string playerTwoName, string gameResult, string winningPlayer)
        {
            connectFourMatchesRepository.SaveConnectFourMatch(playerOneName, playerTwoName, gameResult, winningPlayer);
        }
    }
}