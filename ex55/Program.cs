using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeaderBoard leaderBoard = new LeaderBoard();

            leaderBoard.ShowTopPlayers();
            leaderBoard.ShowPlayers();
        }
    }

    class LeaderBoard
    {
        private List<Player> _players = new List<Player>();
        private List<Player> _levelTop = new List<Player>();
        private List<Player> _powerTop = new List<Player>();

        public LeaderBoard()
        {
            AddPlayers();
            OrderByPower();
            OrderByLevel();
        }

        public void ShowPlayers()
        {
            Console.WriteLine("\n\nПолный список игроков: ");

            foreach (Player player in _players)
            {
                player.ShowInfo();
            }
        }

        public void ShowTopPlayers()
        {            
            int topSize = 3;

            List<Player> topLevelPlayers = GetTop(topSize, _levelTop);
            List<Player> topPowerPlayers = GetTop(topSize, _powerTop);

            Console.WriteLine("Топ игроков по уровню: ");
            ShowPlayers(topLevelPlayers);

            Console.WriteLine("\n");

            Console.WriteLine("Топ игроков по силе: ");
            ShowPlayers(topPowerPlayers);
        }

        private void ShowPlayers(List<Player> topPlayers)
        {
            int placeInBorder = 1;

            foreach (Player player in topPlayers)
            {
                Console.Write($"{placeInBorder}. ");
                player.ShowInfo();
                placeInBorder++;
            }
        }

        private List<Player> GetTop(int topSize, List<Player> topPlayers)
        {
            List<Player> topPlayerList = new List<Player>();

            for (int i = 0; i < topSize; i++)
            {
                topPlayerList.Add(topPlayers[i]);
            }

            return topPlayerList;
        }

        private void OrderByPower()
        {
            var topPlayers = _players.OrderByDescending(player => player.Power).ToList();
            _powerTop = topPlayers;
        }

        private void OrderByLevel()
        {
            var topPlayers = _players.OrderByDescending(player => player.Level).ToList();
            _levelTop = topPlayers;
        }

        private void AddPlayers()
        {
            Random random = new Random();
            int minLevel = 1;
            int maxLevel = 100;
            int minPower = 10;
            int maxPower = 1000;

            _players.Add(new Player("Роман", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Олег", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Никита", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Василий", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Дмитрий", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Данил", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Григорий", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Марина", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Егор", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
            _players.Add(new Player("Михаил", random.Next(minLevel, maxLevel), random.Next(minPower, maxPower)));
        }
    }

    class Player
    {
        public Player(string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }

        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}. {Level} уровень. Сила: {Power}");
        }
    }
}
