using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoIsBigger.Domain
{
    public class Game
    {
        public List<Player> Players = new List<Player>();
        public List<Round> Rounds = new List<Round>();
        public Round CurrentRound { get; private set; }

        public bool isGameFinished { get; private set; }
        public bool isRoundStarted { get; private set; }

        public Game(int bots, int rounds)
        {
            if (!ValidateGameParams(bots, rounds))
                throw new Exception("Введите количество ботов от 1 до 5\nВведите количество раундов от 1 до 10");

            CreateGameSession(bots, rounds);
        }

        public void StartRound()
        {
            if (isRoundStarted)
                throw new Exception("Раунд уже начат!");

            int lastPlayedRoundNumber = 0;

            foreach (Player player in Players)
            {
                if (player.Name == "Player")
                {
                    foreach (Dice dice in player.Dices)
                    {
                        if (dice.DiceRound.RoundNumber > lastPlayedRoundNumber)
                        {
                            lastPlayedRoundNumber = dice.DiceRound.RoundNumber;
                        }
                    }
                }
            }

            foreach (Round round in Rounds)
            {
                if (lastPlayedRoundNumber + 1 == round.RoundNumber)
                {
                    CurrentRound = round;
                    isRoundStarted = true;
                }
            }
        }

        public void StopGame()
        {
            isGameFinished = true;
        }

        public void RollDice()
        {
            if (!isRoundStarted)
                throw new Exception("Раунд не начат!");

            foreach (Player player in Players)
            {
                Dice dice = new Dice(CurrentRound);
                dice.MakeRoll();
                player.Dices.Add(dice);
            }

            isRoundStarted = false;
        }

        public void SaveRollResult(Player player, Dice dice)
        {
            if (dice.Result == 0)
                throw new Exception(string.Format("Бросок игрока {0} не выполнен", player.Name));
            
            player.Dices.Add(dice);
        }

        private void CreateGameSession(int bots, int rounds)
        {
            Players.Add(new Player("Player"));

            for (int i = 1; i <= bots; i++)
            {
                Player bot = new Player(string.Format("Bot{0}", i));

                Players.Add(bot);
            }

            for (int i = 1; i <= rounds; i++)
            {
                Round round = new Round(i);

                Rounds.Add(round);
            }
        }

        private bool ValidateGameParams(int bots, int rounds)
        {
            return !(bots < 1 || bots > 5 || rounds < 1 || rounds > 10);
        }

        public void AddScore(Player player)
        {
            player.Score++;
        }
    }
}
