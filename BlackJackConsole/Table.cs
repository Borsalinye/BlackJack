using BlackJackConsole.Person;

namespace BlackJackConsole
{
    class Table
    {
        public const int winPoint = 21;
        public Dealer dealer { get; set; }
        public Player player { get; set; }
        public Table(Dealer dealer, Player player)
        {
            this.dealer = dealer;
            this.player = player;
        }
        public Table NewGame()
        {
            return new Table(Dealer.GetInstance(), Player.GetInstance());
        }
    }
}
