using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    class OneDayTeam : Player, ITeam
    {
        public static List<Player> list = new List<Player>();
        public OneDayTeam()
        {
            list.Capacity = 11;
        }
        public void Add(Player player)
        {
            list.Add(player);
        }
        public void Remove(int playerId)
        {
            Player p = null;

            foreach (var print in list)
            {
                if (print.PlayerId == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", print.PlayerId);
                    p = print;
                }
            }
            list.Remove(p);
        }
        public Player GetPlayerById(int playerId)
        {
            Player p = null;

            foreach (var print in list)
            {
                if (print.PlayerId == playerId)
                {
                    p = print;
                    break;
                }
                else
                {
                    Console.WriteLine("Player ID not found.");
                }
            }
            return p;
        }
        public Player GetPlayerByName(string playerName)
        {
            Player p = null;

            foreach (var print in list)
            {
                if (print.PlayerName == playerName)
                {
                    p = print;
                    break;
                }
                else
                {
                    Console.WriteLine("Player Name not found.");
                }
            }
            return p; 
        }

        public List<Player> GetAllPlayers()
        {
            return list;
        }
    }
}
