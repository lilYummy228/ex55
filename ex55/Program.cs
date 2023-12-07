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
            
        }
    }

    class LeaderBoard
    {
        private List<Player> _players = new List<Player>();

        public LeaderBoard()
        {

        }

        public void AddPlayers()
        {
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
            _players.Add(new Player("Роман", 10, 100));
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
    }
}
